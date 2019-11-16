using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rat : MonoBehaviour
{
    // Creates Instance of InputManager class.
    InputManager controls;

    // Stores Context of the InputSystem.
    Vector2 movementInput;

    // Used to change the position of the player.
    Vector3 movement;

    float speed;

    public void Awake() {

        speed = 9f;
        controls = new InputManager();
        
        // Gets the context of the InputSystem and saves it in movementInput.
        controls.Rat.Movement.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
    }

    public void Update() {

        // Creates the movement Vector3, to change the player's position.
        movement = new Vector3(movementInput.x, 0, movementInput.y);

        // Make rats move.
        transform.position += movement * speed * Time.deltaTime;
    }

    // Enables InputSystem for the Rats.
    private void OnEnable() {

        controls.Rat.Enable();

    }

    // Disables InputSystem for the Rats.
    private void OnDisable() {

        controls.Rat.Disable();
    }
}
