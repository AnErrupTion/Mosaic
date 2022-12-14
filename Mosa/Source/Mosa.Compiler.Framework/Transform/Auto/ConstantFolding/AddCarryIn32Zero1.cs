// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.ConstantFolding
{
	/// <summary>
	/// AddCarryIn32Zero1
	/// </summary>
	public sealed class AddCarryIn32Zero1 : BaseTransformation
	{
		public AddCarryIn32Zero1() : base(IRInstruction.AddCarryIn32)
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

			context.SetInstruction(IRInstruction.Add32, result, t1, t2);
		}
	}
}
