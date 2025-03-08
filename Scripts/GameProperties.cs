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

        var terrainNode = GetParent().GetNode<Node3D>("Terrain3D");
        var terrain = Terrain3D.Bind(terrainNode);

        Game.Terrain = terrain;
        Game.Terrain.SetCamera(Game.Player.Camera);
    }

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("quit"))
            GetTree().Quit();
    }
}
