//=============================================================================
// InstructionDefinitionAttribute.cs
// Attribute placed on methods which are to be processor OpCode calls
//
// Created by Victor on 2019/10/17
//=============================================================================

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