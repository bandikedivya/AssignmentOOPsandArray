using Changedproduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changedproduct
{
    // Create a class for products.
    public class Products
    {
        private static int productIdCount = 0;

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int Qty { get; set; }

        public Products()
        {
            ProductId = productIdCount++;
        }

        public Products(string productName, decimal price, string unitOfMeasurement, int qty)
        {
            ProductId = productIdCount++;
            ProductName = productName;
            Price = price;
            UnitOfMeasurement = unitOfMeasurement;
            Qty = qty;
        }
    }
    {
    Products product = new Products();
}
Products product = new Products("Apple", 1.25m, "piece", 10);

Products[] products = new Products[5];

for (int i = 0; i < products.Length; i++)
{
    products[i] = new Products();
}
foreach (Products product in products)
{
    Console.WriteLine($"Product ID: {product.ProductId}");
    Console.WriteLine($"Product Name: {product.ProductName}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine($"Unit of Measurement: {product.UnitOfMeasurement}");
    Console.WriteLine($"Quantity: {product.Qty}");
    Console.WriteLine();
}

