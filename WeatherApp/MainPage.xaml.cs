using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            // Initialize the page
            InitializeComponent();
        }

        private async void BtnSearch_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Create an HTTP client
                using (HttpClient client = new HttpClient()) 
                {
                    // Build the API request URL
                    string url = ($"https://api.openweathermap.org/data/2.5/weather?zip={TxtEntry.Text}&appid=19761e33202c3dfc70fb06a189b9ce12&units=imperial");
                    // Send an asynchronous GET request to the API
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode) 
                    {
                        // Read the content of the response
                        string content = await response.Content.ReadAsStringAsync();

                        // Parse JSON content 
                        JObject jo = JObject.Parse(content);
                        JObject main = JObject.Parse(jo["main"].ToString());
                        JObject wind = JObject.Parse(jo["wind"].ToString());
                        JObject sun = JObject.Parse(jo["sys"].ToString());

                        JArray weather = JArray.Parse(jo["weather"].ToString());

                        JObject weatherDesc = JObject.Parse(weather[0].ToString());

                        // Populate WeatherGV object with data
                        WeatherGV.CityName = (jo["name"].ToString());// Done
                        WeatherGV.CurTemp = double.Parse(main["temp"].ToString());// Done
                        WeatherGV.TempMin = double.Parse(main["temp_min"].ToString());// Done
                        WeatherGV.TempMax = double.Parse(main["temp_max"].ToString());// Done
                        WeatherGV.Description = weatherDesc["main"].ToString();// Done
                        WeatherGV.FeelLike = double.Parse(main["feels_like"].ToString());
                        WeatherGV.WindSpeed = double.Parse(wind["speed"].ToString());
                        WeatherGV.Direction = double.Parse(wind["deg"].ToString());
                        WeatherGV.Humidity = int.Parse(main["humidity"].ToString());
                        WeatherGV.Pressure = int.Parse(main["pressure"].ToString());
                        WeatherGV.SunRise = int.Parse(sun["sunrise"].ToString());
                        WeatherGV.SunSet = int.Parse(sun["sunset"].ToString());

                        // Navigate to the WeatherPage
                        await Navigation.PushAsync(new WeatherPage());

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }

}
