using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlagueDoctor : MonoBehaviour {

    public GameObject plagueDoctor;

    // Timer until infection reset when health is full.
    int waitForNonInfection;

    private void Start() {

        waitForNonInfection = 0;
    }

    // Triggered, when doctor approaches human.
    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Human")) {

            var human = other.GetComponent<Human>();
            human.docIsClose = true;
        }
    }


    // Triggered, while doctor stands next to human.
    private void OnTriggerStay(Collider other) {

        if (other.CompareTag("Human")) {
            var human = other.GetComponent<Human>();

            // If human is infected and his health is under max. the doctor regenerates the human's health.
            // When human is dead, he cannot be healed.
            if (!human.isDead && human.docIsClose && human.health < 100) {

                human.health += 10f * Time.deltaTime;
            }

            // When health is full one second delay until infection is reversed.
            else if (human.docIsClose && human.health >= 100) {

                //Debug.Log("Hi");

                setWaitForNonInfection(getWaitForNonInfection() + 1);

                // Delay.
                StartCoroutine(resetInfectionMeter(other));

            }
        }
    }

    // Triggered, when doctor leaves human.
    private void OnTriggerExit(Collider other) {

        if (other.CompareTag("Human")) {
            var human = other.GetComponent<Human>();

            human.docIsClose = false;
            setWaitForNonInfection(0);
        }
    }

    // For da delay.
    public IEnumerator resetInfectionMeter(Collider other) {

        var human = other.GetComponent<Human>();

        Debug.Log("hi");

        yield return new WaitUntil(() => getWaitForNonInfection() >= 60);

        setWaitForNonInfection(0);
        human.health = 100;
        human.infectionMeter = 0;
        human.isInfected = false;
    }


    // to modify the waitForNonInfection variable.
    public int getWaitForNonInfection() {

        return this.waitForNonInfection;
    }

    public void setWaitForNonInfection(int wait) {

        this.waitForNonInfection = wait;
    }
}
