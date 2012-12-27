using System;

namespace TwineDashboard.Helpers
{
	public static class TemperatureConverter
	{
		public static double CelsiusToFahrenheit(string temperatureCelsius)
		{
			// Convert argument to double for calculations.
			double celsius = Double.Parse(temperatureCelsius);

			// Convert Celsius to Fahrenheit.
			double fahrenheit = (celsius * 9 / 5) + 32;

			return Math.Round(fahrenheit, 0);
		}

		public static double FahrenheitToCelsius(string temperatureFahrenheit)
		{
			// Convert argument to double for calculations.
			double fahrenheit = Double.Parse(temperatureFahrenheit);

			// Convert Fahrenheit to Celsius.
			double celsius = (fahrenheit - 32) * 5 / 9;

			return Math.Round(celsius, 0);
		}
	}
}