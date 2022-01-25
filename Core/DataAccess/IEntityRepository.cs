using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess//bu dosyayı core a taşıdık öncedek concrete.ef deydi
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {//bu yapı bir kere yazılır

        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //filtreler yazabilmemize olanak sunar, categoriye vs göre getirme işini yapamıza olnak sunuyor


        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       // buna artık ihtyiaç yok List<T> GetAllByCategory(int categoryId);//kategoriye göre filtreleme için

    }
}
