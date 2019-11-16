using UnityEngine;

public class Rats : MonoBehaviour {
    public static int RatCount;

    public float foodCount;

    // Update is called once per frame
    private void Start() {
        foodCount = 1;
        RatCount = 1;
    }

    private void OnTriggerStay(Collider other) {
        var human = other.GetComponent<Human>();

        if (!human) return;

        human.Infect(RatCount);
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

            if (human.isDead) foodCount += human.Consume();
        }

        if (!other.CompareTag("Food")) return;
        var food = other.GetComponent<Human>();

        //foodCount += food.Consume;
        Destroy(food);
    }
}