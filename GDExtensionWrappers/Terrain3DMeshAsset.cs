using System;
using Godot;

namespace GDExtension.Wrappers;

public partial class Terrain3DMeshAsset : Resource
{
    public static readonly StringName GDExtensionName = "Terrain3DMeshAsset";

    [Obsolete("Wrapper classes cannot be constructed with Ctor (it only instantiate the underlying Resource), please use the Instantiate() method instead.")]
    protected Terrain3DMeshAsset() { }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="Terrain3DMeshAsset"/> type, and attaches the wrapper script to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension type.</returns>
    public static Terrain3DMeshAsset Instantiate()
    {
        return GDExtensionHelper.Instantiate<Terrain3DMeshAsset>(GDExtensionName);
    }

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="Terrain3DMeshAsset"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="Terrain3DMeshAsset"/> wrapper type,
    /// a new instance of the <see cref="Terrain3DMeshAsset"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="Terrain3DMeshAsset"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public static Terrain3DMeshAsset Bind(GodotObject godotObject)
    {
        return GDExtensionHelper.Bind<Terrain3DMeshAsset>(godotObject);
    }
#region Enums

    public enum GenType : long
    {
        TypeNone = 0,
        TypeTextureCard = 1,
        TypeMax = 2,
    }

#endregion

#region Properties

    public string Name
    {
        get => (string)Get("name");
        set => Set("name", Variant.From(value));
    }

    public int Id
    {
        get => (int)Get("id");
        set => Set("id", Variant.From(value));
    }

    public float HeightOffset
    {
        get => (float)Get("height_offset");
        set => Set("height_offset", Variant.From(value));
    }

    public float Density
    {
        get => (float)Get("density");
        set => Set("density", Variant.From(value));
    }

    public float VisibilityRange
    {
        get => (float)Get("visibility_range");
        set => Set("visibility_range", Variant.From(value));
    }

    public long /*Off,On,Double-Sided,ShadowsOnly*/ CastShadows
    {
        get => (long /*Off,On,Double-Sided,ShadowsOnly*/)Get("cast_shadows").As<Int64>();
        set => Set("cast_shadows", Variant.From(value));
    }

    public PackedScene SceneFile
    {
        get => (PackedScene)Get("scene_file");
        set => Set("scene_file", Variant.From(value));
    }

    public BaseMaterial3D,ShaderMaterial MaterialOverride
    {
        get => (BaseMaterial3D,ShaderMaterial)Get("material_override");
        set => Set("material_override", Variant.From(value));
    }

    public long /*None,TextureCard*/ GeneratedType
    {
        get => (long /*None,TextureCard*/)Get("generated_type").As<Int64>();
        set => Set("generated_type", Variant.From(value));
    }

    public int GeneratedFaces
    {
        get => (int)Get("generated_faces");
        set => Set("generated_faces", Variant.From(value));
    }

    public Vector2 GeneratedSize
    {
        get => (Vector2)Get("generated_size");
        set => Set("generated_size", Variant.From(value));
    }

#endregion

#region Signals

    public delegate void IdChangedHandler();

