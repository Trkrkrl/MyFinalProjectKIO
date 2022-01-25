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
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);

        //dto dan sonra ekledik , product detailsi içeren tablolar joini kendisi
        List<ProductDetailDto> GetProductDetails();

    }
}
