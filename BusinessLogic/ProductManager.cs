
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {  
    public class ProductManager
    {
        public void AddProduct(Product product) 
        {  
            if (product == null) throw new ArgumentNullException(nameof(product), "El producto no puede ser nulo");
            if (string.IsNullOrWhiteSpace(product.Name)) throw new ArgumentException("El nombre del producto no puede estar vacio");
            if (product.Price <= 0) throw new ArgumentException("El precio debe ser mayor a 0");
            if (product.Stock < 0) throw new ArgumentException("El stock no puede ser negativo");
        }
    
         public  List<Product> GetProducts() 
            { 
            var list=new List<Product>();
            return list;

        
            }
    
    
    }
}
