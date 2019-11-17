using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int maxPlayTime;
    string minutes, seconds;
    public Text text;

    private void Update() {

        maxPlayTime = 600 - (int)Time.time;

        minutes = (maxPlayTime/60 < 10) ? "" + maxPlayTime / 60 : "" + maxPlayTime / 60;
        seconds = (maxPlayTime%60 < 10) ? "0" + maxPlayTime % 60 : "" + maxPlayTime % 60;

        //if (seconds == 0) {
        //    timer = minutes + " : " + seconds + "0";
        //}
        //else if (seconds < 10 && seconds > 0) {

        //    timer = minutes + " : 0" + seconds;
        //}
        //else {

        //    timer = minutes + " : " + seconds;
        //}

        text.text = minutes + " : " + seconds;

        if (maxPlayTime / 60 == 0 && maxPlayTime % 60 == 0) {

            SceneManager.LoadScene(1);
        }
    }
}
