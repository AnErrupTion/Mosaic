// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.ARMv8A32.Instructions
{
	/// <summary>
	/// Stf - Store Floating Point Data Transfer
	/// </summary>
	/// <seealso cref="Mosa.Platform.ARMv8A32.ARMv8A32Instruction" />
	public sealed class Stf : ARMv8A32Instruction
	{
		internal Stf()
			: base(0, 3)
		{
		}

		public override void Emit(InstructionNode node, OpcodeEncoder opcodeEncoder)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 0);
			System.Diagnostics.Debug.Assert(node.OperandCount == 3);

			if (node.Operand1.IsCPURegister && node.Operand2.IsConstant && node.Operand3.IsCPURegister)
			{
				opcodeEncoder.Append4Bits(GetConditionCode(node.ConditionCode));
				opcodeEncoder.Append3Bits(0b110);
				opcodeEncoder.Append1Bit(0b1);
				opcodeEncoder.Append1Bit(node.Operand3.IsR4 ? 0 : 1);
				opcodeEncoder.Append1Bit(0b0);
				opcodeEncoder.Append1Bit(0b0);
				opcodeEncoder.Append4Bits(node.Operand1.Register.RegisterCode);
				opcodeEncoder.Append1Bit(node.Operand3.IsR4 ? 0 : 1);
				opcodeEncoder.Append4Bits(node.Operand3.Register.RegisterCode);
				opcodeEncoder.Append4Bits(0b0001);
				opcodeEncoder.Append8BitImmediate(node.Operand2);
				return;
			}

			throw new Compiler.Common.Exceptions.CompilerException("Invalid Opcode");
		}
	}
}
