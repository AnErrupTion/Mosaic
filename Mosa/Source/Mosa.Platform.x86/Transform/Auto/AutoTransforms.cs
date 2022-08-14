// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework.Transform;
using System.Collections.Generic;

namespace Mosa.Platform.x86.Transform.Auto
{
	/// <summary>
	/// Transformations
	/// </summary>
	public static class AutoTransforms
	{
		public static readonly List<BaseTransformation> List = new List<BaseTransformation> {
			 new Standard.Mov32Consolidate(),
			 new StrengthReduction.Add32ByZero(),
			 new StrengthReduction.Add32ByZero_v1(),
			 new StrengthReduction.Sub32ByZero(),
		};
	}
}
