using UnityEngine;
using UnityEngine.InputSystem;

// This script lets a player move using Unity's new Input System.
// It needs a Rigidbody2D component on the GameObject to apply movement.
// DO NOT MODIFY InputSystem_Actions.cs File
[RequireComponent(typeof(Rigidbody2D))] // This ensures Rigidbody2D is auto-added when this script is used by other game objects.

public class PlayerMovement : MonoBehaviour
{
    // This is the Rigidbody2D component on the player.
    // We’ll use it to apply physics-based movement.
    public Rigidbody2D body;

    // This is the input actions script auto-generated from the Input System.
    // It holds our input mappings (like Move).
    private InputSystem_Actions controls;

    // This Vector2 holds the current direction the player is trying to move.
    // For example: (1, 0) means right, (0, -1) means down, etc.
    private Vector2 moveInput;

    // This is the speed at which the player moves.
    // It's private so it can’t be changed directly from outside, but we’ll make a getter/setter for it.
    private float moveSpeed = 5f;

    // Getter: lets other scripts safely access the current move speed.
    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    // Setter: lets other scripts safely update the move speed.
    // We use Mathf.Max to make sure the speed never goes below 0.
    public void SetMoveSpeed(float newSpeed)
    {
        moveSpeed = Mathf.Max(0f, newSpeed); // Prevents negative speeds
    }

    // This runs once when the GameObject is loaded.
    // We use it to set up our input system and register input callbacks.
    void Awake()
    {
        // Create a new instance of our input actions.
        controls = new InputSystem_Actions();

        // When movement input is detected (like pressing a key or joystick), store the direction.
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();

        // When the input is released (e.g., key lifted), stop moving by resetting the direction to zero.
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;
    }

    // This runs whenever the GameObject is enabled (active in the scene).
    // It starts listening for input.
    void OnEnable()
    {
        controls.Enable(); // Activates the input system
    }

    // This runs when the GameObject is disabled (e.g., destroyed, deactivated, or unloaded).
    // We stop listening to input to clean up and prevent bugs.
    void OnDisable()
    {
        controls.Disable(); // Deactivates the input system
    }

    // This is called on a fixed schedule, ideal for physics.
    // It’s more consistent than Update() and won’t depend on frame rate.
    void FixedUpdate()
    {
        // This applies the movement to the player using physics.
        // moveInput is the direction, moveSpeed is how fast we want to go.
        body.linearVelocity = moveInput * moveSpeed;
    }
}
