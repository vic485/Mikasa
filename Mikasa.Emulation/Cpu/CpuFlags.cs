//=============================================================================
// CpuFlags.cs
// Enum flags used to set/get the processor state
//
// Created by Victor on 2019/10/17
//=============================================================================

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
        /// If <see cref="Emulation"/> is set, this is a Break flag instead
        /// </summary>
        IndexRegisterSize = 0x10,

        /// <summary>
        /// 8-bit if set, otherwise 16-bit
        /// </summary>
        AccumulatorRegisterSize = 0x20,
        Overflow = 0x40,
        Negative = 0x80,
        
        /// <summary>
        /// 6502 emulation mode
        /// </summary>
        Emulation = 0x100
    }
}