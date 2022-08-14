// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// NewObject
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class NewObject : BaseIRInstruction
	{
		public NewObject()
			: base(2, 1)
		{
		}

		public override bool IsMemoryWrite { get { return true; } }
	}
}
