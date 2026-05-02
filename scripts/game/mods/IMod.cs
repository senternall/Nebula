using Godot;
using System;

/// <summary>
/// Base interface for modifiers
/// </summary>
public interface IMod
{
    /// <summary>
    /// Name of the <see cref="Mod"/>
    /// </summary>
    string Name { get; }
}
