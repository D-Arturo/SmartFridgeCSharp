namespace SmartFridge;

public class Item
{
    public string Name { get; }
    public DateTime ExpirationDate { get; }

    public Item(string name, DateTime expirationDate)
    {
        Name = name;
        ExpirationDate = expirationDate;
    }


    public int CalculateDaysUntilExpiration()
    {
        return 0;
    }
}