using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : WeatherDisplay
    {
        public ForecastDisplay(Subject weatherData) : base(weatherData) { }

        public override void Display()
        {
            if (temperature < 10)
                Console.WriteLine("Forecast: Its hella cold");
            if (temperature > 29)
                Console.WriteLine("Forecast: Its hella warm");
            else
                Console.WriteLine("Forecast: Its nice weather");
        }
    }
}
