// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.Reorder
{
	/// <summary>
	/// MulUnsigned32WithShiftLeft32
	/// </summary>
	public sealed class MulUnsigned32WithShiftLeft32 : BaseTransformation
	{
		public MulUnsigned32WithShiftLeft32() : base(IRInstruction.MulUnsigned32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand2.IsVirtualRegister)
				return false;

			if (context.Operand2.Definitions.Count != 1)
				return false;

			if (context.Operand2.Definitions[0].Instruction != IRInstruction.ShiftLeft32)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1;
			var t2 = context.Operand2.Definitions[0].Operand1;
			var t3 = context.Operand2.Definitions[0].Operand2;

			var v1 = transformContext.AllocateVirtualRegister(transformContext.I4);

			context.SetInstruction(IRInstruction.MulUnsigned32, v1, t1, t2);
			context.AppendInstruction(IRInstruction.ShiftLeft32, result, v1, t3);
		}
	}

	/// <summary>
	/// MulUnsigned32WithShiftLeft32_v1
	/// </summary>
	public sealed class MulUnsigned32WithShiftLeft32_v1 : BaseTransformation
	{
		public MulUnsigned32WithShiftLeft32_v1() : base(IRInstruction.MulUnsigned32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand1.IsVirtualRegister)
				return false;

			if (context.Operand1.Definitions.Count != 1)
				return false;

			if (context.Operand1.Definitions[0].Instruction != IRInstruction.ShiftLeft32)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1.Definitions[0].Operand1;
			var t2 = context.Operand1.Definitions[0].Operand2;
			var t3 = context.Operand2;

			var v1 = transformContext.AllocateVirtualRegister(transformContext.I4);

			context.SetInstruction(IRInstruction.MulUnsigned32, v1, t3, t1);
			context.AppendInstruction(IRInstruction.ShiftLeft32, result, v1, t2);
		}
	}
}
