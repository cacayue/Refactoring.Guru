using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0305_Facade
{
    public class VideoConverter
    {
        public string ConvertVideo(string file, string format)
        {
            var videoFile = new VideoFile(file);
            CompresstionCodec compresstion;

            if (format == "mp4")
            {
                compresstion = new MPG4CompresstionCodec("MP4");
            }
            else
            {
                compresstion = new OggCompresstionCodec("Ogg");
            }

            var convertFile = new ConvertFile();

            return convertFile.GetFile(videoFile, compresstion);
        }
    }

    public class VideoFile
    {
        public string Name { get; private set; }

        public VideoFile(string name)
        {
            Name = name;
        }
    }

    public class CompresstionCodec
    {
        public string Code { get; private set; }

        public CompresstionCodec(string code)
        {
            Code = code;
        }
    }

    public class MPG4CompresstionCodec : CompresstionCodec
    {
        public MPG4CompresstionCodec(string code) : base(code)
        {
        }
    }

    public class OggCompresstionCodec : CompresstionCodec
    {
        public OggCompresstionCodec(string code) : base(code)
        {
        }
    }

    public class ConvertFile
    {
        public string GetFile(VideoFile videoFile, CompresstionCodec compresstion)
        {
            return videoFile.Name + compresstion.Code;
        }
    }
}
