using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Doctor : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    [FormerlySerializedAs("_speed")] public float speed;
    private NavMeshAgent _agent;

    private Animator _animator;

    // Used for PickUp function
    private bool _insideTrigger, _incenseCarried;
    private GameObject _incense;

    // Used for PickUp and crowMode functions.
    public Camera _docCam;
    public GameObject _crow;

    public Image _plagueDoctorImage, _crowImage;
    public Sprite _crowIcon, _greyDocIcon;

    public Text _skills;
    private string _docControls;
    private bool _controlsShown;

    public void Awake() {

        _insideTrigger = false;
        _incenseCarried = false;
        _controlsShown = false;

        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.PlagueDoctor.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();

        _controls.PlagueDoctor.PickUpObject.performed += _ => PickUp();

        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();

        _controls.PlagueDoctor.CrowMode.performed += _ => CrowMode();

        _controls.PlagueDoctor.ShowControls.performed += _ => ShowControl();
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
         var movement = Time.deltaTime * speed * new Vector3(_movementInput.x, 0, _movementInput.y);

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

        _crow.SetActive(true);
        _docCam.enabled = false;

        _crow.transform.position = new Vector3(transform.position.x, 40, transform.position.z);
        _crow.transform.rotation = Quaternion.Euler(new Vector3(80, 0, 0));

        _plagueDoctorImage.sprite = _greyDocIcon;
        _crowImage.sprite = _crowIcon;

        enabled = false;
    }

    // Enables the text field with the controls.
    private void ShowControl() {

        if (!_controlsShown) {

            _skills.text = "Skills Doctor: WASD: Walk\nQ: Crow Mode\nE: Pick Up/ Put Down Incense\nStand beside Human: Heal";
            _controlsShown = true;
        }
        else if (_controlsShown) {

            _skills.text = "Press 1 to show controls";
            _controlsShown = false;
        }
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