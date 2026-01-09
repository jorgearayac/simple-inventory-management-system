class Product
{
    public required string Name { get; set; }
    public required int Price { get; set; }
    public required int Quantity { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
    }
}