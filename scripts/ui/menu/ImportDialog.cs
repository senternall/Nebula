using Godot;
using System;

public partial class ImportDialog : FileDialog
{
    public override void _Ready()
    {
        FilesSelected += (paths) => {
            MapParser.BulkImport(paths);
        };
    }
}