using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using UnityEditor.Callbacks;

public class CircleScript : MonoBehaviour
{
    public Rigidbody2D myRidgidBody;
    private PlayerInputActions inputActions;

    void Awake()
    {
        // Initialize the input actions
        inputActions = new PlayerInputActions();
    }

    void OnEnable()
    {
        // Enable the input actions
        inputActions.Player.Enable();
    }

    void OnDisable()
    {
        // Disable when not in use
        inputActions.Player.Disable();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = inputActions.Player.Move.ReadValue<Vector2>();
        myRidgidBody.linearVelocity = moveInput * 10;
    }
}