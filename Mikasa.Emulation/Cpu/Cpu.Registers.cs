//=============================================================================
// Cpu.Registers.cs
// 65c816 processor registers
//
// Created by Victor on 2019/10/17
//=============================================================================

namespace Mikasa.Emulation.Cpu
{
    public partial class Cpu
    {
        // Registers named as the CPU understands
        private uint _a, _x, _y, _s, _db, _dp, _pb, _pc;

        /// <summary>
        /// Math register. Stores one of two operands or the result of most arithmetic and logical operations.
        /// </summary>
        public uint Accumulator
        {
            get => _a;
            set => _a = value; // TODO: This is incorrect
        }

        /// <summary>
        /// Can be used to reference memory, pass data to memory, or a counter for loops.
        /// </summary>
        public uint XIndex
        {
            get => _x;
            set => _x = value;
        }

        /// <summary>
        /// Can be used to reference memory, pass data to memory, or a counter for loops.
        /// </summary>
        public uint YIndex
        {
            get => _y;
            set => _y = value;
        }

        /// <summary>
        /// Points to the next available(unused) location on the stack.
        /// </summary>
        public uint StackPointer
        {
            get => _s;
            set => _s = value;
        }

        /// <summary>
        /// Holds the default bank for memory transfers.
        /// </summary>
        public uint DataBank
        {
            get => _db;
            set => _db = value;
        }

        /// <summary>
        /// Used for direct page addressing modes. Holds the memory bank address of the data the CPU is accessing.
        /// </summary>
        public uint DirectPage
        {
            get => _dp;
            set => _dp = value;
        }

        /// <summary>
        /// Holds the bank address of all instruction fetches.
        /// </summary>
        public uint ProgramBank
        {
            get => _pb;
            set => _pb = value;
        }

        /// <summary>
        /// Results of tests and 65c816 processing states.
        /// </summary>
        public CpuFlags P;

        /// <summary>
        /// Memory address of the current CPU instruction.
        /// </summary>
        public uint Pc
        {
            get => _pc;
            set => _pc = value;
        }
    }
}