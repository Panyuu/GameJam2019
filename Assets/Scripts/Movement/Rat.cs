using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class Rat : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;
  
    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    [FormerlySerializedAs("_speed")] public float speed;
    [FormerlySerializedAs("_dash")] public float dash;
    [FormerlySerializedAs("_currentSpeed")] public float currentSpeed;
    [FormerlySerializedAs("DashSatiation")] public float dashSatiation;
    private Rats _rats;
    private NavMeshAgent _agent;
    public void Awake() {
        _controls = new InputManager();
        _rats = GetComponent<Rats>();
        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.Rat.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
        _agent = GetComponent<NavMeshAgent>();

        _controls.Rat.Dash.started += ctx => Dash(true);
        _controls.Rat.Dash.canceled += ctx => Dash(false);
        
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
        var movement = Time.deltaTime * currentSpeed * new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make rats move.
        _agent.Move(movement);
        transform.LookAt(transform.position + movement);
    }

    public void Dash(bool isPressed) {

        currentSpeed = isPressed ? dash : speed;
        _rats.isDashing = isPressed;
        
    }

    // Enables InputSystem for the Rats.
    private void OnEnable() {
        _controls.Rat.Enable();
    }

    // Disables InputSystem for the Rats.
    private void OnDisable() {
        _controls.Rat.Disable();
    }
}