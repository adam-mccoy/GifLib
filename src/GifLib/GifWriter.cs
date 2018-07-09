using System;
using System.IO;
using System.Threading.Tasks;

namespace GifLib
{
    internal class GifWriter
    {
        private readonly Stream _outputStream;

        public GifWriter(Stream outputStream)
        {
            _outputStream = outputStream;
        }

        public async Task WriteVersionAsync(GifVersion version)
        {
            byte[] toWrite;
            if (version == GifVersion.Gif87a)
                toWrite = Encodings.Version87a;
            else if (version == GifVersion.Gif89a)
                toWrite = Encodings.Version89a;
            else
                throw new ArgumentException("Invalid version specified", nameof(version));

            await _outputStream.WriteAsync(toWrite, 0, toWrite.Length);
        }
    }
}
