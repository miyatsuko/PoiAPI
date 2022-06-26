namespace Poi.API
{
    public static class ChannelMetric
    {
        public const string youtube_channel_subscriber = "youtube_channel_subscriber";
        public const string youtube_channel_view = "youtube_channel_view";
        public const string bilibili_channel_subscriber = "bilibili_channel_subscriber";
        public const string bilibili_channel_view = "bilibili_channel_view";

        public static readonly string[] all;
        public static readonly string[] all_youtube;
        public static readonly string[] all_bilibili;

        static ChannelMetric()
        {
            all = new string[] { youtube_channel_subscriber, youtube_channel_view, bilibili_channel_subscriber, bilibili_channel_view };
            all_youtube = new string[] { youtube_channel_subscriber, youtube_channel_view};
            all_bilibili = new string[] { bilibili_channel_subscriber, bilibili_channel_view };
        }
    }
}