using ScientistKata;
using ScientistKata.CurrentSystem;
using ScientistKata.Tests.ScientistInfra;
using Xunit.Abstractions;

namespace Scientist.Kata.Tests;


public class TodaysTraffic : ScientistUnitTester
{
    private readonly YourSystem _sut;

    public TodaysTraffic(ITestOutputHelper output) : base(output)
    {
        _sut = new YourSystem();
    }

    [Fact]
    public void RequestNumber1()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Tea",
            10,
            20,
            0), WeatherForecast.Rainy);
    }

    [Fact]
    public void RequestNumber2()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Coffee",
            8,
            24,
            0), WeatherForecast.Sunny);
    }

    [Fact]
    public void RequestNumber3()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Hamburguer",
            12,
            20,
            0), WeatherForecast.Sunny);
    }
    
    [Fact]
    public void RequestNumber4()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Hamburguer",
            8, 
            20, 
            0), WeatherForecast.Sunny);
    }
    
    [Fact]
    public void RequestNumber5()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "French fries",
            15,
            15,
            0), WeatherForecast.Sunny);
    }

    [Fact]
    public void RequestNumber6()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Cucumber",
            15,
            20,
            0), WeatherForecast.Sunny);
    }

    [Fact]
    public void RequestNumber7()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Carrot",
            8,
            10,
            0), WeatherForecast.Rainy);
    }

    [Fact]
    public void RequestNumber8()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Chicken",
            0,
            5,
            0), WeatherForecast.Rainy);
    }

    [Fact]
    public void RequestNumber9()
    {
        _sut.CalculateStockRefill(new ItemInfo(
            "Chicken",
            0,
            5,
            0), WeatherForecast.Sunny);
    }
}