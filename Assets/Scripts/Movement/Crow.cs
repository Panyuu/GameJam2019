using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class Crow : MonoBehaviour
{
    // Creates Instance of InputManager class.
    private InputManager _controls;

    // Stores Context of the InputSystem.
    private Vector2 _movementInput;

    [FormerlySerializedAs("_speed")] public float speed;

    public Camera docCam;
    public Doctor doctor;

    public void Awake() {

        _controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        _controls.PlagueDoctor.Movement.performed += ctx => _movementInput = ctx.ReadValue<Vector2>();

        _controls.PlagueDoctor.CrowMode.performed += ctx => NormalMode();
    }

    public void Update() {
        // Creates the movement Vector3, to change the crows's position.
        var movement = new Vector3(_movementInput.x, 0, _movementInput.y);

        // Make crow move.
        transform.position += Time.deltaTime * speed * movement;
    }

    // used to disable crow mode.
    public void NormalMode() {
        docCam.enabled = true;
        doctor.enabled = true;

        gameObject.SetActive(false);
    }

    // Enables InputSystem for the PlagueDoctor (used for crow).
    private void OnEnable() {
        _controls.PlagueDoctor.Enable();
    }

    // Disables InputSystem for the PlagueDoctor (used for crow).
    private void OnDisable() {
        _controls.PlagueDoctor.Disable();
    }
}
