using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net;
/*using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;*/
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Versioning;
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

    #endregion

    public class API
    {
        System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

        private static readonly string URL = "https://api.github.com/repos/xMrbar/Generator-komunikatow-dworcowych/releases/latest";
        private static readonly string Version = "0.6.1";

        #region pobieranie z API danych o pociagach

        [SupportedOSPlatform("windows")]
        public async Task DeserilizeJsonTrain(Generator_komunikatów_dworcowych.komunikaty current)
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
                MessageBox.Show("Błąd podczas pobieranai danych o składzie " + current.numerPociąguBox.Value.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JsonModel info = JsonConvert.DeserializeObject<JsonModel>(responseBody);
        }
        #endregion

        #region pobieranie danych z githuba
        public async Task DeserilizeJsonVersion(Generator_komunikatów_dworcowych.komunikaty current)
        {
            string responseBody;

            try
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");

                System.Net.Http.HttpResponseMessage response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można sprawdzić czy jest nowsza wersja!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                responseBody = null;
            }

            JsonModelVersion info = JsonConvert.DeserializeObject<JsonModelVersion>(responseBody);

            PorownanieWersji(info, current);
        }

        public static void PorownanieWersji(JsonModelVersion info, Generator_komunikatów_dworcowych.komunikaty current)
        {
            if(info != null)
            {
                if(info.Version != null)
                {
                    if (!Version.Equals(info.Version))
                    {
                        MessageBox.Show("Nowa wersja dostępna", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Process.Start(@".\GeneratorKomunikatowUpdater.exe");
                        current.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nie udało się zweryfikować najnowszej wersji \n Sprawdź czy masz dostęp do internetu!", "Błąd (info.Version == null)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Nie udało się zweryfikować najnowszej wersji \n Sprawdź czy masz dostęp do internetu!", "Błąd (info == null)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
