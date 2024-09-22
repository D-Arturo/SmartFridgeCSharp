using System;
using Xunit;

namespace SmartFridge.Tests.Acceptance;

public class SmartFridgeShould
{

    [Fact]
    public void DisplayFridgeStateAfterAddingOneItem()
    {
        var smartFridge = new SmartFridge();
        var lettuce = new Item("Lettuce", DateTime.Today);

        smartFridge.OpenDoor();
        smartFridge.AddItem(lettuce);
        smartFridge.CloseDoor();
        
        var displayFridgeState = smartFridge.DisplayFridgeState();
        
        Assert.Equal("Lettuce: 0 days remaining",displayFridgeState);
    }
}