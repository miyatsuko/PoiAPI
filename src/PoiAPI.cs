using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Poi.API
{
    public partial class PoiAPI : IDisposable
    {
        HttpClient httpClient;
        readonly List<(string, string)> headers;

        public PoiAPI()
        {
            httpClient = new HttpClient();

            headers = new List<(string, string)>
            {
                ("Accept", "*/*"),
                ("Accept-Language", "en-US,en;q=0.5"),
                ("Accept-Encoding", "gzip, deflate"),
                ("Connection", "keep-alive"),
                ("Host", "holoapi.poi.cat"),
                ("Origin", "https://holo.poi.cat"),
                ("Referer", "https://holo.poi.cat/"),
                ("Sec-Fetch-Dest", "empty"),
                ("Sec-Fetch-Mode", "cors"),
                ("Sec-Fetch-Site", "same-origin"),
                ("User-Agent", "Mozilla/5.0"),
            };
        }

        ~PoiAPI()
        {
            Dispose();
        }

        public void Dispose()
        {
            httpClient?.Dispose();
        }
    }
}
