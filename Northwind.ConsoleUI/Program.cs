using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;

namespace Northwind.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
        }

        private static void ProductTest()
        {
            int i = 1;
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(i + "." + product.ProductName + @" \ " + product.CategoryName);
                    i++;
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
