using Godot;
using System;

public partial class SettingsMenuButton : Button
{
	public override void _Pressed()
	{
		SettingsManager.ShowMenu(true);
	}
}
