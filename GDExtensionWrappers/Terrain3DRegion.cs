using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3DRegion : Resource
{
    public static readonly StringName GDExtensionName = "Terrain3DRegion";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying Resource), please use the Instantiate() method instead.")]
    protected Terrain3DRegion() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3DRegion"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3DRegion Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3DRegion>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3DRegion"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3DRegion"/> wrapper type,
    /// a new instance of the <see cref="Terrain3DRegion"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3DRegion"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3DRegion Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3DRegion>(godotObject);
    }
#region Enums

    public enum MapType : long
    {
        TypeHeight = 0,
        TypeControl = 1,
        TypeColor = 2,
        TypeMax = 3,
    }

#endregion

#region Properties

    public float Version
    {
        get => (float)Get("version");
        set => Set("version", Variant.From(value));
    }

    public int RegionSize
    {
        get => (int)Get("region_size");
        set => Set("region_size", Variant.From(value));
    }

    public float VertexSpacing
    {
        get => (float)Get("vertex_spacing");
        set => Set("vertex_spacing", Variant.From(value));
    }

    public Vector2 HeightRange
    {
        get => (Vector2)Get("height_range");
        set => Set("height_range", Variant.From(value));
    }

    public Image HeightMap
    {
        get => (Image)Get("height_map");
        set => Set("height_map", Variant.From(value));
    }

    public Image ControlMap
    {
        get => (Image)Get("control_map");
        set => Set("control_map", Variant.From(value));
    }

    public Image ColorMap
    {
        get => (Image)Get("color_map");
        set => Set("color_map", Variant.From(value));
    }

    public Godot.Collections.Dictionary Instances
    {
        get => (Godot.Collections.Dictionary)Get("instances");
        set => Set("instances", Variant.From(value));
    }

    public bool Edited
    {
        get => (bool)Get("edited");
        set => Set("edited", Variant.From(value));
    }

    public bool Deleted
    {
        get => (bool)Get("deleted");
        set => Set("deleted", Variant.From(value));
    }

    public bool Modified
    {
        get => (bool)Get("modified");
        set => Set("modified", Variant.From(value));
    }

    public Vector2I Location
    {
        get => (Vector2I)Get("location");
        set => Set("location", Variant.From(value));
    }

    public Godot.Collections.Dictionary Multimeshes
    {
        get => (Godot.Collections.Dictionary)Get("multimeshes");
        set => Set("multimeshes", Variant.From(value));
    }

#endregion

#region Methods

    public void SetVersion(float version) => Call("set_version", version);

    public float GetVersion() => Call("get_version").As<float>();

    public void SetRegionSize(int regionSize) => Call("set_region_size", regionSize);

    public int GetRegionSize() => Call("get_region_size").As<int>();

    public void SetVertexSpacing(float vertexSpacing) => Call("set_vertex_spacing", vertexSpacing);

    public float GetVertexSpacing() => Call("get_vertex_spacing").As<float>();

    public void SetMap(int mapType, Image map) => Call("set_map", mapType, map);

    public Image GetMap(int mapType) => Call("get_map", mapType).As<Image>();

    public void SetMaps(Godot.Collections.Array<Image> maps) => Call("set_maps", maps);

    public Godot.Collections.Array<Image> GetMaps() => Call("get_maps").As<Godot.Collections.Array<Godot.GodotObject>>());

    public void SetHeightMap(Image map) => Call("set_height_map", map);

    public Image GetHeightMap() => Call("get_height_map").As<Image>();

    public void SetControlMap(Image map) => Call("set_control_map", map);

    public Image GetControlMap() => Call("get_control_map").As<Image>();

    public void SetColorMap(Image map) => Call("set_color_map", map);

    public Image GetColorMap() => Call("get_color_map").As<Image>();

    public void SanitizeMaps() => Call("sanitize_maps");

    public Image SanitizeMap(int mapType, Image map) => Call("sanitize_map", mapType, map).As<Image>();

    public bool ValidateMapSize(Image map) => Call("validate_map_size", map).As<bool>();

    public void SetHeightRange(Vector2 range) => Call("set_height_range", range);

    public Vector2 GetHeightRange() => Call("get_height_range").As<Vector2>();

    public void UpdateHeight(float height) => Call("update_height", height);

    public void UpdateHeights(Vector2 lowHigh) => Call("update_heights", lowHigh);

    public void CalcHeightRange() => Call("calc_height_range");

    public void SetInstances(Godot.Collections.Dictionary instances) => Call("set_instances", instances);

    public Godot.Collections.Dictionary GetInstances() => Call("get_instances").As<Godot.Collections.Dictionary>();

    public int Save(string path, bool _16Bit) => Call("save", path, _16Bit).As<int>();

    public void SetDeleted(bool deleted) => Call("set_deleted", deleted);

    public bool IsDeleted() => Call("is_deleted").As<bool>();

    public void SetEdited(bool edited) => Call("set_edited", edited);

    public bool IsEdited() => Call("is_edited").As<bool>();

    public void SetModified(bool modified) => Call("set_modified", modified);

    public bool IsModified() => Call("is_modified").As<bool>();

    public void SetLocation(Vector2I location) => Call("set_location", location);

    public Vector2I GetLocation() => Call("get_location").As<Vector2I>();

    public void SetData(Godot.Collections.Dictionary data) => Call("set_data", data);

    public Godot.Collections.Dictionary GetData() => Call("get_data").As<Godot.Collections.Dictionary>();

    public Terrain3DRegion Duplicate(bool deep) => GDExtensionHelper.Bind<Terrain3DRegion>(Call("duplicate", deep).As<GodotObject>());

    public void SetMultimeshes(Godot.Collections.Dictionary multimeshes) => Call("set_multimeshes", multimeshes);

    public Godot.Collections.Dictionary GetMultimeshes() => Call("get_multimeshes").As<Godot.Collections.Dictionary>();

#endregion

}