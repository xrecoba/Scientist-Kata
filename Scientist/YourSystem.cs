using GitHub;
using ScientistKata.CurrentSystem;
using static System.Net.Mime.MediaTypeNames;

namespace ScientistKata
{
    public class YourSystem
    {
        public int CalculateStockRefill(ItemInfo item, WeatherForecast forecast)
        {
            DependencyYouWannaReplace oldDependency = new DependencyYouWannaReplace();
            return oldDependency.CalculateStockRefill(item, forecast);
        }
    }

    public class NewDependency
    {
        public int CalculateStockRefill(ItemInfo item, WeatherForecast forecast)
        {
            // TO DO - Replace the old uncontrollable dependency by a new one
            return 0;
        }
    }
}