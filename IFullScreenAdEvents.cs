using System;

namespace Ads
{
    public interface IFullScreenAdEvents
    {
        Action Hidden { set; }
        Action<int> Loaded { set; }
        Action Showed { set; }
    }
}