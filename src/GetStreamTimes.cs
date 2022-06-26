using System.Threading.Tasks;

namespace Poi.API
{
    //api/v4/stream_times?id={name}
    public class GetStreamTimes
    {
        public long[][] times { get; set; }
    }

    public partial class PoiAPI
    {
        public async Task<GetStreamTimes> GetStreamTimes(string vtuberId)
        {
            string param = $"?id={vtuberId}";

            return await HttpHelper.GET<GetStreamTimes>(
                httpClient,
                $"https://holoapi.poi.cat/api/v4/stream_times{param}",
                headers
            );
        }
    }
}