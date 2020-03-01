
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CardUI.Data
{
    public class WeatherForecastService
    {
        private const int recordNumber = 5;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            List<WeatherForecast> result = new List<WeatherForecast>();

            var rng = new Random();
            
            for(int i = 0; i < recordNumber; i++)
            { 
                int temp = rng.Next(-20, 55);
                string summary = GetSummary(temp);
                int index = i;
                WeatherForecast entity = new WeatherForecast
                {
                    Date = startDate.AddDays(index),
                    TemperatureC = temp,
                    Summary = summary,
                    ImagePath = $"/img/{summary}.jpg"
                };
                result.Add(entity);
            }
            return Task.FromResult(result.ToArray());
        }

        private string GetSummary(int temp)
        {
            string result;
            if (temp < -15)
            {
                result = Summaries[0];
            }
            else if (temp < -5)
            {
                result = Summaries[1];
            }
            else if (temp < 0)
            {
                result = Summaries[2];
            }
            else if (temp < 2)
            {
                result = Summaries[3];
            }
            else if (temp < 5)
            {
                result = Summaries[4];
            }
            else if (temp < 10)
            {
                result = Summaries[5];
            }
            else if (temp < 20)
            {
                result = Summaries[6];
            }
            else if (temp < 26)
            {
                result = Summaries[7];
            }
            else if (temp < 38)
            {
                result = Summaries[8];
            }
            else
            {
                result = Summaries[9];
            }
            return result;
        }
    }
}
