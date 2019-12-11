using System.Collections.Generic;

namespace Mikasa.Emulation.Controls
{
    public class Shvc005 : IController
    {
        // Key data
        // Bit:   15  14  13      12     11  10    9     8      7  6  5   4   3  2  1  0  
        // Value: B   Y   SELECT  START  UP  DOWN  LEFT  RIGHT  A  X  LB  RB  -  -  -  -
        private int _data;

        private Dictionary<string, int> _keyMap = new Dictionary<string, int>
        {
            {"Z", 15},
            {"X", 7},
            {"A", 14},
            {"S", 6},
            {"Q", 5},
            {"W", 4},
            {"Enter", 12},
            {"LShift", 13},
            {"Up", 11},
            {"Down", 10},
            {"Left", 9},
            {"Right", 8}
        };

        public int ReadState()
        {
            throw new System.NotImplementedException();
        }

        public void KeyPress(string keyCode)
        {
            if (!_keyMap.ContainsKey(keyCode)) return;
            _data |= 1 << _keyMap[keyCode];
        }
    }
}