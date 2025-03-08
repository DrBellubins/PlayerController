using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3DMaterial : Resource
{
    public static readonly StringName GDExtensionName = "Terrain3DMaterial";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying Resource), please use the Instantiate() method instead.")]
    protected Terrain3DMaterial() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3DMaterial"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3DMaterial Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3DMaterial>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3DMaterial"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3DMaterial"/> wrapper type,
    /// a new instance of the <see cref="Terrain3DMaterial"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3DMaterial"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3DMaterial Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3DMaterial>(godotObject);
    }
#region Enums

    public enum WorldBackgroundEnum : long
    {
        None = 0,
        Flat = 1,
        Noise = 2,
    }

    public enum TextureFilteringEnum : long
    {
        Linear = 0,
        Nearest = 1,
    }

#endregion

#region Properties

    public Godot.Collections.Dictionary ShaderParameters
    {
        get => (Godot.Collections.Dictionary)Get("_shader_parameters");
        set => Set("_shader_parameters", Variant.From(value));
    }

    public long /*None,Flat,Noise*/ WorldBackground
    {
        get => (long /*None,Flat,Noise*/)Get("world_background").As<Int64>();
        set => Set("world_background", Variant.From(value));
    }

    public long /*Linear,Nearest*/ TextureFiltering
    {
        get => (long /*Linear,Nearest*/)Get("texture_filtering").As<Int64>();
        set => Set("texture_filtering", Variant.From(value));
    }

    public bool AutoShader
    {
        get => (bool)Get("auto_shader");
        set => Set("auto_shader", Variant.From(value));
    }

    public bool DualScaling
    {
        get => (bool)Get("dual_scaling");
        set => Set("dual_scaling", Variant.From(value));
    }

    public bool ShaderOverrideEnabled
    {
        get => (bool)Get("shader_override_enabled");
        set => Set("shader_override_enabled", Variant.From(value));
    }

    public Shader ShaderOverride
    {
        get => (Shader)Get("shader_override");
        set => Set("shader_override", Variant.From(value));
    }

    public bool ShowCheckered
    {
        get => (bool)Get("show_checkered");
        set => Set("show_checkered", Variant.From(value));
    }

    public bool ShowGrey
    {
        get => (bool)Get("show_grey");
        set => Set("show_grey", Variant.From(value));
    }

    public bool ShowHeightmap
    {
        get => (bool)Get("show_heightmap");
        set => Set("show_heightmap", Variant.From(value));
    }

    public bool ShowColormap
    {
        get => (bool)Get("show_colormap");
        set => Set("show_colormap", Variant.From(value));
    }

    public bool ShowRoughmap
    {
        get => (bool)Get("show_roughmap");
        set => Set("show_roughmap", Variant.From(value));
    }

    public bool ShowControlTexture
    {
        get => (bool)Get("show_control_texture");
        set => Set("show_control_texture", Variant.From(value));
    }

    public bool ShowControlAngle
    {
        get => (bool)Get("show_control_angle");
        set => Set("show_control_angle", Variant.From(value));
    }

    public bool ShowControlScale
    {
        get => (bool)Get("show_control_scale");
        set => Set("show_control_scale", Variant.From(value));
    }

    public bool ShowControlBlend
    {
        get => (bool)Get("show_control_blend");
        set => Set("show_control_blend", Variant.From(value));
    }

    public bool ShowAutoshader
    {
        get => (bool)Get("show_autoshader");
        set => Set("show_autoshader", Variant.From(value));
    }

    public bool ShowNavigation
    {
        get => (bool)Get("show_navigation");
        set => Set("show_navigation", Variant.From(value));
    }

    public bool ShowTextureHeight
    {
        get => (bool)Get("show_texture_height");
        set => Set("show_texture_height", Variant.From(value));
    }

    public bool ShowTextureNormal
    {
        get => (bool)Get("show_texture_normal");
        set => Set("show_texture_normal", Variant.From(value));
    }

    public bool ShowTextureRough
    {
        get => (bool)Get("show_texture_rough");
        set => Set("show_texture_rough", Variant.From(value));
    }

    public bool ShowRegionGrid
    {
        get => (bool)Get("show_region_grid");
        set => Set("show_region_grid", Variant.From(value));
    }

    public bool ShowVertexGrid
    {
        get => (bool)Get("show_vertex_grid");
        set => Set("show_vertex_grid", Variant.From(value));
    }

    public bool ShowInstancerGrid
    {
        get => (bool)Get("show_instancer_grid");
        set => Set("show_instancer_grid", Variant.From(value));
    }

#endregion

