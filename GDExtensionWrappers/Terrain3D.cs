using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3D : Node3D
{
    public static readonly StringName GDExtensionName = "Terrain3D";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying Node3D), please use the Instantiate() method instead.")]
    protected Terrain3D() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3D"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3D Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3D>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3D"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3D"/> wrapper type,
    /// a new instance of the <see cref="Terrain3D"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3D"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3D Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3D>(godotObject);
    }
#region Enums

    public enum RegionSizeEnum : long
    {
        Size64 = 64,
        Size128 = 128,
        Size256 = 256,
        Size512 = 512,
        Size1024 = 1024,
        Size2048 = 2048,
    }

    public enum CollisionModeEnum : long
    {
        FullGame = 0,
        FullEditor = 1,
    }

#endregion

#region Properties

    public string Version
    {
        get => (string)Get("version");
        set => Set("version", Variant.From(value));
    }

    public ENUM_UNRESOLVED DebugLevel
    {
        get => (ENUM_UNRESOLVED)Get("debug_level").As<Int64>();
        set => Set("debug_level", Variant.From(value));
    }

    public string DataDirectory
    {
        get => (string)Get("data_directory");
        set => Set("data_directory", Variant.From(value));
    }

    public Terrain3DData Data
    {
        get => (Terrain3DData)Get("data");
        set => Set("data", Variant.From(value));
    }

    public Terrain3DMaterial Material
    {
        get => (Terrain3DMaterial)Get("material");
        set => Set("material", Variant.From(value));
    }

    public Terrain3DAssets Assets
    {
        get => (Terrain3DAssets)Get("assets");
        set => Set("assets", Variant.From(value));
    }

    public Terrain3DInstancer Instancer
    {
        get => (Terrain3DInstancer)Get("instancer");
        set => Set("instancer", Variant.From(value));
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

    public float LabelDistance
    {
        get => (float)Get("label_distance");
        set => Set("label_distance", Variant.From(value));
    }

    public int LabelSize
    {
        get => (int)Get("label_size");
        set => Set("label_size", Variant.From(value));
    }

    public bool ShowGrid
    {
        get => (bool)Get("show_grid");
        set => Set("show_grid", Variant.From(value));
    }

    public bool CollisionEnabled
    {
        get => (bool)Get("collision_enabled");
        set => Set("collision_enabled", Variant.From(value));
    }

    public CollisionModeEnum CollisionMode
    {
        get => (CollisionModeEnum)Get("collision_mode").As<Int64>();
        set => Set("collision_mode", Variant.From(value));
    }

    public int CollisionLayer
    {
        get => (int)Get("collision_layer");
        set => Set("collision_layer", Variant.From(value));
    }

    public int CollisionMask
    {
        get => (int)Get("collision_mask");
        set => Set("collision_mask", Variant.From(value));
    }

    public float CollisionPriority
    {
        get => (float)Get("collision_priority");
        set => Set("collision_priority", Variant.From(value));
    }

    public int MeshLods
    {
        get => (int)Get("mesh_lods");
        set => Set("mesh_lods", Variant.From(value));
    }

    public int MeshSize
    {
        get => (int)Get("mesh_size");
        set => Set("mesh_size", Variant.From(value));
    }

    public float VertexSpacing
    {
        get => (float)Get("vertex_spacing");
        set => Set("vertex_spacing", Variant.From(value));
    }

    public int RenderLayers
    {
        get => (int)Get("render_layers");
        set => Set("render_layers", Variant.From(value));
    }

    public int MouseLayer
    {
        get => (int)Get("mouse_layer");
        set => Set("mouse_layer", Variant.From(value));
    }

    public long /*Off,On,Double-Sided,ShadowsOnly*/ CastShadows
    {
        get => (long /*Off,On,Double-Sided,ShadowsOnly*/)Get("cast_shadows").As<Int64>();
        set => Set("cast_shadows", Variant.From(value));
    }

    public long /*Disabled,Static,Dynamic*/ GiMode
    {
        get => (long /*Disabled,Static,Dynamic*/)Get("gi_mode").As<Int64>();
        set => Set("gi_mode", Variant.From(value));
    }

    public float CullMargin
    {
        get => (float)Get("cull_margin");
        set => Set("cull_margin", Variant.From(value));
    }

    public Terrain3DTextureList TextureList
    {
        get => (Terrain3DTextureList)Get("texture_list");
        set => Set("texture_list", Variant.From(value));
    }

    public Terrain3DStorage Storage
    {
        get => (Terrain3DStorage)Get("storage");
        set => Set("storage", Variant.From(value));
    }

#endregion

#region Signals

    public delegate void MaterialChangedHandler();

    private MaterialChangedHandler _materialChanged_backing;
    private Callable _materialChanged_backing_callable;
    public event MaterialChangedHandler MaterialChanged
    {
        add
        {
            if(_materialChanged_backing == null)
            {
                _materialChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _materialChanged_backing?.Invoke();
                    }
                );
                Connect("material_changed", _materialChanged_backing_callable);
            }
            _materialChanged_backing += value;
        }
        remove
        {
            _materialChanged_backing -= value;
            
            if(_materialChanged_backing == null)
            {
                Disconnect("material_changed", _materialChanged_backing_callable);
                _materialChanged_backing_callable = default;
            }
        }
    }

    public delegate void AssetsChangedHandler();

    private AssetsChangedHandler _assetsChanged_backing;
    private Callable _assetsChanged_backing_callable;
    public event AssetsChangedHandler AssetsChanged
    {
        add
        {
            if(_assetsChanged_backing == null)
            {
                _assetsChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _assetsChanged_backing?.Invoke();
                    }
                );
                Connect("assets_changed", _assetsChanged_backing_callable);
            }
            _assetsChanged_backing += value;
        }
        remove
        {
            _assetsChanged_backing -= value;
            
            if(_assetsChanged_backing == null)
            {
                Disconnect("assets_changed", _assetsChanged_backing_callable);
                _assetsChanged_backing_callable = default;
            }
        }
    }

