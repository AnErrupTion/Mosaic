﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Transform.Manual.ConstantFolding
{
	public sealed class Compare64x64 : BaseTransformation
	{
		public Compare64x64() : base(IRInstruction.Compare64x64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!IsResolvedConstant(context.Operand1))
				return false;

			if (!IsResolvedConstant(context.Operand2))
				return false;

			return IsNormal(context.ConditionCode);
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var compare = Compare64(context);

			var e1 = transformContext.CreateConstant(BoolTo64(compare));

			context.SetInstruction(IRInstruction.Move64, context.Result, e1);
		}
	}
}
