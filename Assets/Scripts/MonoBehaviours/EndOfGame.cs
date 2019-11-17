using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGame : MonoBehaviour {
    public static EndOfGame Instance;
    private Rats _rats;
    private Timer _timer;
    public GameObject human;
    private int _livingHumans;

    private void Awake() {

        _rats = FindObjectOfType<Rats>();
        _timer = FindObjectOfType<Timer>();
        _livingHumans = human.transform.childCount;
        Instance = this;
    }

    public void HumanDied() {
        _livingHumans--;
        if (_livingHumans >= 1) return;
        RatsWin();
        ;
    }

    // Condition, that rats win.
    public void RatsWin() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        enabled = false;

        //if (livingHumans == 0) {

        //    Debug.Log("Humans Dead");
        //    return true;
        //}

        //return false;

    }

    // Condition, that the doctor wins.
    public void DocWin() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        enabled = false;
        
        //if (timer.maxPlayTime / 60 == 0 && timer.maxPlayTime % 60 == 0) {

        //    Debug.Log("Time is up");
        //    return true;
        //}

        //if (rat._ratCount != 0) return false;
        //Debug.Log("Rats dead");
        //return true;

    }
}
