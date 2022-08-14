// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.Framework.Transform.Auto.ConstantFolding
{
	/// <summary>
	/// MulSigned64x2
	/// </summary>
	public sealed class MulSigned64x2 : BaseTransformation
	{
		public MulSigned64x2() : base(IRInstruction.MulSigned64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand1.IsVirtualRegister)
				return false;

			if (context.Operand1.Definitions.Count != 1)
				return false;

			if (context.Operand1.Definitions[0].Instruction != IRInstruction.MulSigned64)
				return false;

			if (!IsResolvedConstant(context.Operand1.Definitions[0].Operand2))
				return false;

			if (!IsResolvedConstant(context.Operand2))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1.Definitions[0].Operand1;
			var t2 = context.Operand1.Definitions[0].Operand2;
			var t3 = context.Operand2;

			var e1 = transformContext.CreateConstant(MulSigned64(ToSigned64(t2), ToSigned64(t3)));

			context.SetInstruction(IRInstruction.MulSigned64, result, t1, e1);
		}
	}

	/// <summary>
	/// MulSigned64x2_v1
	/// </summary>
	public sealed class MulSigned64x2_v1 : BaseTransformation
	{
		public MulSigned64x2_v1() : base(IRInstruction.MulSigned64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand2.IsVirtualRegister)
				return false;

			if (context.Operand2.Definitions.Count != 1)
				return false;

			if (context.Operand2.Definitions[0].Instruction != IRInstruction.MulSigned64)
				return false;

			if (!IsResolvedConstant(context.Operand2.Definitions[0].Operand2))
				return false;

			if (!IsResolvedConstant(context.Operand1))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1;
			var t2 = context.Operand2.Definitions[0].Operand1;
			var t3 = context.Operand2.Definitions[0].Operand2;

			var e1 = transformContext.CreateConstant(MulSigned64(ToSigned64(t3), ToSigned64(t1)));

			context.SetInstruction(IRInstruction.MulSigned64, result, t2, e1);
		}
	}

	/// <summary>
	/// MulSigned64x2_v2
	/// </summary>
	public sealed class MulSigned64x2_v2 : BaseTransformation
	{
		public MulSigned64x2_v2() : base(IRInstruction.MulSigned64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand1.IsVirtualRegister)
				return false;

			if (context.Operand1.Definitions.Count != 1)
				return false;

			if (context.Operand1.Definitions[0].Instruction != IRInstruction.MulSigned64)
				return false;

			if (!IsResolvedConstant(context.Operand1.Definitions[0].Operand1))
				return false;

			if (!IsResolvedConstant(context.Operand2))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1.Definitions[0].Operand1;
			var t2 = context.Operand1.Definitions[0].Operand2;
			var t3 = context.Operand2;

			var e1 = transformContext.CreateConstant(MulSigned64(ToSigned64(t1), ToSigned64(t3)));

			context.SetInstruction(IRInstruction.MulSigned64, result, t2, e1);
		}
	}

	/// <summary>
	/// MulSigned64x2_v3
	/// </summary>
	public sealed class MulSigned64x2_v3 : BaseTransformation
	{
		public MulSigned64x2_v3() : base(IRInstruction.MulSigned64)
		{
		}

		public override bool Match(Context context, TransformContext transformContext)
		{
			if (!context.Operand2.IsVirtualRegister)
				return false;

			if (context.Operand2.Definitions.Count != 1)
				return false;

			if (context.Operand2.Definitions[0].Instruction != IRInstruction.MulSigned64)
				return false;

			if (!IsResolvedConstant(context.Operand2.Definitions[0].Operand1))
				return false;

			if (!IsResolvedConstant(context.Operand1))
				return false;

			return true;
		}

		public override void Transform(Context context, TransformContext transformContext)
		{
			var result = context.Result;

			var t1 = context.Operand1;
			var t2 = context.Operand2.Definitions[0].Operand1;
			var t3 = context.Operand2.Definitions[0].Operand2;

			var e1 = transformContext.CreateConstant(MulSigned64(ToSigned64(t2), ToSigned64(t1)));

			context.SetInstruction(IRInstruction.MulSigned64, result, t3, e1);
		}
	}
}
