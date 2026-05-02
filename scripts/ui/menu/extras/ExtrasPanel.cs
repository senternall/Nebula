using System;
using Godot;

public partial class ExtrasPanel : Panel
{
	ScrollContainer scrollContainer;
    VBoxContainer vBoxContainer;
    ShaderMaterial outlineMaterial;

    public override void _Ready()
	{
        scrollContainer = GetNode<ScrollContainer>("ScrollContainer");
        vBoxContainer = scrollContainer.GetNode<VBoxContainer>("VBoxContainer");
        outlineMaterial = GetNode<Panel>("Outline").Material as ShaderMaterial;
    }

    public override void _Process(double delta)
    {
        outlineMaterial.SetShaderParameter("cursor_position", GetViewport().GetMousePosition());
    }
}