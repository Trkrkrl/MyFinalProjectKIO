using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>//IProduct daldaki çalışmaların benzerini burda da yapacağız
    {//generic bir yapıya sahip interface kullanırsak hem productdal hem category kullanır tek tek product category vs yazmayız

       /* List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);*/

        //GET ADD DELETE UPDATE GETALL fonksiyonları core.dataccaess.ıentittyy repository de artık, bundan dolayı yoruma alındı nu  kısım

       // List<Category> GetAllByCategory(int categoryId);//kategoriye göre filtreleme için


    }
}
