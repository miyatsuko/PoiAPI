using System.Threading.Tasks;

namespace Poi.API
{
    //api/v4/channels_report?ids={name1, name2...}&metrics={youtube_channel_subscriber,youtube_channel_view,bilibili_channel_subscriber,bilibili_channel_view}&startAt={1653598800000}&endAt={1656190800000}
    public class GetChannelReports
    {
        public Channel[] channels { get; set; }
        public Report[] reports { get; set; }
    }

    public class Report
    {
        public string id { get; set; }
        public string kind { get; set; }
        public long[][] rows { get; set; }
    }

    public partial class PoiAPI
    {
        public async Task<GetChannelReports> GetChannelReports(string[] vtuberIds, string[] metrics, long startAt = default, long endAt = default)
        {
            string param = "?ids=";
            for(int i = 0; i < vtuberIds.Length; i++)
            {
                param += vtuberIds[i];
                if(i < vtuberIds.Length - 1)
                {
                    param +=",";
                }
            }

            param += "&metrics=";
            for(int i = 0; i < metrics.Length; i++)
            {
                param += metrics[i];
                if(i < metrics.Length - 1)
                {
                    param +=",";
                }
            }

            if(startAt != default)
            {
                param += $"&startAt={startAt}";
            }
            
            if(endAt != default)
            {
                param += $"&endAt={endAt}";
            }

            return await HttpHelper.GET<GetChannelReports>(
                httpClient,
                $"https://holoapi.poi.cat/api/v4/channels_report{param}",
                headers
            );
        }
    }
}