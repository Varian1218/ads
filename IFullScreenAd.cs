namespace Ads
{
    public interface IFullScreenAd
    {
        IFullScreenAdEvents Events { get; }
        bool IsEarned();
        void Load();
        void Show();
    }
}