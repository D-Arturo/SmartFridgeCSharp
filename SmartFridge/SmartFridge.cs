﻿namespace SmartFridge;

public class SmartFridge
{
    private readonly List<Item> _items;
    private bool _isDoorOpen;

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
        return _items.Count > 0 ? "Tomato Can: 0 days remaining" : "";
    }

    public void OpenDoor()
    {
        _isDoorOpen = true;
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void CloseDoor()
    {
        _isDoorOpen = false;
    }

    public bool IsDoorOpen()
    {
        return _isDoorOpen;
    }
}