using System;

namespace GifLib
{
    /// <summary>
    /// Represents a single frame in a GIF image.
    /// </summary>
    public class GifFrame
    {
        /// <summary>
        /// Gets or sets the width of the frame, in pixels.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Gets or sets the height of the frame, in pixels.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Gets or sets the left side offset of the frame, in pixels.
        /// </summary>
        public int Left { get; set; }
        /// <summary>
        /// Gets or sets the top side offset of the frame, in pixels.
        /// </summary>
        public int Top { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the pixels of the frame
        /// are interlaced.
        /// </summary>
        public bool IsInterlaced { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="GifLib.DisposalMethod"/> of the
        /// frame.
        /// </summary>
        public DisposalMethod DisposalMethod { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="GifLib.Color"/> that will be
        /// used as transparent.
        /// </summary>
        public Color TransparentColor { get; set; }
        /// <summary>
        /// Gets or sets a <see cref="System.TimeSpan"/> indicating the delay
        /// before the frame is disposed.
        /// </summary>
        public TimeSpan Delay { get; set; }
    }
}
