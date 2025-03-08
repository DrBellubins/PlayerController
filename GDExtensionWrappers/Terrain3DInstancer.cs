using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3DInstancer : GodotObject
{
    public static readonly StringName GDExtensionName = "Terrain3DInstancer";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying GodotObject), please use the Instantiate() method instead.")]
    protected Terrain3DInstancer() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3DInstancer"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3DInstancer Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3DInstancer>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3DInstancer"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3DInstancer"/> wrapper type,
    /// a new instance of the <see cref="Terrain3DInstancer"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3DInstancer"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3DInstancer Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3DInstancer>(godotObject);
    }
#region Methods

    public void ClearByMesh(int meshId) => Call("clear_by_mesh", meshId);

    public void ClearByLocation(Vector2I regionLocation, int meshId) => Call("clear_by_location", regionLocation, meshId);

    public void ClearByRegion(Terrain3DRegion region, int meshId) => Call("clear_by_region", (Resource)region, meshId);

    public void AddInstances(Vector3 globalPosition, Godot.Collections.Dictionary @params) => Call("add_instances", globalPosition, @params);

    public void RemoveInstances(Vector3 globalPosition, Godot.Collections.Dictionary @params) => Call("remove_instances", globalPosition, @params);

    public void AddMultimesh(int meshId, MultiMesh multimesh, Transform3D transform, bool update) => Call("add_multimesh", meshId, multimesh, transform, update);

    public void AddTransforms(int meshId, Godot.Collections.Array<Transform3D> transforms, Color[] colors, bool update) => Call("add_transforms", meshId, transforms, colors, update);

    public void AppendLocation(Vector2I regionLocation, int meshId, Godot.Collections.Array<Transform3D> transforms, Color[] colors, bool update) => Call("append_location", regionLocation, meshId, transforms, colors, update);

    public void AppendRegion(Terrain3DRegion region, int meshId, Godot.Collections.Array<Transform3D> transforms, Color[] colors, bool update) => Call("append_region", (Resource)region, meshId, transforms, colors, update);

    public void UpdateTransforms(Aabb aabb) => Call("update_transforms", aabb);

    public void ForceUpdateMmis() => Call("force_update_mmis");

    public void SwapIds(int srcId, int destId) => Call("swap_ids", srcId, destId);

    public void DumpData() => Call("dump_data");

    public void DumpMmis() => Call("dump_mmis");

#endregion

}