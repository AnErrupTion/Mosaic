// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// Switch
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class Switch : BaseIRInstruction
	{
		public Switch()
			: base(0, 0)
		{
		}

		public override FlowControl FlowControl { get { return FlowControl.Switch; } }
	}
}
