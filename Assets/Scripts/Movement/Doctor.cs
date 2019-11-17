using UnityEngine;

public class Doctor : MonoBehaviour {
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Used to change the position of the player and the PlagueDoctorCamera.
    private Vector3 _movement, docCamPosition;

    Quaternion docCamRotation;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    private float _speed;

    // Used for PickUp and crowMode functions.
    bool insideTrigger, incenseCarried;
    
    public Camera docCam;
    public GameObject doctor, crow;
    GameObject incense;

    public void Awake() {
        _speed = 7f;

        insideTrigger = false;
        incenseCarried = false;

        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.PlagueDoctor.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();

        _controls.PlagueDoctor.PickUpObject.performed += _ => PickUp();

        _controls.PlagueDoctor.CrowMode.performed += _ => CrowMode();
    }

    public void Update() {
        // Creates the movement Vector3, to change the player's position.
        _movement = new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make rats move.
        transform.position += Time.deltaTime * _speed * _movement;
    }

    // Set insideTrigger to true, when trigger is entered and save the gameObject that you're triggered by.
    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Incense")) {

            incense = other.gameObject;

            insideTrigger = true;
            //setIncenseCollider(other);
        }
    }

    // Exit the trigger area and set the gameObject incense back to default.
    private void OnTriggerExit(Collider other) {

        if (other.CompareTag("Incense")) {

            insideTrigger = false;
            incense = null;
        }
    }

    // PickUp Function for incense.
    private void PickUp() {

        // When inside the triggerArea and not carrying incense -> pick up.
        if (insideTrigger && !incenseCarried) {

            // carry incense now
            incenseCarried = true;

            // incense object becomes child object of doctor and is lifted up from the ground.
            incense.transform.parent = doctor.transform;
            incense.transform.position = new Vector3(incense.transform.position.x, 0.5f, incense.transform.position.z);
        }
        // When Carrying incense -> put down.
        else if (incenseCarried) {

            // incense not carried anymore.
            incenseCarried = false;

            // incense object gets separated from doctor and put down to the ground again.
            incense.transform.parent = null;
            incense.transform.position = new Vector3(incense.transform.position.x, 0, incense.transform.position.z);
        }
    }

    // Used to activate crowMode.
    private void CrowMode() {

        crow.SetActive(true);
        docCam.enabled = false;

        crow.transform.position = new Vector3(doctor.transform.position.x, 40, doctor.transform.position.z);
        crow.transform.rotation = Quaternion.Euler(new Vector3(80, 0, 0));

        doctor.GetComponent<Doctor>().enabled = false;
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