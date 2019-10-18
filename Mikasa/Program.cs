using System;
using GLFW;

namespace Mikasa
{
    internal class Program
    {
        // TODO: Massive slowdowns when launching with Rider
        private static void Main(string[] args)
        {
            // 512x448 is the maximum resolution of a super famicom game
            // Most games used 256x224 as this was faster however
            using var window = new NativeWindow(512, 448, "Mikasa");
            window.SetIcons(new IconHelper("./MikasaIcon.png").ToImage());
            while (!window.IsClosing)
            {
                window.SwapBuffers();
                Glfw.PollEvents();
            }
        }
    }
}