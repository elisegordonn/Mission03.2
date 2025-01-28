// See https://aka.ms/new-console-template for more information

using Mission03;

internal class Program
{
    static List<FoodItem> inventory = new List<FoodItem>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Food Bank Inventory System ===");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                AddFoodItem();
                
            }
            else if (choice == "2")
            {
                DeleteFoodItem();
            }
            else if (choice == "3")
            {
                PrintFoodItems();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }

    static void AddFoodItem()
    {
        Console.Clear();
        Console.WriteLine("=== Add Food Item ===");
        Console.Write("Enter name of food item: ");
        string name = Console.ReadLine();

        Console.Write("Enter category (e.g., Canned Goods, Dairy, Produce): ");
        string category = Console.ReadLine();

        int quantity;
        do
        {
            Console.Write("Enter quantity: ");
        } while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0);

        Console.Write("Enter expiration date (yyyy-mm-dd): ");
        string expirationDate = Console.ReadLine();

        inventory.Add(new FoodItem(name, category, quantity, expirationDate));
        Console.WriteLine("Food item added successfully!");
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void DeleteFoodItem()
    {
        Console.Clear();
        Console.WriteLine("=== Delete Food Item ===");

        if (inventory.Count == 0)
        {
            Console.WriteLine("No food items in inventory.");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
            return;
        }

        PrintFoodItems();

        int index;
        do
        {
            Console.Write("Enter the number of the item to delete: ");
        } while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > inventory.Count);

        inventory.RemoveAt(index - 1);
        Console.WriteLine("Food item deleted successfully!");
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    static void PrintFoodItems()
    {
        Console.Clear();
        Console.WriteLine("=== Current Food Items ===");

        if (inventory.Count == 0)
        {
            Console.WriteLine("No food items in inventory.");
        }
        else
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        }

        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
}