using Godot;
using System;

public partial class Hotkeys : Node
{
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("quit"))
			GetTree().Quit();
	}
}
