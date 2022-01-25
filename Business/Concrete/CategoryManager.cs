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
    public class CategoryManager : ICategoryService
    {//servisimizdena alıyoz-implemente ettik

        //iş kodlarımızı yazıcazilerde 




        ICategoryDal _categoryDal;//burada ctor ile yapıcaz

        public CategoryManager(ICategoryDal categoryDal)

        {
            _categoryDal = categoryDal;
        }

        //---

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c=>c.CategoryId==categoryId);
        }
    }
}
