using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GifLib
{
    public class GifImage
    {
        public GifVersion Version { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color BackgroundColor { get; set; }
        public int ColorResolution { get; set; }
        public int PixelAspectRatio { get; set; }
        public short? LoopCount { get; set; }
        public ICollection<string> Comments { get; private set; } = new List<string>();
        public IList<GifFrame> Frames { get; private set; } = new List<GifFrame>();

        public static Task LoadAsync(Stream inputStream)
        {
            if (inputStream == null)
                throw new ArgumentNullException(nameof(inputStream));
            if (!inputStream.CanRead)
                throw new ArgumentException("Stream not readable", nameof(inputStream));

            throw new NotImplementedException();
        }

        public Task WriteAsync(Stream outputStream)
        {
            if (outputStream == null)
                throw new ArgumentNullException(nameof(outputStream));
            if (!outputStream.CanWrite)
                throw new ArgumentException("Stream not writable", nameof(outputStream));

            throw new NotImplementedException();
        }
    }
}
