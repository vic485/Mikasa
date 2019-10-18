using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Mikasa
{
    // Taken from Edo Engine
    public class IconHelper
    {
        internal int Width { get; }
        internal int Height { get; }
        internal byte[] Pixels { get; }

        /// <summary>
        /// Creates a new bitmap based icon
        /// </summary>
        /// <param name="path">Icon file path</param>
        public IconHelper(string path)
        {
            var bmp = new Bitmap(path);
            Width = bmp.Width;
            Height = bmp.Height;

            // Setup the bitmap
            var rect = new Rectangle(0, 0, Width, Height);
            var bmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, bmp.PixelFormat);

            // Create icon
            var ptr = bmpData.Scan0;
            var bytes = Math.Abs(bmpData.Stride) * Height;
            Pixels = new byte[bytes];
            Marshal.Copy(ptr, Pixels, 0, bytes);
            ChangePixelFormat();
            
            bmp.Dispose();
        }

        /// <summary>
        /// Converts this image to a GLFW compatible image
        /// </summary>
        /// <returns>GLFW image</returns>
        public GLFW.Image ToImage()
        {
            var size = Width * Height * 4;
            var img = new GLFW.Image(Width, Height, Marshal.AllocHGlobal(size));

            Marshal.Copy(Pixels, 0, img.Pixels, Math.Min(size, Pixels.Length));
            return img;
        }

        /// <summary>
        /// Changes the pixel format from default bitmap to GLFW's expected format
        /// </summary>
        private void ChangePixelFormat()
        {
            // TODO: Is this performant enough? (do we care?)
            for (var i = 0; i < Pixels.Length; i += 4)
            {
                // Swap red and blue channels
                var r = Pixels[i];
                Pixels[i] = Pixels[i + 2];
                Pixels[i + 2] = r;
            }
        }
    }
}