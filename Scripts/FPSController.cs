using Godot;

public partial class FPSController : RigidBody3D
{
    // Movement variables
    [Export] public float Speed = 500.0f; // Higher value since we’re applying forces
    [Export] public float JumpImpulse = 5.0f; // Impulse for jumping
    [Export] public float MouseSensitivity = 0.2f;
    [Export] public float AirControl = 0.3f; // Reduced control in air
    [Export] public float Friction = 0.9f; // Linear damping applied manually

    // Camera variables
    private Camera3D camera;
    private float gravity = (float)ProjectSettings.GetSetting("physics/3d/default_gravity");

    // Player variables
    private RayCast3D groundRay;
    private Vector3 direction;
    private Vector2 mouseInput = Vector2.Zero;
    private float horizontalRotation = 0.0f;
    private float verticalRotation = 0.0f;
    private bool isGrounded = false;

    public override void _Ready()
    {
        // Get the camera node (assumes camera is a child node)
        camera = GetNode<Camera3D>("Camera3D");

        // Get ground check raycast
        groundRay = GetNode<RayCast3D>("GroundRay");

        // Capture the mouse
        Input.MouseMode = Input.MouseModeEnum.Captured;

        // Set RigidBody3D properties
        LinearDamp = 0.0f; // We'll handle damping manually
        AngularDamp = 0.0f;
        AxisLockAngularX = true; // Prevent tipping
        AxisLockAngularZ = true;
    }

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseMotion mouseMotion)
        {
            mouseInput = mouseMotion.Relative;
        }

        // Capture the mouse during runtime
        if (@event is InputEventMouseButton mouseButton)
        {
            if (mouseButton.IsPressed() && mouseButton.ButtonIndex == MouseButton.Left)
                Input.MouseMode = Input.MouseModeEnum.Captured;
        }
    }

    public override void _Process(double delta)
    {
        // Handle camera rotation
        HandleCameraRotation();

        Debug.Write($"{isGrounded}");
        Debug.Write($"{direction}");
    }

    public override void _PhysicsProcess(double delta)
    {
        // Handle body yaw rotation
        HandleBodyRotation();

        // Handle movement
        HandleMovement((float)delta);

        // Apply custom friction (RigidBody3D doesn’t slide naturally like CharacterBody3D)
        Vector3 velocity = LinearVelocity;
        velocity.X *= Friction;
        velocity.Z *= Friction;
        LinearVelocity = velocity;
    }

    private void HandleMovement(float delta)
    {
        // Check if grounded 
        isGrounded = groundRay.IsColliding();

        //Debug.Write($"{isGrounded}");

        // Get input direction
        Vector2 inputDir = Input.GetVector("move_left", "move_right", "move_forward", "move_backward");
        direction = (camera.GlobalTransform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();

        // Ignore camera pitch
        direction.Y = 0f;
        direction = direction.Normalized();

        // Apply movement force
        float control = isGrounded ? 1.0f : AirControl;
        if (direction != Vector3.Zero)
        {
            Vector3 force = direction * Speed * control * delta;
            ApplyCentralForce(force);
        }

        // Handle jump
        if (Input.IsActionJustPressed("jump") && isGrounded)
        {
            ApplyCentralImpulse(new Vector3(0, JumpImpulse, 0));
        }
    }

    private void HandleCameraRotation()
    {
        if (mouseInput == Vector2.Zero)
            return;

        // Horizontal rotation (yaw)
        horizontalRotation -= mouseInput.X * MouseSensitivity;

        // Vertical rotation (pitch)
        verticalRotation -= mouseInput.Y * MouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -89.0f, 89.0f);

        camera.RotationDegrees = new Vector3(
            verticalRotation,
            horizontalRotation,
            0
        );

        mouseInput = Vector2.Zero;
    }

    private void HandleBodyRotation()
    {
        if (mouseInput == Vector2.Zero)
            return;

        // Rotate the RigidBody3D for yaw to align with camera
        RotateY(Mathf.DegToRad(-mouseInput.X * MouseSensitivity));
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event.IsActionPressed("ui_cancel"))
        {
            Input.MouseMode = Input.MouseModeEnum.Visible;
        }
    }

    public override void _IntegrateForces(PhysicsDirectBodyState3D state)
    {
        // Ensure gravity is applied (RigidBody3D already has gravity, but we can reinforce it)
        state.ApplyCentralForce(new Vector3(0, -gravity * Mass, 0));
    }
}