#region Methods

    public void SetShaderParameters(Godot.Collections.Dictionary dict) => Call("_set_shader_parameters", dict);

    public Godot.Collections.Dictionary GetShaderParameters() => Call("_get_shader_parameters").As<Godot.Collections.Dictionary>();

    public void Update() => Call("update");

    public Rid GetMaterialRid() => Call("get_material_rid").As<Rid>();

    public Rid GetShaderRid() => Call("get_shader_rid").As<Rid>();

    public void SetWorldBackground(int background) => Call("set_world_background", background);

    public int GetWorldBackground() => Call("get_world_background").As<int>();

    public void SetTextureFiltering(int filtering) => Call("set_texture_filtering", filtering);

    public int GetTextureFiltering() => Call("get_texture_filtering").As<int>();

    public void SetAutoShader(bool enabled) => Call("set_auto_shader", enabled);

    public bool GetAutoShader() => Call("get_auto_shader").As<bool>();

    public void SetDualScaling(bool enabled) => Call("set_dual_scaling", enabled);

    public bool GetDualScaling() => Call("get_dual_scaling").As<bool>();

    public void EnableShaderOverride(bool enabled) => Call("enable_shader_override", enabled);

    public bool IsShaderOverrideEnabled() => Call("is_shader_override_enabled").As<bool>();

    public void SetShaderOverride(Shader shader) => Call("set_shader_override", shader);

    public Shader GetShaderOverride() => Call("get_shader_override").As<Shader>();

    public void SetShaderParam(StringName name, Variant? value) => Call("set_shader_param", name, value ?? new Variant());

    public void GetShaderParam(StringName name) => Call("get_shader_param", name);

    public void SetShowCheckered(bool enabled) => Call("set_show_checkered", enabled);

    public bool GetShowCheckered() => Call("get_show_checkered").As<bool>();

    public void SetShowGrey(bool enabled) => Call("set_show_grey", enabled);

    public bool GetShowGrey() => Call("get_show_grey").As<bool>();

    public void SetShowHeightmap(bool enabled) => Call("set_show_heightmap", enabled);

    public bool GetShowHeightmap() => Call("get_show_heightmap").As<bool>();

    public void SetShowColormap(bool enabled) => Call("set_show_colormap", enabled);

    public bool GetShowColormap() => Call("get_show_colormap").As<bool>();

    public void SetShowRoughmap(bool enabled) => Call("set_show_roughmap", enabled);

    public bool GetShowRoughmap() => Call("get_show_roughmap").As<bool>();

    public void SetShowControlTexture(bool enabled) => Call("set_show_control_texture", enabled);

    public bool GetShowControlTexture() => Call("get_show_control_texture").As<bool>();

    public void SetShowControlAngle(bool enabled) => Call("set_show_control_angle", enabled);

    public bool GetShowControlAngle() => Call("get_show_control_angle").As<bool>();

    public void SetShowControlScale(bool enabled) => Call("set_show_control_scale", enabled);

    public bool GetShowControlScale() => Call("get_show_control_scale").As<bool>();

    public void SetShowControlBlend(bool enabled) => Call("set_show_control_blend", enabled);

    public bool GetShowControlBlend() => Call("get_show_control_blend").As<bool>();

    public void SetShowAutoshader(bool enabled) => Call("set_show_autoshader", enabled);

    public bool GetShowAutoshader() => Call("get_show_autoshader").As<bool>();

    public void SetShowNavigation(bool enabled) => Call("set_show_navigation", enabled);

    public bool GetShowNavigation() => Call("get_show_navigation").As<bool>();

    public void SetShowTextureHeight(bool enabled) => Call("set_show_texture_height", enabled);

    public bool GetShowTextureHeight() => Call("get_show_texture_height").As<bool>();

    public void SetShowTextureNormal(bool enabled) => Call("set_show_texture_normal", enabled);

    public bool GetShowTextureNormal() => Call("get_show_texture_normal").As<bool>();

    public void SetShowTextureRough(bool enabled) => Call("set_show_texture_rough", enabled);

    public bool GetShowTextureRough() => Call("get_show_texture_rough").As<bool>();

    public void SetShowRegionGrid(bool enabled) => Call("set_show_region_grid", enabled);

    public bool GetShowRegionGrid() => Call("get_show_region_grid").As<bool>();

    public void SetShowVertexGrid(bool enabled) => Call("set_show_vertex_grid", enabled);

    public bool GetShowVertexGrid() => Call("get_show_vertex_grid").As<bool>();

    public void SetShowInstancerGrid(bool enabled) => Call("set_show_instancer_grid", enabled);

    public bool GetShowInstancerGrid() => Call("get_show_instancer_grid").As<bool>();

    public int Save(string path) => Call("save", path).As<int>();

#endregion

}