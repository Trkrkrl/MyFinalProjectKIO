using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;//IEntitiy repository yeri değişince refeerans olarak geldi
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {//buraya ürüne özel operasyonlar gelecek

        //DTO oluşturduktan sonra buraya gelip bunu yazdık
        List<ProductDetailDto> GetProductDetails();

    }
}
