using GDExtension.Wrappers;
using Godot;
using System;

public static class Game
{
    public static FPSController Player;
    public static Terrain3D Terrain;
}

public partial class GameProperties : Node
{
    public override void _Ready()
    {
        Game.Player = GetParent().GetNode<FPSController>("Player");

        Game.Terrain = GetParent().GetNode<Terrain3D>("Terrain3D");
        Game.Terrain.SetCamera(Game.Player.Camera);
    }

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("quit"))
            GetTree().Quit();
    }
}
