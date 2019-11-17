using System.Collections.Generic;
using UnityEngine;

public class Rats : MonoBehaviour {
    private float _hunger;

    private List<Rat> _ratObjectList = new List<Rat>();

    public int ratCount;

    public GameObject ratPrefab;

    // Update is called once per frame
    private void Start() {
        RatFollow.Mainrat = transform;
        _hunger = 50;
        ratCount = 1;

        for (var i = 0; i < 100; i++) {
            Instantiate(ratPrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerStay(Collider other) {
        var human = other.GetComponent<Human>();

        if (!human) return;

        human.Infect(ratCount);
    }

    private void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Human")) return;
        var human = other.GetComponent<Human>();

        if (!human) return;

        human.ratIsClose = false;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Human")) {
            var human = other.GetComponent<Human>();

            human.ratIsClose = true;

            if (!human) return;

            if (human.isDead) _hunger += human.Consume();
        }

        if (!other.CompareTag("Food")) return;
        var food = other.GetComponent<Human>();

        _hunger += food.Consume();
        Destroy(food);
    }


    public void RatCounter(int currentcount) {
        ratCount = currentcount;
    }

    public void Hunger() { }

    public void Decay() {
        if (_hunger < -100) return;
    }
}