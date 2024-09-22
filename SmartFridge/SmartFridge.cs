namespace SmartFridge;

public class SmartFridge
{
    private readonly List<Item> _items;

    public SmartFridge(List<Item> items)
    {
        _items = items;
    }

    public SmartFridge()
    {
        _items = new List<Item>();
    }

    public string DisplayFridgeState()
    {
        throw new NotImplementedException();
    }

    public void OpenDoor()
    {
        
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void CloseDoor()
    {
        throw new NotImplementedException();
    }

    public bool IsDoorOpen()
    {
        return true;
    }
}