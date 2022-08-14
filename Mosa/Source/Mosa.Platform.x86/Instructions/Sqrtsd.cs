// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// Sqrtsd
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed class Sqrtsd : X86Instruction
	{
		internal Sqrtsd()
			: base(1, 1)
		{
		}

		public override bool IsCommutative { get { return true; } }

		public override void Emit(InstructionNode node, OpcodeEncoder opcodeEncoder)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 1);
			System.Diagnostics.Debug.Assert(node.OperandCount == 1);

			opcodeEncoder.Append8Bits(0xF2);
			opcodeEncoder.Append8Bits(0x0F);
			opcodeEncoder.Append8Bits(0x51);
			opcodeEncoder.Append2Bits(0b11);
			opcodeEncoder.Append3Bits(node.Result.Register.RegisterCode);
			opcodeEncoder.Append3Bits(node.Operand1.Register.RegisterCode);
		}
	}
}