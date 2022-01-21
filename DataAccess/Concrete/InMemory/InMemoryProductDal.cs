using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
        //bir veri varmış gibi bir ürün listesi tanımlayalım,
    {
        List<Product> _products;//metotların dışında tanımlanınac GLOBAL DEĞİŞKENALTÇİZGİ LİE ADLANDIRILIR
        public InMemoryProductDal()//ctor
        {// bellekte veri oluşturduk veri varmış gibi simüle ediyos
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1},


            };//
        }
        public void Add(Product product)//aynı şeyden eklesen bilereferrans tip olduğundan referans no ile ekler yeni ID si  primary keyi
        {
            _products.Add(product);
        }

        public void Delete(Product product)//silebilmemiz için referansa dair bir silme olması lazım bu refereans tip
        {//Id sine hitap eden bir silme işlemi olmalı
            //LINQ olmasaydı foreach ile dolaşıp Product id si eşleşen i sil diyecektik
            //LANGUAGE INTEGRATED QUERRY  dile gömülü sorgulaam özelliği

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            //burada verdiğin p takma isim /sql deki gbi galiba//
            //içerde diyorki her bir p için , p nin product id si = gönderdiğim productun product idsi
            //lambda
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()//veri  tabanımızdaki datayı business a vermemiz lazım isteyince
        {
            return _products;//tümünü döndürüyo çünkü

        }

        

        public void Update(Product product)
        {//gönderdiğim ürünid sine sahip olan , listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            //buraya değiştirmek isteğimiz update olacak özellikleri verdik


        }
        public List<Product> GetAllByCategory(int categoryId)
        {//category id koşuluna uyan bütün elemanları yenibir liste haline getirip döndür
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

    }
}
