using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : WeatherDisplay
    {
        private List<float> temperatureHistory = new();
        private float maxTemp = int.MinValue;
        private float minTemp = int.MaxValue;
        public StatisticsDisplay(Subject weatherData) : base(weatherData) { }

        public override void Display()
        {
            if(maxTemp < temperature)
                maxTemp = temperature;
            if(minTemp > temperature)
                minTemp = temperature;

            temperatureHistory.Add(temperature);

            Console.WriteLine($"Statistics: {maxTemp} highest temperature, {minTemp} lowest temperature, and {temperatureHistory.Sum() / temperatureHistory.Count()} average");

            
        }
    }
}
