﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Intrinsic
{
	/// <summary>
	/// IntrinsicMethods
	/// </summary>
	static partial class IntrinsicMethods
	{
		[IntrinsicMethod("Mosa.Platform.x64.Intrinsic::Sqrtsd")]
		private static void Sqrtsd(Context context, MethodCompiler methodCompiler)
		{
			context.SetInstruction(X64.Sqrtsd, context.Result, context.Operand1);
		}
	}
}
