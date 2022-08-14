// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.ConstantFolding
{
	/// <summary>
	/// SubCarryIn64Outside1
	/// </summary>
	public sealed class SubCarryIn64Outside1 : BaseTransformation
	{
		public SubCarryIn64Outside1() : base(IRInstruction.SubCarryIn64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!IsResolvedConstant(context.Operand1))
				return false;

			if (!IsResolvedConstant(context.Operand3))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1;
			var t2 = context.Operand3;

			var e1 = transformContext.CreateConstant(Sub64(To64(t1), BoolTo64(To64(t2))));

			context.SetInstruction(IRInstruction.Sub64, result, e1);
		}
	}
}
