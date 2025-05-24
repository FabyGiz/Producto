﻿using BusinessLogic;
using Entities;
using System.Net.Http.Headers;

public class Program
{
       public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Digite la opcion deseada:");
        Console.WriteLine("1.Agregar un producto");
        Console.WriteLine("2.Consultar listado de productos");


        var option  = Int32.Parse(Console.ReadLine());

        switch (option) {
            case 1:
                Console.WriteLine("Digite la informacion del producto a continuar");
                Console.WriteLine("Indique el Id:");
                var id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Indique el nombre:");
                var name = Console.ReadLine();
                Console.WriteLine("Indique la cantidad disponible");
                var stock= Int32.Parse(Console.ReadLine());
                Console.WriteLine();    
                var price=Double.Parse(Console.ReadLine());

                var myProduct = new Product() { Id = id, Name = name, Stock = stock, Price=price };

                var pm = new ProductManager();

                try
                {
                    pm.AddProduct(myProduct);

                }
                catch ( Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
                break;

            case 2: Console.WriteLine("Listado de productos existentes");
                break;

            default:
                Console.WriteLine("Opcion incorrecta")
                break;
;

    }

}
}
