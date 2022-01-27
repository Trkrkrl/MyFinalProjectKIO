using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public interface IProductService//referans ekledik de çalıştı
    {
        //getallı sildik-IDataresult <T> e çevirdik
        IDataResult<List<Product>> GetAll();//hem şilme sonucu hem mesaj hem dmöndüreceği şeyi içerecek
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        //dto dan sonra ekledik , product detailsi içeren tablolar joini kendisi
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);//burada void vardı sen artık result döndür diyoz

        
    }
}
