using System;

namespace Ads
{
    public class FullScreenAd : IFullScreenAd
    {
        private Func<bool> _isEarned;
        private Action _load;
        private Action _show;

        public IFullScreenAdEvents Events { get; set; }

        public Func<bool> IsEarned
        {
            set => _isEarned = value;
        }

        public Action Load
        {
            set => _load = value;
        }

        public Action Show
        {
            set => _show = value;
        }

        bool IFullScreenAd.IsEarned()
        {
            return _isEarned();
        }

        void IFullScreenAd.Load()
        {
            _load();
        }

        void IFullScreenAd.Show()
        {
            _show();
        }
    }
}