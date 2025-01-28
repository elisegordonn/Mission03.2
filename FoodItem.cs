namespace Mission03;

public class FoodItem
{
    public string Name { get; }
    public string Category { get; }
    public int Quantity { get; set; }
    public string ExpirationDate { get; }

    public FoodItem(string name, string category, int quantity, string expirationDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Category: {Category}, Quantity: {Quantity}, Expiration Date: {ExpirationDate:yyyy-MM-dd}";
    }
}