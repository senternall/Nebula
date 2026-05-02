using System;

public class NoFailMod : Mod, IFailModifier
{
	public override string Name => "No Fail";

	public bool IsFail => false;

	public bool CheckFailCondition(bool _hit, double _health) => false;
}
