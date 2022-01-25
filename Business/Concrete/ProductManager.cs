using Business.Abstract;
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

        public List<Product> GetAll()
        {
            //iş kodları buraya gelecek:ifler vs yetkisi varmı ?
            //ha ozaman  alttaki kodu işle diyor

            return _productDal.GetAll();
            
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
            //p nin c id si benim gönderdğiğim id ye eşitse onları filtrele demek
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);//
            //eticaret sitemizde fiyat aralığı ayarlama
        }
        //dto dan sonra interface getproductdetails tanımladığımız için buraya da implemente etmemiz gerekti

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
