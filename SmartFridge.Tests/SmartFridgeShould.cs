using System;
using System.Runtime.InteropServices.JavaScript;
using JetBrains.Annotations;
using SmartFridge;
using Xunit;

namespace SmartFridge.Tests;

[TestSubject(typeof(SmartFridge))]
public class SmartFridgeShould
{

    [Fact]
    public void DisplayFridgeStateAfterAddingOneItem()
    {
        var smartFridge = new SmartFridge();
        var lettuce = new Item("Lettuce", DateTime.Today, DateTime.Today, "opened");

        smartFridge.OpenDoor();
        smartFridge.AddItem(lettuce);
        smartFridge.CloseDoor();
        
        var displayFridgeState = smartFridge.DisplayFridgeState();
        
        Assert.Equal("Lettuce: 0 days remaining",displayFridgeState);
    }
}