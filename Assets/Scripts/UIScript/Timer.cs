using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int maxPlayTime = 300;
    private string _minutes, _seconds;
    public Text text;

    private void Update() {

        maxPlayTime = 300 - (int)Time.time;

        _minutes = maxPlayTime/60 < 10 ? "" + maxPlayTime / 60 : "" + maxPlayTime / 60;
        _seconds = maxPlayTime%60 < 10 ? "0" + maxPlayTime % 60 : "" + maxPlayTime % 60;

        //if (seconds == 0) {
        //    timer = minutes + " : " + seconds + "0";
        //}
        //else if (seconds < 10 && seconds > 0) {

        //    timer = minutes + " : 0" + seconds;
        //}
        //else {

        //    timer = minutes + " : " + seconds;
        //}

        text.text = _minutes + " : " + _seconds;
    }
}
