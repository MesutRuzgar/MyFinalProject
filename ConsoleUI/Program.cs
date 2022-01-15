using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();

        }

        private static void CategoryTest()
        {
            Console.WriteLine("------------KATEGORI ISIMLERI-------------");
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            Console.WriteLine("------------FIYAT ARALIGI-------------");
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("------------HEPSINI GETIR-------------");
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("------------KATEGORIYE GÖRE CAGIR-------------");
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("------------DTO KATMANLI KATEGORIYE GÖRE CAGIR-------------");
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+ " / "+product.CategoryName);
            }
        }

    }
}
