using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    InputManager _controls;

    private void Awake() {

        _controls = new InputManager();

        _controls.Menu.Start.performed += ctx => startGame();
        _controls.Menu.Quit.performed += ctx => quitGame();
    }

    // Open next scene.
    private void startGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Quit Game.
    private void quitGame() {

        Application.Quit();
    }

    private void OnEnable() {

        _controls.Enable();
    }

    private void OnDisable() {

        _controls.Disable();
    }
}
