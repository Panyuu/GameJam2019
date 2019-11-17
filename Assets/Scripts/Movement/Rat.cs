using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Rat : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    public float _speed, _dash, _currentSpeed;

    private NavMeshAgent _agent;

    private bool _controlsShown;
    public Text _skills;

    public void Awake() {

        _controlsShown = false;

        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.Rat.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
        _agent = GetComponent<NavMeshAgent>();

        _controls.Rat.Dash.started += ctx => Dash(true);
        _controls.Rat.Dash.canceled += ctx => Dash(false);

        _controls.Rat.ShowControls.performed += ctx => ShowControl();
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

    // Shows controls of rats.
    private void ShowControl() {

        if (!_controlsShown) {

            _skills.text = "Skills Rat: Arrow Keys: Walk\nSpace: Dash\nWalk through Food: eating\nStand beside Human: infect and kill";
            _controlsShown = true;
        }
        else if (_controlsShown) {

            _skills.text = "Press Strg to show controls";
            _controlsShown = false;
        }
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