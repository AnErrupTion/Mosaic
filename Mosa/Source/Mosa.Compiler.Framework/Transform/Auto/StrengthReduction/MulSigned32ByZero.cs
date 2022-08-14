// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.StrengthReduction
{
	/// <summary>
	/// MulSigned32ByZero
	/// </summary>
	public sealed class MulSigned32ByZero : BaseTransformation
	{
		public MulSigned32ByZero() : base(IRInstruction.MulSigned32)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand2.IsResolvedConstant)
				return false;

			if (context.Operand2.ConstantUnsigned64 != 0)
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var e1 = transformContext.CreateConstant(To32(0));

			context.SetInstruction(IRInstruction.Move32, result, e1);
		}
	}

	/// <summary>
	/// MulSigned32ByZero_v1
	/// </summary>
	public sealed class MulSigned32ByZero_v1 : BaseTransformation
	{
		public MulSigned32ByZero_v1() : base(IRInstruction.MulSigned32)
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

			var e1 = transformContext.CreateConstant(To32(0));

			context.SetInstruction(IRInstruction.Move32, result, e1);
		}
	}
}
