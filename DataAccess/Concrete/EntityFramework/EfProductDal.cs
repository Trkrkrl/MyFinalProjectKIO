using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        //burada önceden duran add update delete vs koldarı EfEntityRepobase e  'core daki' gönderip modifiye ettik
        //product Tenntity, northwindcontext tcontextoldu

        //EfEntityRepositoryBase<Product,NorthwindContext>
        //benim yapacağım operasyonllar burda var dedik
        //peki burada IProduct dal niye var halen: çünü IProductdal içerisinde ürüne özel operasyonlar geleccek
        
        //dto dan snoraki implementasyon ile geldi
        public List<ProductDetailDto> GetProductDetails()
        {
            //aşağıda Linq  : language integrated query yani dil içerinide sql benzeri bir kullaımm yapısı
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId//tabloları joinlerdik peki hangi kolonları istiyorsun, subqueryabcaz galiba
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock

                             };
                return result.ToList();
    
            }
        }
    }
}
