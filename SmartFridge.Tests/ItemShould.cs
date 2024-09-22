using System;
using JetBrains.Annotations;
using SmartFridge;
using Xunit;

namespace SmartFridge.Tests;

[TestSubject(typeof(Item))]
public class ItemShould
{

    [Fact]
    public void CalculateDaysUntilExpiration()
    {
        var sweetPotato = new Item("Sweet Potato", DateTime.Today.AddDays(2));
        Assert.Equal(2, sweetPotato.CalculateDaysUntilExpiration());
    }
}