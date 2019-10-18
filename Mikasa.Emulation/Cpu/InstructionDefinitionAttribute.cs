using System;

namespace Mikasa.Emulation.Cpu
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class InstructionDefinition : Attribute
    {
        public int HexValue;
        public int Cycles = 1;
        public CpuFlags CpuMode = 0;
    }
}