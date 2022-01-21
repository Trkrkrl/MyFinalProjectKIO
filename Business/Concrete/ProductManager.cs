using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
    }
}
