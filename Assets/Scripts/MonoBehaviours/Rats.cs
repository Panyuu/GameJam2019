using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rats : MonoBehaviour {
    private readonly Queue<GameObject> _ratObjectQueue = new Queue<GameObject>();

    public float hungerMulti, infectionMulti, baseDamage, incenseDmgMulti, dashMulti;
    public bool isDashing;
    public float ratCount;
    public GameObject ratPrefab;

    public float satiation;

    // Update is called once per frame
    private void Awake() {
        RatFollow.Mainrat = transform;
        satiation = 50;
        ratCount = 1;
        StartCoroutine(Decay());
    }

    private void Update() {
        Hunger();
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("Incense")) IncenseDamage();
        if (other.CompareTag("Human")) {
            var human = other.GetComponent<Human>();

            if (!human) return;

            human.Infect(ratCount);

            human.ratIsClose = true;

            if (human.isDead) {
                if (satiation >= 100) satiation = Mathf.Clamp(satiation, -1000, 100);

                var (item1, item2) = human.Consume();
                satiation += item1;
                InstantiateRats(item2);

                //Debug.Log("Satiation" + ": " + _satiation);
            }
        }

        if (!other.CompareTag("Food")) return;
        var food = other.GetComponent<FoodConsumeValue>();

        if (satiation >= 100) Mathf.Clamp(satiation, -1000, 100);

        var (item3, item4) = food.Consume();
        satiation += item3;
        InstantiateRats(item4);
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

            if (human.isDead) {
                if (satiation >= 100) satiation = Mathf.Clamp(satiation, -1000, 100);

                var (item1, item2) = human.Consume();
                satiation += item1;
                InstantiateRats(item2);

                //Debug.Log("Satiation" + ": " + _satiation);
            }
        }

        if (!other.CompareTag("Food")) return;
        var food = other.GetComponent<FoodConsumeValue>();

        if (satiation >= 100) Mathf.Clamp(satiation, -1000, 100);

        var (item3, item4) = food.Consume();
        satiation += item3;
        InstantiateRats(item4);
    }

    public void Hunger() {
        satiation -= (isDashing ? dashMulti : hungerMulti) * Time.deltaTime;
        satiation = Mathf.Clamp(satiation, -100, 1000);
    }

    public IEnumerator Decay() {
        while (true) {
            DeleteRats(1 + (int) (-satiation / 25));
            yield return new WaitForSecondsRealtime(1);
        }
    }

    public void InstantiateRats(int rats) {
        for (var i = 0; i < rats; i++) {
            ratCount++;
            var insideUnitCircle = Random.insideUnitCircle * 5;
            var mainRat = gameObject;
            var position = mainRat.transform.position;


            var mainratposition = position + new Vector3(insideUnitCircle.x, 0, insideUnitCircle.y);
            var newRat = Instantiate(ratPrefab, mainratposition, Random.rotation);

            newRat.gameObject.AddComponent<RatFollow>();
            _ratObjectQueue.Enqueue(newRat);
        }
    }

    public void DeleteRats(float ratsToSubstract) {
        ratCount -= ratsToSubstract;

        for (;ratCount < _ratObjectQueue.Count;) {
            Destroy(_ratObjectQueue.Dequeue());
        }

        if (ratCount > 0) return;
        EndOfGame.Instance.DocWin();
    }

    public void IncenseDamage() {
        DeleteRats(incenseDmgMulti * baseDamage * Time.deltaTime);
    }
}