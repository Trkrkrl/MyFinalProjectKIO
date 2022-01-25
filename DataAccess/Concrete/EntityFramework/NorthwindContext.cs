using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{//db tabloları ile proje class larını bağlamaktır görevi
    //burada enitity framwork.core gerekti db contextin çalışması için
    //Entitiy sürümü .net ürümünle uyumlu olmaı ben 6 denedim hata errid  5 kurdum oldu


    public class NorthwindContext:DbContext
    {
        //projen hangi veritabanı ile illişkili olduğunu belirrtiğğmin yer aşağısı//sanki apconfigede yapıyorduk burayı

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true;");//sql kullanacğımızı belirtelim\ ter sılaş kullanacağında @ kullanırız


        }
        //veritabanı verdik te
        //Hangi nesne hangi nesneye bağlanacak
        //aşağıda dbset ile yapıcaz
        //dbset içerisindeki bizimki
        //sağdaki veritabanındaki tablo adı

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //entitiy e diyoz ki benim bir order nesnem var oreders ile ilişkilendir
        public DbSet<Order> Orders { get; set; }


    }
}
