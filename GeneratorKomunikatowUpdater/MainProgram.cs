using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;

namespace GeneratorKomunikatowUpdater
{
    public partial class MainProgram : Form
    {
        HttpClient client = new HttpClient();
        WebClient webClient = new WebClient();
        private static readonly string URL = "https://api.github.com/repos/xMrbar/Generator-komunikatow-dworcowych/releases/latest";

        public MainProgram()
        {
            InitializeComponent();

            Pomocniczy();
        }

        public void Pomocniczy()
        {
            DeserilizeJsonVersion();
        }


        public async Task DeserilizeJsonVersion()
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
                responseBody = null;
            }

            JsonModelDownloadURL infoURL = JsonConvert.DeserializeObject<JsonModelDownloadURL>(responseBody);

            var url = infoURL.DownloadURLList[0].DownloadURL;
            var uri = new Uri(url);

            Operacje(uri);
        }

        public void Operacje(Uri uri)
        {
            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\Generator_Komunikatow.exe");
                webClient.DownloadFile(uri, @"Generator_Komunikatow.exe");
                Process.Start(@".\Generator_Komunikatow.exe");
                this.Close();
            }
            catch
            {

            }
        }
    }

    public partial class JsonModelDownloadURL
    {
        [JsonProperty("assets")]
        public List<ResponceDownloadURL> DownloadURLList { get; set; }
    }

    public partial class ResponceDownloadURL
    {
        [JsonProperty("browser_download_url")]
        public string DownloadURL { get; set; }
    }
}