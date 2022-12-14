// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.ConstantFolding
{
	/// <summary>
	/// AddCarryIn64Zero1
	/// </summary>
	public sealed class AddCarryIn64Zero1 : BaseTransformation
	{
		public AddCarryIn64Zero1() : base(IRInstruction.AddCarryIn64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand1.IsResolvedConstant)
				return false;

			if (context.Operand1.ConstantUnsigned64 != 0)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand2;
			var t2 = context.Operand3;

			context.SetInstruction(IRInstruction.Add64, result, t1, t2);
		}
	}
}
