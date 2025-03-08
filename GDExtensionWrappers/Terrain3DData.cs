using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3DData : GodotObject
{
    public static readonly StringName GDExtensionName = "Terrain3DData";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying GodotObject), please use the Instantiate() method instead.")]
    protected Terrain3DData() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3DData"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3DData Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3DData>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3DData"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3DData"/> wrapper type,
    /// a new instance of the <see cref="Terrain3DData"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3DData"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3DData Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3DData>(godotObject);
    }
#region Enums

    public enum HeightFilter : long
    {
        Nearest = 0,
        Minimum = 1,
    }

#endregion

#region Properties

    public Godot.Collections.Array<unsupported format character> RegionLocations
    {
        get => (Godot.Collections.Array<unsupported format character>)Get("region_locations");
        set => Set("region_locations", Variant.From(value));
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

#endregion

#region Signals

    public delegate void MapsChangedHandler();

    private MapsChangedHandler _mapsChanged_backing;
    private Callable _mapsChanged_backing_callable;
    public event MapsChangedHandler MapsChanged
    {
        add
        {
            if(_mapsChanged_backing == null)
            {
                _mapsChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _mapsChanged_backing?.Invoke();
                    }
                );
                Connect("maps_changed", _mapsChanged_backing_callable);
            }
            _mapsChanged_backing += value;
        }
        remove
        {
            _mapsChanged_backing -= value;
            
            if(_mapsChanged_backing == null)
            {
                Disconnect("maps_changed", _mapsChanged_backing_callable);
                _mapsChanged_backing_callable = default;
            }
        }
    }

    public delegate void RegionMapChangedHandler();

    private RegionMapChangedHandler _regionMapChanged_backing;
    private Callable _regionMapChanged_backing_callable;
    public event RegionMapChangedHandler RegionMapChanged
    {
        add
        {
            if(_regionMapChanged_backing == null)
            {
                _regionMapChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _regionMapChanged_backing?.Invoke();
                    }
                );
                Connect("region_map_changed", _regionMapChanged_backing_callable);
            }
            _regionMapChanged_backing += value;
        }
        remove
        {
            _regionMapChanged_backing -= value;
            
            if(_regionMapChanged_backing == null)
            {
                Disconnect("region_map_changed", _regionMapChanged_backing_callable);
                _regionMapChanged_backing_callable = default;
            }
        }
    }

    public delegate void HeightMapsChangedHandler();

    private HeightMapsChangedHandler _heightMapsChanged_backing;
    private Callable _heightMapsChanged_backing_callable;
    public event HeightMapsChangedHandler HeightMapsChanged
    {
        add
        {
            if(_heightMapsChanged_backing == null)
            {
                _heightMapsChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _heightMapsChanged_backing?.Invoke();
                    }
                );
                Connect("height_maps_changed", _heightMapsChanged_backing_callable);
            }
            _heightMapsChanged_backing += value;
        }
        remove
        {
            _heightMapsChanged_backing -= value;
            
            if(_heightMapsChanged_backing == null)
            {
                Disconnect("height_maps_changed", _heightMapsChanged_backing_callable);
                _heightMapsChanged_backing_callable = default;
            }
        }
    }

    public delegate void ControlMapsChangedHandler();

    private ControlMapsChangedHandler _controlMapsChanged_backing;
    private Callable _controlMapsChanged_backing_callable;
    public event ControlMapsChangedHandler ControlMapsChanged
    {
        add
        {
            if(_controlMapsChanged_backing == null)
            {
                _controlMapsChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _controlMapsChanged_backing?.Invoke();
                    }
                );
                Connect("control_maps_changed", _controlMapsChanged_backing_callable);
            }
            _controlMapsChanged_backing += value;
        }
        remove
        {
            _controlMapsChanged_backing -= value;
            
            if(_controlMapsChanged_backing == null)
            {
                Disconnect("control_maps_changed", _controlMapsChanged_backing_callable);
                _controlMapsChanged_backing_callable = default;
            }
        }
    }

    public delegate void ColorMapsChangedHandler();

    private ColorMapsChangedHandler _colorMapsChanged_backing;
    private Callable _colorMapsChanged_backing_callable;
    public event ColorMapsChangedHandler ColorMapsChanged
    {
        add
        {
            if(_colorMapsChanged_backing == null)
            {
                _colorMapsChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _colorMapsChanged_backing?.Invoke();
                    }
                );
                Connect("color_maps_changed", _colorMapsChanged_backing_callable);
            }
            _colorMapsChanged_backing += value;
        }
        remove
        {
            _colorMapsChanged_backing -= value;
            
            if(_colorMapsChanged_backing == null)
            {
                Disconnect("color_maps_changed", _colorMapsChanged_backing_callable);
                _colorMapsChanged_backing_callable = default;
            }
        }
    }

    public delegate void MapsEditedHandler(Aabb editedArea);

    private MapsEditedHandler _mapsEdited_backing;
    private Callable _mapsEdited_backing_callable;
    public event MapsEditedHandler MapsEdited
    {
        add
        {
            if(_mapsEdited_backing == null)
            {
                _mapsEdited_backing_callable = Callable.From<Variant>(
                    (arg0_variant) =>
                    {
                        var arg0 = arg0_variant.As<Aabb>();
                        _mapsEdited_backing?.Invoke(arg0);
                    }
                );
                Connect("maps_edited", _mapsEdited_backing_callable);
            }
            _mapsEdited_backing += value;
        }
        remove
        {
            _mapsEdited_backing -= value;
            
            if(_mapsEdited_backing == null)
            {
                Disconnect("maps_edited", _mapsEdited_backing_callable);
                _mapsEdited_backing_callable = default;
            }
        }
    }

