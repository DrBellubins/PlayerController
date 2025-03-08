using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3DStorage : Resource
{
    public static readonly StringName GDExtensionName = "Terrain3DStorage";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying Resource), please use the Instantiate() method instead.")]
    protected Terrain3DStorage() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3DStorage"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3DStorage Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3DStorage>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3DStorage"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3DStorage"/> wrapper type,
    /// a new instance of the <see cref="Terrain3DStorage"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3DStorage"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3DStorage Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3DStorage>(godotObject);
    }
#region Enums

    public enum MapType : long
    {
        TypeHeight = 0,
        TypeControl = 1,
        TypeColor = 2,
        TypeMax = 3,
    }

    public enum RegionSizeEnum : long
    {
        Size1024 = 1024,
    }

#endregion

#region Properties

    public float Version
    {
        get => (float)Get("version");
        set => Set("version", Variant.From(value));
    }

    public ENUM_UNRESOLVED RegionSize
    {
        get => (ENUM_UNRESOLVED)Get("region_size").As<Int64>();
        set => Set("region_size", Variant.From(value));
    }

    public bool Save16Bit
    {
        get => (bool)Get("save_16_bit");
        set => Set("save_16_bit", Variant.From(value));
    }

    public Vector2 HeightRange
    {
        get => (Vector2)Get("height_range");
        set => Set("height_range", Variant.From(value));
    }

    public Godot.Collections.Array<unsupported format character> RegionOffsets
    {
        get => (Godot.Collections.Array<unsupported format character>)Get("region_offsets");
        set => Set("region_offsets", Variant.From(value));
    }

    public Godot.Collections.Array<unsupported format character> HeightMaps
    {
        get => (Godot.Collections.Array<unsupported format character>)Get("height_maps");
        set => Set("height_maps", Variant.From(value));
    }

    public Godot.Collections.Array<unsupported format character> ControlMaps
    {
        get => (Godot.Collections.Array<unsupported format character>)Get("control_maps");
        set => Set("control_maps", Variant.From(value));
    }

    public Godot.Collections.Array<unsupported format character> ColorMaps
    {
        get => (Godot.Collections.Array<unsupported format character>)Get("color_maps");
        set => Set("color_maps", Variant.From(value));
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

    public void SetSave16Bit(bool enabled) => Call("set_save_16_bit", enabled);

    public bool GetSave16Bit() => Call("get_save_16_bit").As<bool>();

    public void SetHeightRange(Vector2 range) => Call("set_height_range", range);

    public Vector2 GetHeightRange() => Call("get_height_range").As<Vector2>();

    public void SetRegionSize(int size) => Call("set_region_size", size);

    public int GetRegionSize() => Call("get_region_size").As<int>();

    public void SetRegionOffsets(Godot.Collections.Array<Vector2i> offsets) => Call("set_region_offsets", offsets);

    public Godot.Collections.Array<Vector2i> GetRegionOffsets() => Call("get_region_offsets").As<Godot.Collections.Array<Godot.GodotObject>>());

    public void SetMaps(int mapType, Godot.Collections.Array<Image> maps) => Call("set_maps", mapType, maps);

    public Godot.Collections.Array<Image> GetMaps(int mapType) => Call("get_maps", mapType).As<Godot.Collections.Array<Godot.GodotObject>>());

    public void SetHeightMaps(Godot.Collections.Array<Image> maps) => Call("set_height_maps", maps);

    public Godot.Collections.Array<Image> GetHeightMaps() => Call("get_height_maps").As<Godot.Collections.Array<Godot.GodotObject>>());

    public void SetControlMaps(Godot.Collections.Array<Image> maps) => Call("set_control_maps", maps);

    public Godot.Collections.Array<Image> GetControlMaps() => Call("get_control_maps").As<Godot.Collections.Array<Godot.GodotObject>>());

    public void SetColorMaps(Godot.Collections.Array<Image> maps) => Call("set_color_maps", maps);

    public Godot.Collections.Array<Image> GetColorMaps() => Call("get_color_maps").As<Godot.Collections.Array<Godot.GodotObject>>());

    public void SetMultimeshes(Godot.Collections.Dictionary multimeshes) => Call("set_multimeshes", multimeshes);

    public Godot.Collections.Dictionary GetMultimeshes() => Call("get_multimeshes").As<Godot.Collections.Dictionary>();

#endregion

}