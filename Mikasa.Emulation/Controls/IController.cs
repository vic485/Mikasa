using System;

namespace Mikasa.Emulation.Controls
{
    public interface IController
    {
        int ReadState();

        void KeyPress(string keyCode);
    }
}