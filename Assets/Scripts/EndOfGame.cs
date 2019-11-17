using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGame : MonoBehaviour
{
    private Rats rat;
    private Timer timer;
    public GameObject human;
    private int livingHumans;

    private void Awake() {

        rat = new Rats();
        timer = new Timer();
        livingHumans = human.transform.childCount;
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

            livingHumans = human.transform.childCount;
        }
    }

    // Condition, that rats win.
    private bool RatsWin() {

        //return livingHumans == 0 ? true : false;
        
        if (livingHumans == 0) {

            Debug.Log("Humans Dead");
            return true;
        }

        return false;

    }

    // Condition, that the doctor wins.
    private bool DocWin() {

        //return ((timer.maxPlayTime / 60) == 0 && (timer.maxPlayTime % 60) == 0 || rat.ratCount == 0) ? true : false; 
        
        if (timer.maxPlayTime / 60 == 0 && timer.maxPlayTime % 60 == 0) {

            Debug.Log("Time is up");
            return true;
        }

        if (rat._ratCount != 0) return false;
        Debug.Log("Rats dead");
        return true;

    }
}
