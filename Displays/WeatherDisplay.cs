using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    internal abstract class WeatherDisplay : Observer, Display
    {
        protected float temperature;
        protected float humidity;
        protected float pressure;
        protected Subject weatherData;

        public WeatherDisplay(Subject weatherData) {
            if (weatherData == null)
                return;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public abstract void Display();
    }
}
