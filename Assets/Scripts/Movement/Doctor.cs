using UnityEngine;
using UnityEngine.AI;

public class Doctor : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    private float _speed;
    private NavMeshAgent _agent;

    private Animator _animator;

    // Used for PickUp function
    private bool _insideTrigger, _incenseCarried;
    private GameObject _incense;

    // Used for PickUp and crowMode functions.
    public Camera docCam;
    public GameObject crow;

    public void Awake() {
        _speed = 7f;

        _insideTrigger = false;
        _incenseCarried = false;

        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.PlagueDoctor.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();

        _controls.PlagueDoctor.PickUpObject.performed += _ => PickUp();

        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();

        _controls.PlagueDoctor.CrowMode.performed += _ => CrowMode();
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
         var movement = Time.deltaTime * _speed * new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make rats move.
        _agent.Move(movement);
        transform.LookAt(transform.position + movement);

            _animator.SetBool("Walking", movement != Vector3.zero);

    }

    // Set insideTrigger to true, when trigger is entered and save the gameObject that you're triggered by.
    private void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Incense")) return;
        _incense = other.gameObject;

        _insideTrigger = true;
        //setIncenseCollider(other);
    }

    // Exit the trigger area and set the gameObject incense back to default.
    private void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Incense")) return;
        _insideTrigger = false;
        _incense = null;
    }

    // PickUp Function for incense.
    private void PickUp() {

        // When inside the triggerArea and not carrying incense -> pick up.
        if (_insideTrigger && !_incenseCarried) {

            // carry incense now
            _incenseCarried = true;

            // incense object becomes child object of doctor and is lifted up from the ground.
            _incense.transform.parent = transform;
            var position = _incense.transform.position;
            position = new Vector3(position.x, 0.5f, position.z);
            _incense.transform.position = position;
        }
        // When Carrying incense -> put down.
        else if (_incenseCarried) {

            // incense not carried anymore.
            _incenseCarried = false;

            // incense object gets separated from doctor and put down to the ground again.
            _incense.transform.parent = null;
            var position = _incense.transform.position;
            position = new Vector3(position.x, 0, position.z);
            _incense.transform.position = position;
        }
    }

    // Used to activate crowMode.
    private void CrowMode() {

        crow.SetActive(true);
        docCam.enabled = false;

        crow.transform.position = new Vector3(transform.position.x, 40, transform.position.z);
        crow.transform.rotation = Quaternion.Euler(new Vector3(80, 0, 0));

        enabled = false;
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