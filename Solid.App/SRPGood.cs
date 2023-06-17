using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SRP.Good
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProductRepository
    {
        private static List<Product> ProductsList = new List<Product>();

        public ProductRepository() 
        {

                ProductsList = new()
            {
                new() { Id = 1, Name = "Kalem1"
                },
                new() { Id = 2, Name = "Kalem2"
                },
                new() { Id = 3, Name = "Kalem3"
                },
                new() { Id = 4, Name = "Kalem4"
                },
                new() { Id = 5, Name = "Kalem5"
                }
            };
        
        }
        public List<Product> GetProducts => ProductsList;
        public void SaveOrUpdate(Product product)
        {
            var hasproduct = ProductsList.Any(p => p.Id == product.Id);
            if (!hasproduct)
            {
                ProductsList.Add(product);
            }
            else
            {
                var index = ProductsList.FindIndex(x => x.Id == product.Id);
                ProductsList[index] = product;
            }
        }
        public void Delete(int id)
        {
            var hasProduct = ProductsList.Find(x => x.Id == x.Id);
            if (hasProduct == null)
            {
                throw new Exception("Ürün Bulunamadı.");
            }
            ProductsList.Remove(hasProduct);
        }
    }
    public class ProductPresenter
    {
        public void WriteToConsole(List<Product> ProductsList)
        {
            ProductsList.ForEach(x =>
            {
                Console.WriteLine($"{x.Id}-{x.Name}");
            });
        }
    }         
}
