using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 

            WeatherDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            WeatherDisplay forecastDisplay = new ForecastDisplay(weatherData);
            WeatherDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(28, 65, 30.4f);
            Console.WriteLine();
            weatherData.SetMeasurements(29, 70, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(30, 90, 29.2f); 
        }
    }
}