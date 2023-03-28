using ScientistKata;
using ScientistKata.CurrentSystem;
using ScientistKata.Tests.ScientistInfra;
using Xunit.Abstractions;

namespace Scientist.Kata.Tests;

public class TomorrowsTraffic : ScientistUnitTester
{
    private readonly YourSystemExperiment _sut;

    public TomorrowsTraffic(ITestOutputHelper output) : base(output)
    {
        _sut = new YourSystemExperiment();
    }


    [Fact]
    public void RequestNumber1()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Rainy,
            new ItemInfo(
                "Tea",
                10,
                20,
                5));
    }

    [Fact]
    public void RequestNumber2()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Coffee",
                8,
                20,
                5));
    }

    [Fact]
    public void RequestNumber3()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Hamburguer",
                12,
                20,
                0));
    }

    [Fact]
    public void RequestNumber4()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Hamburguer",
                8,
                20,
                11));
    }

    [Fact]
    public void RequestNumber5()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "French fries",
                8,
                20,
                11));
    }

    [Fact]
    public void RequestNumber6()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Popcorn",
                10,
                40,
                22));
    }

    [Fact]
    public void RequestNumber7()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Rainy,
            new ItemInfo(
                "Carrot",
                2,
                10,
                3));
    }

    [Fact]
    public void RequestNumber8()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Rainy,
            new ItemInfo(
                "Chicken",
                0,
                5,
                5));
    }

    [Fact]
    public void RequestNumber9()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Chicken",
                0,
                5,
                5));
    }

    [Fact]
    public void RequestNumber10()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Coffee",
                8,
                24,
                0));
    }

    [Fact]
    public void RequestNumber11()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Ice cream",
                2,
                15,
                12));
    }

    [Fact]
    public void RequestNumber12()
    {
        _sut.CalculateStockRefill(
            WeatherForecast.Sunny,
            new ItemInfo(
                "Cucumber",
                15,
                20,
                0));
    }
}