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
        /// <summary>
        /// C
        /// </summary>
        Carry = 0x01,
        
        /// <summary>
        /// Z
        /// </summary>
        Zero = 0x02,
        
        /// <summary>
        /// I
        /// </summary>
        IrqDisable = 0x04,
        
        /// <summary>
        /// D
        /// </summary>
        Decimal = 0x08,

        /// <summary>
        /// X - 8-bit if set, otherwise 16-bit
        /// If <see cref="Emulation"/> is set, this is a Break flag instead
        /// </summary>
        IndexRegisterSize = 0x10,

        /// <summary>
        /// M - 8-bit if set, otherwise 16-bit
        /// </summary>
        AccumulatorRegisterSize = 0x20,
        
        /// <summary>
        /// V
        /// </summary>
        Overflow = 0x40,
        
        /// <summary>
        /// N
        /// </summary>
        Negative = 0x80,
        
        /// <summary>
        /// E - 6502 emulation mode
        /// </summary>
        Emulation = 0x100
    }
}