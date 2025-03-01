using Godot;

public partial class FPSController : RigidBody3D
{
    // Movement variables
    [Export] public float Speed = 500.0f;           // Higher value since we’re applying forces
    [Export] public float JumpImpulse = 5.0f;       // Impulse for jumping
    [Export] public float RunSpeedMult = 1.5f;      // Speed increase when running
    [Export] public float CrouchSpeedMult = 0.5f;   // Speed reduction when crouching
    [Export] public float MouseSensitivity = 0.2f;  // Mouse sensitivity multiplier
    [Export] public float PlayerHeight = 2f;        // How high the player is
    [Export] public float CrouchHeight = 0.5f;      // How low the crouch height is
    [Export] public float AirControl = 0.3f;        // Reduced control in air
    [Export] public float Friction = 0.9f;          // Linear damping applied manually

    // Camera variables
    private Camera3D camera;
    private float gravity = (float)ProjectSettings.GetSetting("physics/3d/default_gravity");

    // Player variables
    private RayCast3D groundRay;
    private CollisionShape3D collider;
    private Vector3 direction;
    private Vector2 mouseInput = Vector2.Zero;
    private float horizontalRotation = 0.0f;
    private float verticalRotation = 0.0f;
    
    private bool isGrounded = false;
    private bool isRunning = false;
    private bool isCrouched = false;

    public override void _Ready()
    {
        // Get the camera node (assumes camera is a child node)
        camera = GetNode<Camera3D>("Camera");

        // Get ground check raycast
        groundRay = GetNode<RayCast3D>("GroundRay");

        // Get the player collider
        collider = GetNode<CollisionShape3D>("Collider");

        // Capture the mouse
        Input.MouseMode = Input.MouseModeEnum.Captured;
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

        // Handle crounching
        HandleCrouching((float)delta);

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

        // Get input direction
        Vector2 inputDir = Input.GetVector("move_left", "move_right", "move_forward", "move_backward");
        direction = (camera.GlobalTransform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();

        // Ignore camera pitch
        direction.Y = 0f;
        direction = direction.Normalized();

        // Apply crouch speed modifier when crouching
        float crouchModifier = isCrouched ? CrouchSpeedMult : 1.0f;

        // Handle running
        isRunning = Input.IsActionPressed("run");
        float runModifier = isRunning ? RunSpeedMult : 1.0f;

        // Apply movement force
        float control = isGrounded ? 1.0f : AirControl;

        if (direction != Vector3.Zero)
        {
            Vector3 force = direction * Speed * runModifier * crouchModifier * control * delta;
            ApplyCentralForce(force);
        }

        // Handle jump
        if (Input.IsActionJustPressed("jump") && isGrounded)
        {
            // Apply impulse is borked... so we do this instead
            LinearVelocity = new Vector3(LinearVelocity.X, LinearVelocity.Y + JumpImpulse, LinearVelocity.Z);
        }
    }

    private void HandleCrouching(float delta)
    {
        // Toggle crouch state
        if (Input.IsActionJustPressed("crouch") && isGrounded)
            isCrouched = true;

        if (Input.IsActionJustReleased("crouch"))
        {
            ((CapsuleShape3D)collider.Shape).Radius = 0.5f;
            isCrouched = false;
        }
        
        // Smoothly adjust collider height
        float targetHeight = isCrouched ? CrouchHeight : PlayerHeight;
        ((CapsuleShape3D)collider.Shape).Height = Mathf.Lerp(((CapsuleShape3D)collider.Shape).Height, targetHeight, 10f * delta);

        // Adjust collision shape position to keep feet grounded
        float heightDifference = (PlayerHeight - ((CapsuleShape3D)collider.Shape).Height) / 2f;
        Vector3 targetPosition = new Vector3(0, heightDifference, 0);

        if (!isCrouched)
            Position -= targetPosition;

        // Adjust camera position
        float cameraTargetY = isCrouched ? CrouchHeight : PlayerHeight;
        Vector3 cameraPos = camera.Position;
        cameraPos.Y = Mathf.Lerp(cameraPos.Y, cameraTargetY, 10f * delta);
        camera.Position = cameraPos;
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
            Input.MouseMode = Input.MouseModeEnum.Visible;
    }
}