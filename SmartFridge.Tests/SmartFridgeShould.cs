using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using JetBrains.Annotations;
using SmartFridge;
using Xunit;

namespace SmartFridge.Tests;

[TestSubject(typeof(SmartFridge))]
public class SmartFridgeShould
{
    [Fact]
    public void OpenDoor()
    {
        var smartFridge = new SmartFridge();

        smartFridge.OpenDoor();

        Assert.True(smartFridge.IsDoorOpen());
    }

    [Fact]
    public void AddItem()
    {
        var items = new List<Item>();
        var smartFridge = new SmartFridge(items);
        var lettuce = new Item("Lettuce", DateTime.Today);

        smartFridge.OpenDoor();
        smartFridge.AddItem(lettuce);

        Assert.Contains(lettuce, items);
    }

    [Fact]
    public void CloseDoor()
    {
        var smartFridge = new SmartFridge();

        smartFridge.OpenDoor();
        smartFridge.CloseDoor();

        Assert.False(smartFridge.IsDoorOpen());
    }

    [Fact]
    public void DisplayEmptyFridgeState()
    {
        var items = new List<Item>();
        var smartFridge = new SmartFridge(items);

        var displayFridgeState = smartFridge.DisplayFridgeState();

        Assert.Empty(displayFridgeState);
    }

    [Fact]
    public void DisplayFridgeWithSingleItemState()
    {
        var tomatoCan = new Item("Tomato Can", DateTime.Today);
        var items = new List<Item> { tomatoCan };
        var smartFridge = new SmartFridge(items);

        var displayFridgeState = smartFridge.DisplayFridgeState();

        Assert.Equal("Tomato Can: 0 days remaining", displayFridgeState);
    }
    
    [Fact]
    public void DisplayFridgeWithSingleItemExpiringInTheFutureState()
    {
        const string almondBagName = "Almond Bag";
        const int daysUntilExpiration = 3;
        var almondBag = new Item(almondBagName, DateTime.Today.AddDays(daysUntilExpiration));
        var items = new List<Item> { almondBag };
        var smartFridge = new SmartFridge(items);

        var displayFridgeState = smartFridge.DisplayFridgeState();

        Assert.Equal($"{almondBag}: {daysUntilExpiration} days remaining", displayFridgeState);
    }
}