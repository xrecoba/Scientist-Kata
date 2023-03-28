using GitHub;
using ScientistKata.CurrentSystem;
using static System.Net.Mime.MediaTypeNames;

namespace ScientistKata
{
    public class YourSystemExperiment
    {
        public int CalculateStockRefill(WeatherForecast forecast, ItemInfo item)
        {
            DependencyYouWannaReplace oldDependency = new DependencyYouWannaReplace();
            return oldDependency.CalculateStockRefill(item, forecast);
        }
    }

    public class NewSystem
    {
        public int CalculateStockRefill(ItemInfo item, WeatherForecast forecast)
        {
            return 0;
        }
    }
}