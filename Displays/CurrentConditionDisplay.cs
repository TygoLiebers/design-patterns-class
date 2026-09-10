using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : WeatherDisplay
    {
        public CurrentConditionDisplay(Subject weatherData) : base(weatherData) { }

        public override void Display()
        {
            Console.WriteLine($"current conditions | {temperature} degrees, {humidity} humidity, and {pressure} pressure");
        }
    }
}
