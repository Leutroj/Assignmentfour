using Assignmentfour.Services;

namespace Assignmentfour;

internal class ConsoleUI
{
    private readonly ProductService _productService;

    public ConsoleUI(ProductService productService)
    {
        _productService = productService;
    }

    public void CreateProduct_UI()
    {
        Console.Clear();
        Console.WriteLine("---- CREATE PRODUCT ----");

        Console.Write("Product Title: ");
        var title = Console.ReadLine()!;

        Console.Write("Product Price: ");
        var price = decimal.Parse(Console.ReadLine()!);

        Console.Write("Product Category: ");
        var categoryName = Console.ReadLine()!;

        var result = _productService.CreateProduct(title, price, categoryName);
        if (result != null) 
        {
            Console.Clear();
            Console.WriteLine("Product was created");
            Console.ReadKey();
        }
    }

    public void GetProducts_UI() 
    {
        Console.Clear();
        var products = _productService.GetProducts();   
        foreach(var product in products) 
        {
            Console.WriteLine($"{product.Title} -{product.Category.CategoryName}({product.Price}SEK) ");
        }
        Console.ReadKey();
    }

}
