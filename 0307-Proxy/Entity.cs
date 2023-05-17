using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0307_Proxy
{
    public interface ThirdPartyTVLib
    {
        List<string> ListVideos();

        string GetVideoInfo(string videoId);

        string DownloadVideo(string videoId);
    }

    public class ThirdPartyTVClass: ThirdPartyTVLib
    {
        private List<string> _videos { get; set; }

        public ThirdPartyTVClass()
        {
            _videos = new List<string> { "1", "2", "3" };
        }

        public List<string> ListVideos()
        {
            return _videos;
        }

        public string GetVideoInfo(string videoId)
        {
            return _videos.FirstOrDefault(x => x == videoId);
        }

        public string DownloadVideo(string videoId)
        {
            return _videos.FirstOrDefault(x => x == videoId);
        }
    }

    public class CachedTVClass: ThirdPartyTVLib
    {
        public List<string> VideoCaches { get; set; }

        public ThirdPartyTVLib Service { get; set; }

        public CachedTVClass(ThirdPartyTVClass thirdParty)
        {
            Service = thirdParty;
            VideoCaches = Service.ListVideos();
        }

        public string DownloadVideo(string videoId)
        {
            var exist = VideoCaches.FirstOrDefault(x => x == videoId);

            if (exist == null)
            {
                exist = Service.DownloadVideo(videoId);
                VideoCaches.Add(exist);
            }

            return exist;
        }

        public string GetVideoInfo(string videoId)
        {
            var exist = VideoCaches.FirstOrDefault(x => x == videoId);

            if (exist == null)
            {
                exist = Service.GetVideoInfo(videoId);
                VideoCaches.Add(exist);
            }

            return exist;
        }

        public List<string> ListVideos()
        {
            return VideoCaches;
        }
    }
}
