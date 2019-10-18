using System;

namespace Mikasa.Emulation.Cpu
{
    [Flags]
    public enum CpuFlags
    {
        Carry = 0x01,
        Zero = 0x02,
        IrqDisable = 0x04,
        Decimal = 0x08,

        /// <summary>
        /// 8-bit if set, otherwise 16-bit
        /// </summary>
        IndexRegisterSize = 0x10,

        /// <summary>
        /// 8-bit if set, otherwise 16-bit
        /// </summary>
        AccumulatorRegisterSize = 0x20,
        Overflow = 0x40,
        Negative = 0x80,
        Emulation = 0x100
    }
}