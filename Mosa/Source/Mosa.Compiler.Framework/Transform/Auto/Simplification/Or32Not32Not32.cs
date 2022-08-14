// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.Simplification
{
	/// <summary>
	/// Or32Not32Not32
	/// </summary>
	public sealed class Or32Not32Not32 : BaseTransformation
	{
		public Or32Not32Not32() : base(IRInstruction.Or32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand1.IsVirtualRegister)
				return false;

			if (!context.Operand2.IsVirtualRegister)
				return false;

			if (context.Operand1.Definitions.Count != 1)
				return false;

			if (context.Operand1.Definitions[0].Instruction != IRInstruction.Not32)
				return false;

			if (context.Operand2.Definitions.Count != 1)
				return false;

			if (context.Operand2.Definitions[0].Instruction != IRInstruction.Not32)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1.Definitions[0].Operand1;
			var t2 = context.Operand2.Definitions[0].Operand1;

			var v1 = transformContext.AllocateVirtualRegister(transformContext.I4);

			context.SetInstruction(IRInstruction.And32, v1, t1, t2);
			context.AppendInstruction(IRInstruction.Not32, result, v1);
		}
	}
}
