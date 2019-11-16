using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    public static GameSettings GameSettings;
    [SerializeField] private GameSettings gameSettings;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else {
            if (Instance != this) {
                Destroy(this);
            }
        }

        GameSettings = gameSettings;
    }
}