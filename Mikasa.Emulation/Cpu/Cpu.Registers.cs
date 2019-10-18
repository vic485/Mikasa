namespace Mikasa.Emulation.Cpu
{
    public partial class Cpu
    {
        /// <summary>
        /// Accumulator
        /// </summary>
        public uint A;

        /// <summary>
        /// Index
        /// </summary>
        public uint X, Y;

        /// <summary>
        /// Stack pointer
        /// </summary>
        public uint S;

        /// <summary>
        /// Data bank
        /// </summary>
        public uint Db;

        /// <summary>
        /// Direct page
        /// </summary>
        public uint Dp;

        /// <summary>
        /// Program bank
        /// </summary>
        public uint Pb;

        /// <summary>
        /// Processor status
        /// </summary>
        public CpuFlags P;

        /// <summary>
        /// Program counter
        /// </summary>
        public uint Pc;
    }
}