    private IdChangedHandler _idChanged_backing;
    private Callable _idChanged_backing_callable;
    public event IdChangedHandler IdChanged
    {
        add
        {
            if(_idChanged_backing == null)
            {
                _idChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _idChanged_backing?.Invoke();
                    }
                );
                Connect("id_changed", _idChanged_backing_callable);
            }
            _idChanged_backing += value;
        }
        remove
        {
            _idChanged_backing -= value;
            
            if(_idChanged_backing == null)
            {
                Disconnect("id_changed", _idChanged_backing_callable);
                _idChanged_backing_callable = default;
            }
        }
    }

    public delegate void FileChangedHandler();

    private FileChangedHandler _fileChanged_backing;
    private Callable _fileChanged_backing_callable;
    public event FileChangedHandler FileChanged
    {
        add
        {
            if(_fileChanged_backing == null)
            {
                _fileChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _fileChanged_backing?.Invoke();
                    }
                );
                Connect("file_changed", _fileChanged_backing_callable);
            }
            _fileChanged_backing += value;
        }
        remove
        {
            _fileChanged_backing -= value;
            
            if(_fileChanged_backing == null)
            {
                Disconnect("file_changed", _fileChanged_backing_callable);
                _fileChanged_backing_callable = default;
            }
        }
    }

    public delegate void SettingChangedHandler();

    private SettingChangedHandler _settingChanged_backing;
    private Callable _settingChanged_backing_callable;
    public event SettingChangedHandler SettingChanged
    {
        add
        {
            if(_settingChanged_backing == null)
            {
                _settingChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _settingChanged_backing?.Invoke();
                    }
                );
                Connect("setting_changed", _settingChanged_backing_callable);
            }
            _settingChanged_backing += value;
        }
        remove
        {
            _settingChanged_backing -= value;
            
            if(_settingChanged_backing == null)
            {
                Disconnect("setting_changed", _settingChanged_backing_callable);
                _settingChanged_backing_callable = default;
            }
        }
    }

    public delegate void InstancerSettingChangedHandler();

    private InstancerSettingChangedHandler _instancerSettingChanged_backing;
    private Callable _instancerSettingChanged_backing_callable;
    public event InstancerSettingChangedHandler InstancerSettingChanged
    {
        add
        {
            if(_instancerSettingChanged_backing == null)
            {
                _instancerSettingChanged_backing_callable = Callable.From(
                    () =>
                    {
                        _instancerSettingChanged_backing?.Invoke();
                    }
                );
                Connect("instancer_setting_changed", _instancerSettingChanged_backing_callable);
            }
            _instancerSettingChanged_backing += value;
        }
        remove
        {
            _instancerSettingChanged_backing -= value;
            
            if(_instancerSettingChanged_backing == null)
            {
                Disconnect("instancer_setting_changed", _instancerSettingChanged_backing_callable);
                _instancerSettingChanged_backing_callable = default;
            }
        }
    }

#endregion

#region Methods

    public void Clear() => Call("clear");

    public void SetName(string name) => Call("set_name", name);

    public string GetName() => Call("get_name").As<string>();

    public void SetId(int id) => Call("set_id", id);

    public int GetId() => Call("get_id").As<int>();

    public void SetHeightOffset(float offset) => Call("set_height_offset", offset);

    public float GetHeightOffset() => Call("get_height_offset").As<float>();

    public void SetDensity(float density) => Call("set_density", density);

    public float GetDensity() => Call("get_density").As<float>();

    public void SetVisibilityRange(float distance) => Call("set_visibility_range", distance);

    public float GetVisibilityRange() => Call("get_visibility_range").As<float>();

    public void SetCastShadows(int mode) => Call("set_cast_shadows", mode);

    public int GetCastShadows() => Call("get_cast_shadows").As<int>();

    public void SetSceneFile(PackedScene sceneFile) => Call("set_scene_file", sceneFile);

    public PackedScene GetSceneFile() => Call("get_scene_file").As<PackedScene>();

    public void SetMaterialOverride(Material material) => Call("set_material_override", material);

    public Material GetMaterialOverride() => Call("get_material_override").As<Material>();

    public void SetGeneratedType(int type) => Call("set_generated_type", type);

    public int GetGeneratedType() => Call("get_generated_type").As<int>();

    public void SetGeneratedFaces(int count) => Call("set_generated_faces", count);

    public int GetGeneratedFaces() => Call("get_generated_faces").As<int>();

    public void SetGeneratedSize(Vector2 size) => Call("set_generated_size", size);

    public Vector2 GetGeneratedSize() => Call("get_generated_size").As<Vector2>();

    public Mesh GetMesh(int index) => Call("get_mesh", index).As<Mesh>();

    public int GetMeshCount() => Call("get_mesh_count").As<int>();

    public Texture2D GetThumbnail() => Call("get_thumbnail").As<Texture2D>();

#endregion

}