#endregion

#region Methods

    public int GetRegionCount() => Call("get_region_count").As<int>();

    public void SetRegionLocations(Godot.Collections.Array<Vector2i> regionLocations) => Call("set_region_locations", regionLocations);

    public Godot.Collections.Array<Vector2i> GetRegionLocations() => Call("get_region_locations").As<Godot.Collections.Array<Godot.GodotObject>>());

    public Godot.Collections.Array<Terrain3DRegion> GetRegionsActive(bool copy, bool deep) => GDExtensionHelper.Cast<Terrain3DRegion>(Call("get_regions_active", copy, deep).As<Godot.Collections.Array<Godot.GodotObject>>());

    public Godot.Collections.Dictionary GetRegionsAll() => Call("get_regions_all").As<Godot.Collections.Dictionary>();

    public int[] GetRegionMap() => Call("get_region_map").As<int[]>();

    public static int GetRegionMapIndex(Vector2I regionLocation) => GDExtensionHelper.Call("Terrain3DData", "get_region_map_index", regionLocation).As<int>();

    public void DoForRegions(Rect2I area, Callable callback) => Call("do_for_regions", area, callback);

    public void ChangeRegionSize(int regionSize) => Call("change_region_size", regionSize);

    public Vector2I GetRegionLocation(Vector3 globalPosition) => Call("get_region_location", globalPosition).As<Vector2I>();

    public int GetRegionId(Vector2I regionLocation) => Call("get_region_id", regionLocation).As<int>();

    public int GetRegionIdp(Vector3 globalPosition) => Call("get_region_idp", globalPosition).As<int>();

    public bool HasRegion(Vector2I regionLocation) => Call("has_region", regionLocation).As<bool>();

    public bool HasRegionp(Vector3 globalPosition) => Call("has_regionp", globalPosition).As<bool>();

    public Terrain3DRegion GetRegion(Vector2I regionLocation) => GDExtensionHelper.Bind<Terrain3DRegion>(Call("get_region", regionLocation).As<GodotObject>());

    public Terrain3DRegion GetRegionp(Vector3 globalPosition) => GDExtensionHelper.Bind<Terrain3DRegion>(Call("get_regionp", globalPosition).As<GodotObject>());

    public void SetRegionModified(Vector2I regionLocation, bool modified) => Call("set_region_modified", regionLocation, modified);

    public bool IsRegionModified(Vector2I regionLocation) => Call("is_region_modified", regionLocation).As<bool>();

    public void SetRegionDeleted(Vector2I regionLocation, bool deleted) => Call("set_region_deleted", regionLocation, deleted);

    public bool IsRegionDeleted(Vector2I regionLocation) => Call("is_region_deleted", regionLocation).As<bool>();

    public Terrain3DRegion AddRegionBlankp(Vector3 globalPosition, bool update) => GDExtensionHelper.Bind<Terrain3DRegion>(Call("add_region_blankp", globalPosition, update).As<GodotObject>());

    public Terrain3DRegion AddRegionBlank(Vector2I regionLocation, bool update) => GDExtensionHelper.Bind<Terrain3DRegion>(Call("add_region_blank", regionLocation, update).As<GodotObject>());

    public int AddRegion(Terrain3DRegion region, bool update) => Call("add_region", (Resource)region, update).As<int>();

    public void RemoveRegionp(Vector3 globalPosition, bool update) => Call("remove_regionp", globalPosition, update);

    public void RemoveRegionl(Vector2I regionLocation, bool update) => Call("remove_regionl", regionLocation, update);

    public void RemoveRegion(Terrain3DRegion region, bool update) => Call("remove_region", (Resource)region, update);

    public void SaveDirectory(string directory) => Call("save_directory", directory);

    public void SaveRegion(Vector2I directory, string regionLocation, bool _16Bit) => Call("save_region", directory, regionLocation, _16Bit);

    public void LoadDirectory(string directory) => Call("load_directory", directory);

    public void LoadRegion(Vector2I directory, string regionLocation, bool update) => Call("load_region", directory, regionLocation, update);

    public Godot.Collections.Array<Image> GetHeightMaps() => Call("get_height_maps").As<Godot.Collections.Array<Godot.GodotObject>>());

    public Godot.Collections.Array<Image> GetControlMaps() => Call("get_control_maps").As<Godot.Collections.Array<Godot.GodotObject>>());

    public Godot.Collections.Array<Image> GetColorMaps() => Call("get_color_maps").As<Godot.Collections.Array<Godot.GodotObject>>());

    public Godot.Collections.Array<Image> GetMaps(int mapType) => Call("get_maps", mapType).As<Godot.Collections.Array<Godot.GodotObject>>());

    public void ForceUpdateMaps(int mapType, bool generateMipmaps) => Call("force_update_maps", mapType, generateMipmaps);

    public Rid GetHeightMapsRid() => Call("get_height_maps_rid").As<Rid>();

    public Rid GetControlMapsRid() => Call("get_control_maps_rid").As<Rid>();

    public Rid GetColorMapsRid() => Call("get_color_maps_rid").As<Rid>();

    public void SetPixel(int mapType, Vector3 globalPosition, Color pixel) => Call("set_pixel", mapType, globalPosition, pixel);

    public Color GetPixel(int mapType, Vector3 globalPosition) => Call("get_pixel", mapType, globalPosition).As<Color>();

    public void SetHeight(Vector3 globalPosition, float height) => Call("set_height", globalPosition, height);

    public float GetHeight(Vector3 globalPosition) => Call("get_height", globalPosition).As<float>();

    public void SetColor(Vector3 globalPosition, Color color) => Call("set_color", globalPosition, color);

    public Color GetColor(Vector3 globalPosition) => Call("get_color", globalPosition).As<Color>();

    public void SetControl(Vector3 globalPosition, int control) => Call("set_control", globalPosition, control);

    public int GetControl(Vector3 globalPosition) => Call("get_control", globalPosition).As<int>();

    public void SetRoughness(Vector3 globalPosition, float roughness) => Call("set_roughness", globalPosition, roughness);

    public float GetRoughness(Vector3 globalPosition) => Call("get_roughness", globalPosition).As<float>();

    public void SetControlBaseId(Vector3 globalPosition, int textureId) => Call("set_control_base_id", globalPosition, textureId);

    public int GetControlBaseId(Vector3 globalPosition) => Call("get_control_base_id", globalPosition).As<int>();

    public void SetControlOverlayId(Vector3 globalPosition, int textureId) => Call("set_control_overlay_id", globalPosition, textureId);

    public int GetControlOverlayId(Vector3 globalPosition) => Call("get_control_overlay_id", globalPosition).As<int>();

    public void SetControlBlend(Vector3 globalPosition, float blendValue) => Call("set_control_blend", globalPosition, blendValue);

    public float GetControlBlend(Vector3 globalPosition) => Call("get_control_blend", globalPosition).As<float>();

    public void SetControlAngle(Vector3 globalPosition, float degrees) => Call("set_control_angle", globalPosition, degrees);

    public float GetControlAngle(Vector3 globalPosition) => Call("get_control_angle", globalPosition).As<float>();

    public void SetControlScale(Vector3 globalPosition, float percentageModifier) => Call("set_control_scale", globalPosition, percentageModifier);

    public float GetControlScale(Vector3 globalPosition) => Call("get_control_scale", globalPosition).As<float>();

    public void SetControlHole(Vector3 globalPosition, bool enable) => Call("set_control_hole", globalPosition, enable);

    public bool GetControlHole(Vector3 globalPosition) => Call("get_control_hole", globalPosition).As<bool>();

    public void SetControlNavigation(Vector3 globalPosition, bool enable) => Call("set_control_navigation", globalPosition, enable);

    public bool GetControlNavigation(Vector3 globalPosition) => Call("get_control_navigation", globalPosition).As<bool>();

    public void SetControlAuto(Vector3 globalPosition, bool enable) => Call("set_control_auto", globalPosition, enable);

    public bool GetControlAuto(Vector3 globalPosition) => Call("get_control_auto", globalPosition).As<bool>();

    public Vector3 GetNormal(Vector3 globalPosition) => Call("get_normal", globalPosition).As<Vector3>();

    public bool IsInSlope(Vector3 globalPosition, Vector2 slopeRange, bool invert) => Call("is_in_slope", globalPosition, slopeRange, invert).As<bool>();

    public Vector3 GetTextureId(Vector3 globalPosition) => Call("get_texture_id", globalPosition).As<Vector3>();

    public Vector3 GetMeshVertex(int lod, int filter, Vector3 globalPosition) => Call("get_mesh_vertex", lod, filter, globalPosition).As<Vector3>();

    public Vector2 GetHeightRange() => Call("get_height_range").As<Vector2>();

    public void CalcHeightRange(bool recursive) => Call("calc_height_range", recursive);

    public void ImportImages(Godot.Collections.Array<Image> images, Vector3 globalPosition, float offset, float scale) => Call("import_images", images, globalPosition, offset, scale);

    public int ExportImage(string fileName, int mapType) => Call("export_image", fileName, mapType).As<int>();

    public Image LayeredToImage(int mapType) => Call("layered_to_image", mapType).As<Image>();

#endregion

}