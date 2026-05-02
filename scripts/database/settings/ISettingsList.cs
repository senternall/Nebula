using System.Collections.Generic;
using Godot;

public interface ISettingsList
{
	Variant DefaultValue { get; }

	Variant SelectedValue { get; set; }

	IList<Variant> Values { get; }
}
