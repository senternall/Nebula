using System;
using Godot;

public partial class KeybindsManager : Node
{
	public override void _Input(InputEvent @event)
	{
		var settings = SettingsManager.Instance.Settings;

		if (@event is InputEventKey eventKey && eventKey.Pressed)
		{
			if (eventKey.Keycode == Key.F11 || (eventKey.AltPressed && (eventKey.Keycode == Key.Enter || eventKey.Keycode == Key.KpEnter)))
			{
				bool value = DisplayServer.WindowGetMode() == DisplayServer.WindowMode.Windowed;

				settings.Fullscreen.Value = value;
			}
		}
	}
}
