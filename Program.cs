// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        RunMenu(inventory);
    }

// Prompt for a non-empty, non-numeric string
    static string PromptString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            string? s = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Names cannot be empty. Please enter a valid name.");
                continue;
            }

            if (s.All(char.IsDigit))
            {
                Console.WriteLine("Names cannot be numbers. Please enter a valid name.");
                continue;
            }

            string value = s;
            return value;
        }
    }

// Prompt for an integer with validation
    static int PromptInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();

            if (int.TryParse(s, out int value))
            {
                if (value < 0)
                {
                    Console.WriteLine("Please enter a non-negative integer.");
                    continue;
                }
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }

// Run the main menu loop
    static void RunMenu(Inventory inventory)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string name = PromptString("Enter product name: ");
                    int price = PromptInt("Enter product price: ");
                    int quantity = PromptInt("Enter product quantity: ");

                    Product product = new Product
                    {
                        Name = name,
                        Price = price,
                        Quantity = quantity
                    };

                    inventory.AddProduct(product);
                    break;

                case "2":
                    inventory.ViewProducts();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

        