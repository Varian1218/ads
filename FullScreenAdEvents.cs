using System;

namespace Ads
{
    public class FullScreenAdEvents : IFullScreenAdEvents
    {
        public Action Hidden { get; set; }
        public Action<int> Loaded { get; set; }
        public Action Showed { get; set; }
    }
}