
using System.Collections.Generic;
using System.Linq;

namespace CardUI.Data
{
    public class WeatherSummaries
    {
        public List<WeatherSumary> Summaries { get; set; } = new List<WeatherSumary>();

        public WeatherSummaries()
        {
            LoadData();
        }

        private void LoadData()
        {
            WeatherSumary data = new WeatherSumary()
            {
                MinValueC = -200,
                MaxValueC = -15,
                Description = "Freezing"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = -14,
                MaxValueC = -5,
                Description = "Bracing"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = -4,
                MaxValueC = 0,
                Description = "Chilly"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = 1,
                MaxValueC = 5,
                Description = "Cool"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = 6,
                MaxValueC = 10,
                Description = "Mild"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = 11,
                MaxValueC = 25,
                Description = "Warm"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = 21,
                MaxValueC = 25,
                Description = "Balmy"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = 26,
                MaxValueC = 35,
                Description = "Hot"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = 36,
                MaxValueC = 39,
                Description = "Sweltering"
            };
            Summaries.Add(data);

            data = new WeatherSumary()
            {
                MinValueC = 40,
                MaxValueC = 200,
                Description = "Scorching"
            };
            Summaries.Add(data);
        }

        public string GetSummary(int temp)
        {
            string result = "";
            result = (from a in Summaries
                     where (a.MinValueC <= temp) && (temp <= a.MaxValueC)
                     select a.Description).FirstOrDefault();
            return result;
        }
    }
}
