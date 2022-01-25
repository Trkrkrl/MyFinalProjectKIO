using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
        //bunu vusinesstaki category manager e implemente edecez
    {
        List<Category> GetAll();
        Category GetById(int categoryId);//id ye göre çekeceğimizden tek bir kategori çekecek



    }
}
