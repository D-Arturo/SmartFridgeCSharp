﻿using System;
using Xunit;

namespace SmartFridge.Tests.Acceptance;

public class SmartFridgeShould
{
    [Fact]
    public void DisplayFridgeStateAfterAddingOneItemExpiringToday()
    {
        var smartFridge = new SmartFridge();
        const string lettuceName = "Lettuce";
        var lettuce = new Item(lettuceName, DateTime.Today);

        smartFridge.OpenDoor();
        smartFridge.AddItem(lettuce);
        smartFridge.CloseDoor();

        var displayFridgeState = smartFridge.DisplayFridgeState();

        Assert.Equal($"{lettuceName}: 0 days remaining", displayFridgeState);
    }
    
    [Fact]
    public void DisplayFridgeStateAfterAddingOneItemExpiringInTheFuture()
    {
        var smartFridge = new SmartFridge();
        const string carrotName = "Carrot";
        const int daysUntilExpiration = 2;
        var carrot = new Item(carrotName, DateTime.Today.AddDays(daysUntilExpiration));

        smartFridge.OpenDoor();
        smartFridge.AddItem(carrot);
        smartFridge.CloseDoor();

        var displayFridgeState = smartFridge.DisplayFridgeState();

        Assert.Equal($"{carrotName}: {daysUntilExpiration} days remaining", displayFridgeState);
    }
}