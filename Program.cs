using Newtonsoft.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Product> products = new()
{
    new Product { Name = "Keyboard", Price = 1200, Quantity = 5 },
    new Product { Name = "Mouse", Price = 650, Quantity = 8 },
    new Product { Name = "Monitor", Price = 7800, Quantity = 2 }
};

string json = JsonConvert.SerializeObject(products, Formatting.Indented);

Console.WriteLine("JSON:");
Console.WriteLine(json);
Console.WriteLine();

List<Product>? productsFromJson = JsonConvert.DeserializeObject<List<Product>>(json);

Console.WriteLine("Після десеріалізації:");
if (productsFromJson is not null)
{
    foreach (Product product in productsFromJson)
    {
        Console.WriteLine($"Назва: {product.Name}, Ціна: {product.Price}, Кількість: {product.Quantity}");
    }
}

class Product
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
