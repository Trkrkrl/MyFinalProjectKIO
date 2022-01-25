using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext> , ICategoryDal //implement ile kodlar direkt geldi
    {//EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext> bunu EfProduct dal a yapmıştık nedeni orada yazıyo
        
    }
}
