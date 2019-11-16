using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Doctor : MonoBehaviour
{
    // Creates Instance of InputManager class.
    InputManager controls;

    // Stores Context of the InputSystem.
    Vector2 movementInput;

    // Used to change the position of the player.
    Vector3 movement;

    float speed;

    public void Awake() {

        speed = 7f;
        controls = new InputManager();

        // Gets the context of the InputSystem and saves it in movementInput.
        controls.PlagueDoctor.Movement.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
    }

    public void Update() {

        // Creates the movement Vector3, to change the player's position.
        movement = new Vector3(movementInput.x, 0, movementInput.y);

        // Make rats move.
        transform.position += movement * speed * Time.deltaTime;
    }

    // Enables the InputSystem for PlagueDoctor.
    private void OnEnable() {

        controls.PlagueDoctor.Enable();
    }


    // Disables the InputSystem for PlagueDoctor.
    private void OnDisable() {

        controls.PlagueDoctor.Disable();
    }
}
