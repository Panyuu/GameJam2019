using UnityEngine;

public class Doctor : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Used to change the position of the player.
    private Vector3 _movement;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    private float _speed;

    public void Awake() {
        _speed = 7f;
        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.PlagueDoctor.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
        _movement = new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make rats move.
        transform.position += Time.deltaTime * _speed * _movement;
    }

    // Enables the InputSystem for PlagueDoctor.
    private void OnEnable() {
        _controls.PlagueDoctor.Enable();
    }


    // Disables the InputSystem for PlagueDoctor.
    private void OnDisable() {
        _controls.PlagueDoctor.Disable();
    }
}