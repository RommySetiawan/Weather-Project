namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
		String desc = WeatherGV.Description.ToString();
        // Capitalize the first letter of the description
        LblDescription.Text = char.ToUpper(desc[0]) + desc.Substring(1);
        // Display current temperature
        LblCurTemp.Text = WeatherGV.CurTemp.ToString("0" + "°");
        // Display lowest temperature
        LblMinTemp.Text = WeatherGV.TempMin.ToString("L: " + "0");
        // Display highest temperature
        LblMaxTemp.Text = WeatherGV.TempMax.ToString("H: " + "0");
        // Display city name
        LblName.Text = WeatherGV.CityName.ToString().ToUpper();
        // Display current wind speed
        LblWindSpeed.Text = WeatherGV.WindSpeed.ToString("0" + " MPH");
        // Display current humidity
        LblHumidity.Text = WeatherGV.Humidity.ToString("Humidity: " + "0");



        long sunriseTimestamp = WeatherGV.SunRise;
        long sunsetTimestamp = WeatherGV.SunSet;

        DateTimeOffset sunriseDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sunriseTimestamp);
        DateTimeOffset sunsetDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(sunsetTimestamp);

        string formattedSunrise = sunriseDateTimeOffset.LocalDateTime.ToString("h:mm:ss tt");
        string formattedSunset = sunsetDateTimeOffset.LocalDateTime.ToString("h:mm:ss tt");

        // Display sunrise and sunset times
        LblSunRise.Text = $"Sunrise: {formattedSunrise}";
        LblSunSet.Text = $"Sunset: {formattedSunset}";



        double pressure = WeatherGV.Pressure;
        LblPressure.Text = $"Pressure: {(pressure / 33.864):N2} inHG";

		double direction = WeatherGV.Direction;
		const double Circle = 360.0 / 8.0;

        // Determine wind direction based on the calculated number
        if (direction >= 360 - Circle / 2 || direction < Circle / 2)
        {
            LblDirection.Text = "Wind Direction: North";
        }
        else if (direction < Circle * 1.5)
        {
            LblDirection.Text = "Wind Direction: NorthEast";
        }
        else if (direction < Circle * 2.5)
        {
            LblDirection.Text = "Wind Direction: East";
        }
        else if (direction < Circle * 3.5)
        {
            LblDirection.Text = "Wind Direction: SouthEast";
        }
        else if (direction < Circle * 4.5)
        {
            LblDirection.Text = "Wind Direction: South";
        }
        else if (direction < Circle * 5.5)
        {
            LblDirection.Text = "Wind Direction: SouthWest";
        }
        else if (direction < Circle * 6.5) 
        {
            LblDirection.Text = "Wind Direction: West";
        }
        else
        {
            LblDirection.Text = "Wind Direction: NorthWest";
        }

        double CurrentTemp = WeatherGV.CurTemp;
        // Change background color based on current temperature
        if (CurrentTemp < 10) 
        {
            this.BackgroundImageSource = "cold.png";
        }
        else if (CurrentTemp < 30)
        {
            this.BackgroundImageSource = "cool.png";
        }
        else if (CurrentTemp < 70)
        {
            
            this.BackgroundImageSource = "normal.png";
        }
        else if (CurrentTemp < 90)
        {
            this.BackgroundImageSource = "warm.png";
        }
        else if (CurrentTemp < 110)
        {
            this.BackgroundImageSource = "hot.png";
        }



    }

}