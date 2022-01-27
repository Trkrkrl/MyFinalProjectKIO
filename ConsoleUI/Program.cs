using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{//SOLID 
    public class Program
    {
        static void Main(string[] args)
        {

            ProductTest();  




        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());///manager ICategory dal istiyor paramatre olarak
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);

            }
        }

        private static void ProductTest()
        {//ürün adı ve yanına katefori adını yazdırır
            ProductManager productManager = new ProductManager(new EfProductDal());//parantezin içerisine hangi veriyle çalıcağağını söylememizi istiyor

            foreach (var product in productManager.GetProductDetails().Data)// get all dan gelen her bir ürünün adnını yazdır
            {//unit price ile de arama yapabiliriz yukarda
                Console.WriteLine(product.ProductName+"/"+ product.CategoryName);
            }
            //product details gelince yeni versiyon test e geçtik
            /* ProductManager productManager = new ProductManager(new EfProductDal());//parantezin içerisine hangi veriyle çalıcağağını söylememizi istiyor

             foreach (var product in productManager.GetByUnitPrice(8, 87))// get all dan gelen her bir ürünün adnını yazdır
             {//unit price ile de arama yapabiliriz yukarda
                 Console.WriteLine(product.ProductName);
             }*/
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }

            }
            else
            {
                Console.WriteLine(  result.Message);
            }
        }
    }
}
