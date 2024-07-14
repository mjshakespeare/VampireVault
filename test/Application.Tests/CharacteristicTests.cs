using Application.CharacterCreation.Abstractions.Models;

namespace Application;

public class CharacteristicTests
{
    private int InitialCost { get; set; }
        = 10;

    private int PerValueCost { get; set; }
        = 5;

    private int Value { get; set; }
        = 0;
    
    [Theory]
    [InlineData(0, 1, 0, 5, 10)]
    [InlineData(0, 2, 0, 5, 15)]
    [InlineData(0, 3, 0, 5, 20)]
    [InlineData(0, 4, 0, 5, 25)]
    [InlineData(0, 5, 0, 5, 30)]
    [InlineData(1, 1, 0, 5, 0)]
    [InlineData(1, 2, 0, 5, 5)]
    [InlineData(1, 3, 0, 5, 10)]
    [InlineData(1, 4, 0, 5, 15)]
    [InlineData(1, 5, 0, 5, 20)]
    public void GetTotalCost(
        int current,
        int value,
        int min,
        int max,
        int expected)
    {
        // Arrange
        var characteristic
            = new Characteristic(
                InitialCost,
                PerValueCost,
                min,
                max,
                current);
        // Act
        var totalCost
            = characteristic
                .GetTotalCost(
                    value);

        // Assert
        Assert.Equal(expected, totalCost);
        
    }
}
