using System.Collections;
using UnityEngine;

public class PlagueDoctor : MonoBehaviour {

    // Timer until infection reset when health is full.
    private int _waitForNonInfection;

    private void Start() {

        _waitForNonInfection = 0;
    }

    // Triggered, when doctor approaches human.
    private void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Human")) return;
        var human = other.GetComponent<Human>();
        human.docIsClose = true;
    }


    // Triggered, while doctor stands next to human.
    private void OnTriggerStay(Collider other) {
        if (!other.CompareTag("Human")) return;
        var human = other.GetComponent<Human>();

        // If human is infected and his health is under max. the doctor regenerates the human's health.
        // When human is dead, he cannot be healed.
        if (!human.isDead && human.docIsClose && human.health < 100) {

            human.health += 10f * Time.deltaTime;
        }

        // When health is full one second delay until infection is reversed.
        else if (human.docIsClose && human.health > 100) {

            // When health is full one second delay until infection is reversed.
            else if (human.docIsClose && human.health >= 100) {

            SetWaitForNonInfection(GetWaitForNonInfection() + 1);

            // Delay.
            StartCoroutine(ResetInfectionMeter(other));

        }
    }

    // Triggered, when doctor leaves human.
    private void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Human")) return;
        var human = other.GetComponent<Human>();

        if (other.CompareTag("Human")) {
            var human = other.GetComponent<Human>();

            human.docIsClose = false;
        }
    }

    // For da delay.
    public IEnumerator ResetInfectionMeter(Collider other) {

        var human = other.GetComponent<Human>();

        Debug.Log("hi");

        yield return new WaitUntil(() => GetWaitForNonInfection() >= 60);

        setWaitForNonInfection(0);
        human.health = 100;
        human.infectionMeter = 0;
        human.isInfected = false;
    }


    // to modify the waitForNonInfection variable.
    public int GetWaitForNonInfection() {

        return _waitForNonInfection;
    }

    public void SetWaitForNonInfection(int wait) {

        _waitForNonInfection = wait;
    }
}
