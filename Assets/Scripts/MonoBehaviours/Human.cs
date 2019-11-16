﻿using UnityEngine;

public class Human : MonoBehaviour {
    public float currentratCountValue;

    public float health;

    public float infectionMeter;

    public bool isDead;

    public bool isInfected;

    public bool ratIsClose, docIsClose;

    // Start is called before the first frame update
    private void Start() {
        health = 100;
        isDead = false;
        isInfected = false;
        ratIsClose = false;
        docIsClose = false;
    }

    private void Update() {
        if (!ratIsClose && infectionMeter >= 0 && infectionMeter <= 100) {
            Debug.Log("InfectionMeter decay" + ": " + infectionMeter);
            infectionMeter -= 10 * Rats.RatCount * Time.deltaTime;
        }

        if (!docIsClose && isInfected && health >= 0) HealthDrain();

        if (health <= 0) isDead = true;

        if (isDead) gameObject.GetComponent<SphereCollider>().radius = 1;
    }

    public int Consume() {
        Destroy(gameObject);

        return 1;
    }

    public void Infect(float ratCount) {
        Debug.Log("InfectionMeter" + " : " + infectionMeter);

        if (health <= 0)

            return;

        if (infectionMeter > 100)
            return;

        infectionMeter += 10 * Time.deltaTime;

        if (infectionMeter <= 100) {
            currentratCountValue = ratCount;
            return;
        }

        isInfected = true;
    }

    public void HealthDrain() {
        health -= (5 + currentratCountValue * 0.25f) * Time.deltaTime;
        Debug.Log("Health" + " : " + health);
    }
}