using UnityEngine;
using UnityEngine.AI;

public class Rat : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    public float _speed, _dash, _currentSpeed;

    private NavMeshAgent _agent;

    public void Awake() {
        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.Rat.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
        _agent = GetComponent<NavMeshAgent>();

        _controls.Rat.Dash.started += ctx => Dash(true);
        _controls.Rat.Dash.canceled += ctx => Dash(false);
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
        var movement = Time.deltaTime * _currentSpeed * new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make rats move.
        _agent.Move(movement);
        transform.LookAt(transform.position + movement);
    }

    public void Dash(bool isPressed) {

        _currentSpeed = isPressed ? _dash : _speed;
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