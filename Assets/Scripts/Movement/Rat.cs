using UnityEngine;
using UnityEngine.AI;

public class Rat : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    private float _speed;

    private NavMeshAgent _agent;

    public void Awake() {
        _speed = 9f;
        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.Rat.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
        _agent = GetComponent<NavMeshAgent>();
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
        var movement = Time.deltaTime * _speed * new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make rats move.
        _agent.Move(movement);
        transform.LookAt(transform.position + movement);
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