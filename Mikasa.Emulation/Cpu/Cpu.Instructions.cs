//=============================================================================
// Cpu.Instructions.cs
// Methods of 65c816 processor instructions
//
// Created by Victor on 2019/10/18
//=============================================================================

namespace Mikasa.Emulation.Cpu
{
    public partial class Cpu
    {
        // ReSharper disable InconsistentNaming
        /// <summary>
        /// Decrement Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xCA, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void DEX() => XIndex--;

        /// <summary>
        /// Decrement Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0x88, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void DEY() => YIndex--;

        /// <summary>
        /// Increment Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xE8, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void INX() => XIndex++;

        /// <summary>
        /// Increment Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0xC8, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void INY() => YIndex++;

        /// <summary>
        /// Transfer Accumulator to Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xAA, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TAX() => XIndex = Accumulator;

        /// <summary>
        /// Transfer Accumulator to Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0xA8, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TAY() => YIndex = Accumulator;

        /// <summary>
        /// Transfer Stack Pointer to Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xBA, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TSX() => XIndex = StackPointer;

        /// <summary>
        /// Transfer Index Register X to Accumulator
        /// </summary>
        [InstructionDefinition(HexValue = 0x8A, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TXA() => Accumulator = XIndex;

        /// <summary>
        /// Transfer Index Register X to Stack Pointer
        /// </summary>
        [InstructionDefinition(HexValue = 0x9A, Cycles = 2)]
        public void TXS() => StackPointer = XIndex;

        /// <summary>
        /// Transfer Index Register X to Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0x9B, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TXY() => YIndex = XIndex;

        /// <summary>
        /// Transfer Index Register Y to Accumulator
        /// </summary>
        [InstructionDefinition(HexValue = 0x98, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TYA() => Accumulator = YIndex;

        /// <summary>
        /// Transfer Index Register Y to Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xBB, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TYX() => XIndex = YIndex;
        // ReSharper enable InconsistentNaming
    }
}