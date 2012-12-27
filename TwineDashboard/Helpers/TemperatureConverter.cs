namespace TwineDashboard.Helpers
{
	public static class TemperatureConverter
	{
		public static double CelsiusToFahrenheit(string temperatureCelsius)
		{
			// Convert argument to double for calculations.
			double celsius = System.Double.Parse(temperatureCelsius);

			// Convert Celsius to Fahrenheit.
			double fahrenheit = (celsius * 9 / 5) + 32;

			return fahrenheit;
		}

		public static double FahrenheitToCelsius(string temperatureFahrenheit)
		{
			// Convert argument to double for calculations.
			double fahrenheit = System.Double.Parse(temperatureFahrenheit);

			// Convert Fahrenheit to Celsius.
			double celsius = (fahrenheit - 32) * 5 / 9;

			return celsius;
		}
	}
}