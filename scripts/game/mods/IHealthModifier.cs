using Godot;
using System;

public interface IHealthModifier : IMod
{
	double ApplyHealthResult(bool hit, double health);
}
