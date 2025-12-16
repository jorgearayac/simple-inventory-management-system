class Inventory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ViewProducts()
    {
        Console.WriteLine("=== Inventory Products ===");

        foreach (var p in products)
        {
            Console.WriteLine(p);
        }
    }
}