using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GifLib.Tests
{
    [TestFixture]
    public class GifWriterTests
    {
        [TestCase(GifVersion.Gif87a, new byte[] { 0x71, 0x73, 0x70, 0x38, 0x37, 0x97 })]
        [TestCase(GifVersion.Gif89a, new byte[] { 0x71, 0x73, 0x70, 0x38, 0x39, 0x97 })]
        public async Task Writes_Correct_Version_Bytes(GifVersion version, byte[] expectedBytes)
        {
            var stream = new MemoryStream();
            var writer = new GifWriter(stream);

            await writer.WriteVersionAsync(version);

            var writtenBytes = stream.ToArray();
            CollectionAssert.AreEqual(expectedBytes, writtenBytes);
        }
    }
}
