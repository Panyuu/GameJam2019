using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
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

    private bool _controlsShown;
    [FormerlySerializedAs("_skills")] public Text skills;

    public void Awake() {

        _controlsShown = false;

        _controls = new InputManager();
        _rats = GetComponent<Rats>();
        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.Rat.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();
        _agent = GetComponent<NavMeshAgent>();

        _controls.Rat.Dash.started += ctx => Dash(true);
        _controls.Rat.Dash.canceled += ctx => Dash(false);

        _controls.Rat.ShowControls.performed += ctx => ShowControl();
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

    // Shows controls of rats.
    private void ShowControl() {

        if (!_controlsShown) {

            skills.text = "Skills Rat: Arrow Keys: Walk\nSpace: Dash\nWalk through Food: eating\nStand beside Human: infect and kill";
            _controlsShown = true;
        }
        else if (_controlsShown) {

            skills.text = "Press Strg to show controls";
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