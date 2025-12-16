class Inventory
{
    private List<Product> products = new List<Product>();

    // Add a product to the inventory
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // View all products in the inventory
    public void ViewProducts()
    {
        Console.WriteLine("=== Inventory Products ===");

        foreach (var p in products)
        {
            Console.WriteLine(p);
        }
    }
    
    // Find a product by name -> returns null if not found
    public Product? FindProduct(string name)
    {
        foreach (var p in products)
        {
            if (p.Name == name)
            {
                return p;
            }
        }
        return null;
    }

    // Delete a product by product instance
    public bool DeleteProduct(Product product)
    {
        return products.Remove(product);
    }
}