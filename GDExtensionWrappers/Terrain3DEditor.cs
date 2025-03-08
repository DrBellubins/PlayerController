using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3DEditor : GodotObject
{
    public static readonly StringName GDExtensionName = "Terrain3DEditor";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying GodotObject), please use the Instantiate() method instead.")]
    protected Terrain3DEditor() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3DEditor"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3DEditor Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3DEditor>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3DEditor"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3DEditor"/> wrapper type,
    /// a new instance of the <see cref="Terrain3DEditor"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3DEditor"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3DEditor Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3DEditor>(godotObject);
    }
#region Enums

    public enum Operation : long
    {
        Add = 0,
        Subtract = 1,
        Replace = 2,
        Average = 3,
        Gradient = 4,
        OpMax = 5,
    }

    public enum Tool : long
    {
        Sculpt = 1,
        Height = 2,
        Texture = 3,
        Color = 4,
        Roughness = 5,
        Angle = 10,
        Scale = 11,
        Autoshader = 6,
        Holes = 7,
        Navigation = 8,
        Instancer = 9,
        Region = 0,
        Max = 12,
    }

#endregion

#region Methods

    public void SetTerrain(Terrain3D terrain) => Call("set_terrain", (Node3D)terrain);

    public Terrain3D GetTerrain() => GDExtensionHelper.Bind<Terrain3D>(Call("get_terrain").As<GodotObject>());

    public void SetBrushData(Godot.Collections.Dictionary data) => Call("set_brush_data", data);

    public void SetTool(int tool) => Call("set_tool", tool);

    public int GetTool() => Call("get_tool").As<int>();

    public void SetOperation(int operation) => Call("set_operation", operation);

    public int GetOperation() => Call("get_operation").As<int>();

    public void StartOperation(Vector3 position) => Call("start_operation", position);

    public bool IsOperating() => Call("is_operating").As<bool>();

    public void Operate(Vector3 position, float cameraDirection) => Call("operate", position, cameraDirection);

    public void BackupRegion(Terrain3DRegion region) => Call("backup_region", (Resource)region);

    public void StopOperation() => Call("stop_operation");

    public void ApplyUndo(Godot.Collections.Dictionary data) => Call("apply_undo", data);

#endregion

}