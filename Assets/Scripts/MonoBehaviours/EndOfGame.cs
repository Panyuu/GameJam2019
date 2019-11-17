using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGame : MonoBehaviour
{
    private Rats _rats;
    private Timer _timer;
    public GameObject human;
    private int _livingHumans;

    private void Awake() {

        _rats = FindObjectOfType<Rats>();
        _timer = FindObjectOfType<Timer>();
        _livingHumans = human.transform.childCount;
    }

    private void Update() {

        if (RatsWin()) {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            enabled = false;
        }
        else if (DocWin()) {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            enabled = false;
        }
        else {

            _livingHumans = human.transform.childCount;
        }
    }

    // Condition, that rats win.
    private bool RatsWin() {

        return _livingHumans == 0;
        
        //if (livingHumans == 0) {

        //    Debug.Log("Humans Dead");
        //    return true;
        //}

        //return false;

    }

    // Condition, that the doctor wins.
    private bool DocWin() {

        return _timer.maxPlayTime / 60 == 0 && _timer.maxPlayTime % 60 == 0 || _rats.ratCount == 0; 
        
        //if (timer.maxPlayTime / 60 == 0 && timer.maxPlayTime % 60 == 0) {

        //    Debug.Log("Time is up");
        //    return true;
        //}

        //if (rat._ratCount != 0) return false;
        //Debug.Log("Rats dead");
        //return true;

    }
}