#endregion

#region Methods

    public string GetVersion() => Call("get_version").As<string>();

    public void SetDebugLevel(int level) => Call("set_debug_level", level);

    public int GetDebugLevel() => Call("get_debug_level").As<int>();

    public void SetDataDirectory(string directory) => Call("set_data_directory", directory);

    public string GetDataDirectory() => Call("get_data_directory").As<string>();

    public Terrain3DData GetData() => GDExtensionHelper.Bind<Terrain3DData>(Call("get_data").As<GodotObject>());

    public void SetMaterial(Terrain3DMaterial material) => Call("set_material", (Resource)material);

    public Terrain3DMaterial GetMaterial() => GDExtensionHelper.Bind<Terrain3DMaterial>(Call("get_material").As<GodotObject>());

    public void SetAssets(Terrain3DAssets assets) => Call("set_assets", (Resource)assets);

    public Terrain3DAssets GetAssets() => GDExtensionHelper.Bind<Terrain3DAssets>(Call("get_assets").As<GodotObject>());

    public Terrain3DInstancer GetInstancer() => GDExtensionHelper.Bind<Terrain3DInstancer>(Call("get_instancer").As<GodotObject>());

    public void SetEditor(Terrain3DEditor editor) => Call("set_editor", (GodotObject)editor);

    public Terrain3DEditor GetEditor() => GDExtensionHelper.Bind<Terrain3DEditor>(Call("get_editor").As<GodotObject>());

    public void SetPlugin(EditorPlugin plugin) => Call("set_plugin", plugin);

    public EditorPlugin GetPlugin() => Call("get_plugin").As<EditorPlugin>();

    public void SetCamera(Camera3D camera) => Call("set_camera", camera);

    public Camera3D GetCamera() => Call("get_camera").As<Camera3D>();

    public void ChangeRegionSize(int size) => Call("change_region_size", size);

    public int GetRegionSize() => Call("get_region_size").As<int>();

    public void SetSave16Bit(bool enabled) => Call("set_save_16_bit", enabled);

    public bool GetSave16Bit() => Call("get_save_16_bit").As<bool>();

    public void SetLabelDistance(float distance) => Call("set_label_distance", distance);

    public float GetLabelDistance() => Call("get_label_distance").As<float>();

    public void SetLabelSize(int size) => Call("set_label_size", size);

    public int GetLabelSize() => Call("get_label_size").As<int>();

    public void SetShowGrid(bool enabled) => Call("set_show_grid", enabled);

    public bool GetShowGrid() => Call("get_show_grid").As<bool>();

    public void SetCollisionEnabled(bool enabled) => Call("set_collision_enabled", enabled);

    public bool GetCollisionEnabled() => Call("get_collision_enabled").As<bool>();

    public void SetCollisionMode(int mode) => Call("set_collision_mode", mode);

    public int GetCollisionMode() => Call("get_collision_mode").As<int>();

    public void SetCollisionLayer(int layers) => Call("set_collision_layer", layers);

    public int GetCollisionLayer() => Call("get_collision_layer").As<int>();

    public void SetCollisionMask(int mask) => Call("set_collision_mask", mask);

    public int GetCollisionMask() => Call("get_collision_mask").As<int>();

    public void SetCollisionPriority(float priority) => Call("set_collision_priority", priority);

    public float GetCollisionPriority() => Call("get_collision_priority").As<float>();

    public Rid GetCollisionRid() => Call("get_collision_rid").As<Rid>();

    public void SetMeshLods(int count) => Call("set_mesh_lods", count);

    public int GetMeshLods() => Call("get_mesh_lods").As<int>();

    public void SetMeshSize(int size) => Call("set_mesh_size", size);

    public int GetMeshSize() => Call("get_mesh_size").As<int>();

    public void SetVertexSpacing(float scale) => Call("set_vertex_spacing", scale);

    public float GetVertexSpacing() => Call("get_vertex_spacing").As<float>();

    public void SetRenderLayers(int layers) => Call("set_render_layers", layers);

    public int GetRenderLayers() => Call("get_render_layers").As<int>();

    public void SetMouseLayer(int layer) => Call("set_mouse_layer", layer);

    public int GetMouseLayer() => Call("get_mouse_layer").As<int>();

    public void SetCastShadows(int shadowCastingSetting) => Call("set_cast_shadows", shadowCastingSetting);

    public int GetCastShadows() => Call("get_cast_shadows").As<int>();

    public void SetGiMode(int giMode) => Call("set_gi_mode", giMode);

    public int GetGiMode() => Call("get_gi_mode").As<int>();

    public void SetCullMargin(float margin) => Call("set_cull_margin", margin);

    public float GetCullMargin() => Call("get_cull_margin").As<float>();

    public bool IsCompatibilityMode() => Call("is_compatibility_mode").As<bool>();

    public Vector3 GetIntersection(Vector3 srcPos, Vector3 direction) => Call("get_intersection", srcPos, direction).As<Vector3>();

    public Mesh BakeMesh(int lod, int filter) => Call("bake_mesh", lod, filter).As<Mesh>();

    public Vector3[] GenerateNavMeshSourceGeometry(Aabb globalAabb, bool requireNav) => Call("generate_nav_mesh_source_geometry", globalAabb, requireNav).As<Vector3[]>();

    public void SetTextureList(Terrain3DTextureList textureList) => Call("set_texture_list", (Resource)textureList);

    public Terrain3DTextureList GetTextureList() => GDExtensionHelper.Bind<Terrain3DTextureList>(Call("get_texture_list").As<GodotObject>());

    public void SetStorage(Terrain3DStorage storage) => Call("set_storage", (Resource)storage);

    public Terrain3DStorage GetStorage() => GDExtensionHelper.Bind<Terrain3DStorage>(Call("get_storage").As<GodotObject>());

    public void SplitStorage() => Call("split_storage");

#endregion

}