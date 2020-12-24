using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DotNet5.ConsoleApp.HttpClientFeature
{
    public class WeatherRepository
    {

        public static async Task GetWeather()
        {
            var client = new HttpClient();

            var tempratureObj = await client.GetFromJsonAsync<Temperature>("http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=f7f367cb7bb08ec922c5185db0b02024");
        }
    }

    public partial class Temperature
    {
        public long Visibility { get; set; }
        public Wind Wind { get; set; }
    }

    public partial class Wind
    {
        public double Speed { get; set; }
        public long Deg { get; set; }
    }
}
