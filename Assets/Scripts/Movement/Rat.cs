using UnityEngine;

public class Rat : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    private float _speed;

    public void Awake() {
        _speed = 9f;
        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.Rat.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
        var movement = new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make rats move.
        transform.position += Time.deltaTime * _speed * movement;
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