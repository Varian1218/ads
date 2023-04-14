using System;

namespace Ads
{
    public interface IFullScreenAdEvents
    {
        Action Hidden { set; }
        Action<string> Loaded { set; }
        Action Showed { set; }
    }
}