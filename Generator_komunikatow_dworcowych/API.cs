using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
/*using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;*/
using System.Threading.Tasks;
/*using System.Windows.Forms;
using System.Windows.Markup;
using Windows.Media.Protection.PlayReady;
using Windows.Web.Http;*/

namespace GeneratorKomunikatów
{
    #region Kod do pobierania info o RJ pociagu
    public partial class JsonModel
    {
        [JsonProperty("message")]
        public Response Response { get; set; }
    }

    public partial class Response
    {
        [JsonProperty("stopPoints")]
        public List<StacjaWRJ> Stacje { get; set; }
    }

    public partial class StacjaWRJ
    {
        [JsonProperty("arrivalLive")]
        public String arrivalLive { get; set; }

        [JsonProperty("arrivalTime")]
        public String arrivalTime { get; set; }

        [JsonProperty("arrivalDelay")]
        public int arrivalDelay { get; set; }

        [JsonProperty("arrivalRealTime")]
        public String arrivalRealTime { get; set; }

        [JsonProperty("pointDistance")]
        public float pointDistance { get; set; }

        [JsonProperty("pointName")]
        public String pointName { get; set; }

        [JsonProperty("pointNameRAW")]
        public String pointNameRAW { get; set; }

        [JsonProperty("entryId")]
        public int entryId { get; set; }

        [JsonProperty("pointID")]
        public String pointID { get; set; }

        [JsonProperty("comments")]
        public String comments { get; set; }

        [JsonProperty("confirmed")]
        public bool confirmed { get; set; }

        [JsonProperty("isStopped")]
        public bool isStopped { get; set; }

        [JsonProperty("pointStopTime")]
        public String pointStopTime { get; set; }

        [JsonProperty("pointStopType")]
        public String pointStopType { get; set; }

        [JsonProperty("departureLine")]
        public String departureLine { get; set; }

        [JsonProperty("departureTime")]
        public String departureTime { get; set; }

        [JsonProperty("departureDelay")]
        public int departureDelay { get; set; }

        [JsonProperty("departureRealTime")]
        public String departureRealTime { get; set; }
    }

    #endregion

    #region Kod do pobierania info o wersji

    public partial class JsonModelVersion
    {
        [JsonProperty("tag_name")]
        public string Version { get; set; }
    }

    public partial class JsonModelDownloadURL
    {
        [JsonProperty("assets")]
        public ResponceDownloadURL Version { get; set; }
    }

    public partial class ResponceDownloadURL
    {
        [JsonProperty("browser_download_url")]
        public string DownloadURL { get; set; }
    }

    #endregion

    public class API
    {
        System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

        private static readonly string URL = "https://api.github.com/repos/xMrbar/Generator-komunikatow-dworcowych/releases/latest";
        private static readonly string Version = "0.5.1";

        #region wylaczony kod - do ewentualnego usuniecia
        //String link;
        //link = "https://api.td2.info.pl:9640/?method=readFromSWDR&value=getTimetable%3B" + current.numerPociąguBox.Value.ToString() + "%3Beu";

        /*        public async Task GetCoinValues(Generator_komunikatów_dworcowych.komunikaty current)
                {
                    *//*String url = "https://api.td2.info.pl:9640/?method=readFromSWDR&value=getTimetable%3B" + current.numerPociąguBox.Value.ToString() + "%3Beu";

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();*//*



                    MessageBox.Show("M", "M");
                }*/
        #endregion

        #region pobieranie z API danych o pociagach
        public async Task DeserilizeJson(Generator_komunikatów_dworcowych.komunikaty current)
        {
            string url = "https://api.td2.info.pl:9640/?method=readFromSWDR&value=getTimetable%3B" + current.numerPociąguBox.Value.ToString() + "%3Beu";
            string responseBody;

            try
            {
                System.Net.Http.HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                responseBody = null;
            }

            JsonModel info = JsonConvert.DeserializeObject<JsonModel>(responseBody);
        }
        #endregion

        #region pobieranie danych z githuba
        public async Task DeserilizeJsonVersion()
        {
            string responseBody;

            try
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");//Set the User Agent to "request"

                System.Net.Http.HttpResponseMessage response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                responseBody = null;
            }

            JsonModelVersion info = JsonConvert.DeserializeObject<JsonModelVersion>(responseBody);
            JsonModelDownloadURL infoURL = JsonConvert.DeserializeObject<JsonModelDownloadURL>(responseBody);
        }

        #endregion
    }
}
