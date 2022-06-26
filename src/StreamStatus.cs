namespace Poi.API
{
    public static class StreamStatus
    {
        public const string live = "live";
        public const string ended = "ended";
        public const string scheduled = "scheduled";

        public static readonly string[] all;
        public static readonly string[] live_ended;

        static StreamStatus()
        {
            all = new string[] { live, ended, scheduled};
            live_ended = new string[] { live, ended};
        }
    }
}