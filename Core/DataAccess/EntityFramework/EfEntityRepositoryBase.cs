using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>//çalışacağım tablonun tipi ile bir de context ver 
    where TEntity : class, IEntity,new()
    where TContext:DbContext,new()//newlenebilir olsun koşulu verdik
        //yukar da kullandığımız bu yapıyı şöyle anla,IEntityRepository<TEntity> bu kendi T yani tip kullanıyordu,
        //buraya gelidnce buradaki base gibi bir tablo kullanacak içerisine tip olarak bus eferTEntity diye tablo tipi vermiş olduk

    {
        //aşağıdaki koldarı add vs yi dataaccess.concrete.ef ten efproductdal kesip aldık
        // product yerine TEntity yazdık, northwind context yerine TContex yazdık

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())//using (bu normal using değil)içerisindeki nesneler işi bitince garbage collector atar  -bu performasn sağlarr
            {
                var addedEntity = context.Entry(entity);//entity nesenemiz, product veya başka birşey temsii,l ediyor
                //veri kaynağındakine benim veridğimi eşleştir-burada ekliyoz sadece tabi
                addedEntity.State = EntityState.Added;//elemanın durumu artık Entitiye eklenecek diyor
                //durumu ekleme olarak set ettik
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;

                context.SaveChanges();

            }
        }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;

                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
                //tabi burada product yazdık -bu standart diğer elemmntler için de
                //bu yüzden ilerde generic yapacaz onu

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {//filtre-varsa veya yoksa
                // set diyorki db setlerden product a bağlanıyorum
                //benim product uma yerleş ve oradaki tüm datayı liste çevir
                //eğer değilse
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();


            }
        }


    }
}
