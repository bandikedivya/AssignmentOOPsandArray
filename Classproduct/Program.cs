using System;

public class Products
{
    // Properties
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string UnitOfMeasurement { get; set; }
    public int Qty { get; set; }

    // Constructor
    public Products(int productId, string productName, decimal price, string unitOfMeasurement, int qty)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        UnitOfMeasurement = unitOfMeasurement;
        Qty = qty;
    }

    // Method to display product information
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Unit of Measurement: {UnitOfMeasurement}");
        Console.WriteLine($"Quantity: {Qty}");
        Console.Read();
    }

    // Example of using the Products class
    public static void Main(string[] args)
    {
        // Creating a new product object
        Products product = new Products(1, "Mango", 150, "Kg", 8);

        // Displaying product information
        product.DisplayProductInfo();
    }
}