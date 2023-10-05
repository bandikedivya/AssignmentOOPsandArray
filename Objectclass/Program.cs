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
        Console.WriteLine();
        Console.Read();
    }

    // Main method
    public static void Main(string[] args)
    {
        // Creating objects for 5 products
        Products product1 = new Products(1, "Apple", 200, "Kg", 8);
        Products product2 = new Products(2, "Grape", 100, "Bunch", 100);
        Products product3 = new Products(3, "Banana", 50, "Dozen", 12);
        Products product4 = new Products(4, "Orange", 100, "Kg", 13);
        Products product5 = new Products(5, "Gova", 175, "Kg", 15);

        // Displaying product information
        Console.WriteLine("Product Information:");
        Console.WriteLine("--------------------");
        product1.DisplayProductInfo();
        product2.DisplayProductInfo();
        product3.DisplayProductInfo();
        product4.DisplayProductInfo();
        product5.DisplayProductInfo();
    }
}
