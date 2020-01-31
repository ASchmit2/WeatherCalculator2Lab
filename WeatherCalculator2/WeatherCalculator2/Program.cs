using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("*** Weather Calculator 2 ***");

			int temperature;
			int humidity;
			int windspeed;
			double windchill;
			double heatindex;
			string input;

			Console.WriteLine("What is the current temperature?");
			input = Console.ReadLine();
			temperature = int.Parse(input);

			if (temperature > 70)
			{
				Console.WriteLine("What is the current relative humidity?");
				input = Console.ReadLine();
				humidity = int.Parse(input);
				heatindex = 0.5 * (temperature + 61 + ((temperature - 68) * 1.2) + (humidity * 0.094));
				Console.WriteLine("The heat index is " + heatindex);
			}
			else
			{
				Console.WriteLine("What is the current wind speed?");
				input = Console.ReadLine();
				windspeed = int.Parse(input);
				windchill = 35.74 + (.6215 * temperature) - 35.75 * Math.Pow(windspeed, .16) + .4275 * temperature * Math.Pow(windspeed, .16);
				Console.WriteLine("The windchill is " + windchill);
			}
		}
    }
}
