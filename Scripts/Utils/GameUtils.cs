using Godot;
using System;

public static class Utils
{
}

public static class Ginput
{
    public static bool IsUsingController = false;
    public static bool IsSteamDeck = false;

    public enum GinputAction
    {
        Pressed,
        Released
    }

    // Action map
    public static string Left      = "move_left";
    public static string Right     = "move_right";
    public static string Forward   = "move_forward";
    public static string Backward  = "move_backward";
    public static string Run       = "run";
    public static string Crouch    = "crouch";
    public static string Jump      = "jump";

    private static float Deadzone = 0.2f;

    public static float MoveLeftRight()
    {
        if (IsUsingController)
        {
            float joyX = Input.GetJoyAxis(0, JoyAxis.LeftX);

            // Apply deadzone
            if (Mathf.Abs(joyX) < Deadzone)
                return 0f;

            return joyX;
        }
        else
        {
            // Return binary keyboard input (-1, 0, 1)
            return Input.GetAxis(Left, Right);
        }
    }

    public static float MoveForwardBackward()
    {
        if (IsUsingController)
        {
            float joyY = Input.GetJoyAxis(0, JoyAxis.LeftY);

            // Apply deadzone
            if (Mathf.Abs(joyY) < Deadzone)
                return 0f;

            return joyY;
        }
        else
        {
            // Return binary keyboard input (-1, 0, 1)
            return Input.GetAxis(Forward, Backward);
        }
    }

    public static bool RunPressing => Input.IsActionPressed(Run);
    public static bool RunPressed => Input.IsActionJustPressed(Run);
    public static bool RunReleased => Input.IsActionJustReleased(Run);

    public static bool CrouchPressing => Input.IsActionPressed(Crouch);
    public static bool CrouchPressed => Input.IsActionJustPressed(Crouch);
    public static bool CrouchReleased => Input.IsActionJustReleased(Crouch);

    public static bool JumpPressing => Input.IsActionPressed(Jump);
    public static bool JumpPressed => Input.IsActionJustPressed(Jump);
    public static bool JumpReleased => Input.IsActionJustReleased(Jump);
}

public partial class GameUtils : Node
{
}
