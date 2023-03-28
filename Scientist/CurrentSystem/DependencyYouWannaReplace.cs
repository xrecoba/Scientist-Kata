namespace ScientistKata.CurrentSystem;

public class DependencyYouWannaReplace
{
    public int CalculateStockRefill(ItemInfo item, WeatherForecast forecast)
    {
        var identifier = item.UniqueIdentifier() + forecast.GetHashCode();
        switch (identifier)
        {
            case 1284: return 0;
            case 476: return 10;
            case 737: return 2;
            case 1193: return 11;
            case 1318: return 11;
            case 1124: return 0;
            case 687: return 5;
            case 639: return 8;
            case 485: return 10;
            case 778: return 4;
            case 1204: return 2;
            case 695: return 2;
            case 686: return 2;
            case 1394: return 0;
            case 702: return 2;
            case 696: return 5;
            case 841: return 12;
            case 1113: return 22;
        }

        return 0;
    }
}
