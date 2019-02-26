using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(5, 2, 1);
            weatherData.SetMeasurements(10, 2, 1);

        }
    }
}
