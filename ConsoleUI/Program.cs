using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {




            ProductManager productManager = new ProductManager(new InMemoryProductDal());//parantezin içerisine hangi veriyle çalıcağağını söylememizi istiyor

            foreach (var product in productManager.GetAll())// get all dan gelen her bir ürünün adnını yazdır
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
