namespace Mikasa.Emulation.Cpu
{
    public partial class Cpu
    {
        // ReSharper disable InconsistentNaming
        /// <summary>
        /// Decrement Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xCA, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void DEX() => X--;

        /// <summary>
        /// Decrement Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0x88, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void DEY() => Y--;

        /// <summary>
        /// Increment Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xE8, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void INX() => X++;

        /// <summary>
        /// Increment Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0xC8, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void INY() => Y++;

        /// <summary>
        /// Transfer Accumulator to Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xAA, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TAX() => X = A;

        /// <summary>
        /// Transfer Accumulator to Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0xA8, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TAY() => Y = A;

        /// <summary>
        /// Transfer Stack Pointer to Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xBA, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TSX() => X = S;

        /// <summary>
        /// Transfer Index Register X to Accumulator
        /// </summary>
        [InstructionDefinition(HexValue = 0x8A, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TXA() => A = X;

        /// <summary>
        /// Transfer Index Register X to Stack Pointer
        /// </summary>
        [InstructionDefinition(HexValue = 0x9A, Cycles = 2)]
        public void TXS() => S = X;

        /// <summary>
        /// Transfer Index Register X to Index Register Y
        /// </summary>
        [InstructionDefinition(HexValue = 0x9B, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TXY() => Y = X;

        /// <summary>
        /// Transfer Index Register Y to Accumulator
        /// </summary>
        [InstructionDefinition(HexValue = 0x98, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TYA() => A = Y;

        /// <summary>
        /// Transfer Index Register Y to Index Register X
        /// </summary>
        [InstructionDefinition(HexValue = 0xBB, Cycles = 2, CpuMode = CpuFlags.Negative | CpuFlags.Zero)]
        public void TYX() => X = Y;
        // ReSharper enable InconsistentNaming
    }
}