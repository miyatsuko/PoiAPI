using System.Threading.Tasks;

namespace Poi.API
{
    //api/v4/youtube_streams?ids={name1, name2...}&status={live, ended, scheduled}[&orderBy={schedule_time:asc}][&startAt={1669882800000}]
    public class GetYoutubeStreams
    {
        public long updatedAt { get; set; }
        public YoutubeStreams[] streams { get; set; }
    }

    public class YoutubeStreams
    {
        public string streamId { get; set; }
        public string title { get; set; }
        public string vtuberId { get; set; }
        public string thumbnailUrl { get; set; }
        public long scheduleTime { get; set; }
        public long startTime { get; set; }
        public long endTime { get; set; }
        public long averageViewerCount { get; set; }
        public long maxViewerCount { get; set; }
        public long maxLikeCount { get; set; }
        public long updatedAt { get; set; }
        public string status { get; set; }
    }

    public partial class PoiAPI
    {
        public async Task<GetYoutubeStreams> GetYoutubeStreams(string[] vtuberIds, string[] status, long endAt = default)
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
            param += "&status=";
            for(int i = 0; i < status.Length; i++)
            {
                param += status[i];
                if(i < status.Length - 1)
                {
                    param +=",";
                }
            }

            if(endAt != default)
            {
                param += $"&endAt={endAt}";
            }

            return await HttpHelper.GET<GetYoutubeStreams>(
                httpClient,
                $"https://holoapi.poi.cat/api/v4/youtube_streams{param}",
                headers
            );
        }
    }
}