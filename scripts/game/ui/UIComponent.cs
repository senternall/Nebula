using Godot;
using System;

public abstract partial class UIComponent : Node3D
{
	public abstract void Process(double delta, Attempt state);

	public abstract void ApplySettings(SettingsProfile settings);
}
