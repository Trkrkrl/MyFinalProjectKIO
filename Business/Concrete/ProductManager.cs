using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {//bir iş sınıfı başka sınıfları new  lemez 
     //bunun için injection yapıyoruz

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)//nasıl IResult verebildik ,üst katman olduğundan o da geçerli burda
            //business codes
            //eğer hatalı bilgi girişi olursa
         {	
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }


            
            //servis ten implemmente ile geldi-daha sonra void yerine  Ireslut
            _productDal.Add(product);
            // return new Result(true,"Ürün eklendi");//bişey dönmemiz gerekiyordu/result v-ctorlandı
            //bu kodu değiştirdik sonra
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()//idataresulta çevirdik
        {
            //iş kodları buraya gelecek:ifler vs yetkisi varmı ?
            //ha ozaman  alttaki kodu işle diyor

            //return _productDal.GetAll();
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);

            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProdutsListed);
            
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p => p.CategoryId == id));
            //p nin c id si benim gönderdğiğim id ye eşitse onları filtrele demek
        }

        

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));//
            //eticaret sitemizde fiyat aralığı ayarlama
        }
        //dto dan sonra interface getproductdetails tanımladığımız için buraya da implemente etmemiz gerekti

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult< List < ProductDetailDto >> (_productDal.GetProductDetails());
        }
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>( _productDal.Get(p => p.ProductId == productId));
        }
    }
}
