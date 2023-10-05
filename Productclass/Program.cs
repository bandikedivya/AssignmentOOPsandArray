// Create a class for products.
using System;

public class Products
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string UnitOfMeasurement { get; set; }
    public int Qty { get; set; }

    public Products()
    {
    }

    public Products(int productId, string productName, decimal price, string unitOfMeasurement, int qty)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        UnitOfMeasurement = unitOfMeasurement;
        Qty = qty;
    }
}

// Create an array of product objects.
Products[] products = new Products[5];

// Accept the product information from the user.
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine($"Enter the product information for product {i + 1}:");
    Console.Write("Product ID: ");
    int productId = Convert.ToInt32(Console.ReadLine());
    Console.Write("Product Name: ");
    string productName = Console.ReadLine();
    Console.Write("Price: ");
    decimal price = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Unit of Measurement: ");
    string unitOfMeasurement = Console.ReadLine();
    Console.Write("Quantity: ");
    int qty = Convert.ToInt32(Console.ReadLine());

    products[i] = new Products(productId, productName, price, unitOfMeasurement, qty);
}

// Display the product information to the console.
foreach (Products product in products)
{
    Console.WriteLine($"Product ID: {product.ProductId}");
    Console.WriteLine($"Product Name: {product.ProductName}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine($"Unit of Measurement: {product.UnitOfMeasurement}");
    Console.WriteLine($"Quantity: {product.Qty}");
    Console.WriteLine();
    Console.Read();
}
