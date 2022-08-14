// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// StoreParamCompound
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class StoreParamCompound : BaseIRInstruction
	{
		public StoreParamCompound()
			: base(2, 0)
		{
		}

		public override bool IsMemoryWrite { get { return true; } }

		public override bool IsParameterStore { get { return true; } }
	}
}
