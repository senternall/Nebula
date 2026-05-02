using Godot;
using System;

public partial class UserFolderButton : Button
{
	public override void _Pressed()
	{
		OS.ShellShowInFileManager(Constants.USER_FOLDER);
	}
}
