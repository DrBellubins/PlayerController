using Godot;
using System;

public partial class StartupScript : Node
{
    public override void _EnterTree()
    {
        // Detect Steam Deck
        if (RenderingServer.GetRenderingDevice().GetDeviceName().Contains("RADV VANGOGH") ||
            OS.GetProcessorName().Contains("AMD CUSTOM APU 0405"))
        {
            GetWindow().Size = new Vector2I(1280, 800);
            GetWindow().Borderless = true;
            Engine.MaxFps = 60; // For stable framerate, optimizations could be made to up this
            Ginput.IsSteamDeck = true;
        }
    }
}
