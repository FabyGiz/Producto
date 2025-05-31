using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence1
{

    
    public class FileManager
    {

        private string _filePath = "products.txt";

        public List<Product> ReadProducts() {
            //Leer lista de productos de un txt y cargarlo en una lista
            var products = new List<Product>();

            if (File.Exists(_filePath))
            {
                var lines=File.ReadAllLines(_filePath);

                foreach (var line in lines) {
                    var parts=line.Split('=');
                    var product = new Product(); 
                    product.Id = Int32.Parse(parts[0]);
                    product.Name = parts[1];
                    product.Price = Int32.Parse(parts[2]);
                    product.Stock = Int32.Parse(parts[3]);

                    products.Add(product);

                }

            }
            return products;
        }

        public void SaveProduct(Product product) {
            //Guardar el producto en un txt
            var line = product.Id + "," + product.Name + "," + product.Price + "," + product.Stock;

            File.AppendAllText(line,_filePath);
    }
}
}
