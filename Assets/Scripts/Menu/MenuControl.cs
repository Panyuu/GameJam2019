using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    private InputManager _controls;

    private void Awake() {

        _controls = new InputManager();

        _controls.Menu.Start.performed += ctx => StartGame();
        _controls.Menu.Quit.performed += ctx => QuitGame();
    }

    // Open next scene.
    private void StartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Quit Game.
    private void QuitGame() {

        Application.Quit();
    }

    private void OnEnable() {

        _controls.Enable();
    }

    private void OnDisable() {

        _controls.Disable();
    }
}
