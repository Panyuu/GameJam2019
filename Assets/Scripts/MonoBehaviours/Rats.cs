using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Rats : MonoBehaviour {
    private float _hunger;

    private float _satiation;

    public GameObject swarmRats;
    Queue<GameObject> _ratObjectQueue = new Queue<GameObject>();

    public int ratCount;

    public GameObject ratPrefab;

    // Update is called once per frame
    void Start()
    {
        RatFollow.Mainrat = transform;
        _satiation = 50;
        ratCount = 1;
        StartCoroutine(Decay());
    }

    void Update()
    {
        Debug.Log(_satiation);

        Hunger();
    }

    private void OnTriggerStay(Collider other) {
        var human = other.GetComponent<Human>();

        if (!human) return;

        human.Infect(ratCount);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Human")) {
            var human = other.GetComponent<Human>();

            if (!human) {
                return;
            }
            else {

                human.ratIsClose = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Human")) {
            var human = other.GetComponent<Human>();

            human.ratIsClose = true;

            if (!human) return;

            if (human.isDead)
            {
                if (_satiation >= 100)
                {
                    _satiation = Mathf.Clamp(_satiation, -1000, 100);
                }
                _satiation += human.satiation;
                InstantiateRats(human.ratsPlus);
                human.Consume();
                Debug.Log("Satiation" + ": " + _satiation);
            }
        }

        if (!other.CompareTag("Food")) return;
        var food = other.GetComponent<Human>();

            if (_satiation >= 100)
            {
                Mathf.Clamp(_satiation, -1000, 100);
            }

            _satiation += food.satiation;

            InstantiateRats(food.ratsPlus);

        
    }

    public void Hunger()
    {
        _satiation -=  3 * Time.deltaTime;
        _satiation = Mathf.Clamp(_satiation, -100, 1000);
    }
    public IEnumerator Decay()
    {
        while (true)
        {
            DeleteRats(1+(int)(-_satiation/25));
            yield return new WaitForSecondsRealtime(1);
        }
    }
    public void InstantiateRats(int rats)
    {
        for (int i = 0; i < rats; i++)
        {
            ratCount++;
            var insideUnitCircle = Random.insideUnitCircle * 5;
            var mainRat = gameObject;
            var position = mainRat.transform.position;
            position += new Vector3(insideUnitCircle.x, 0, insideUnitCircle.y);
            mainRat.transform.position = position;

            var mainratposition = position;
            var newRat = Instantiate(swarmRats, mainratposition, Random.rotation);

            newRat.gameObject.AddComponent<RatFollow>();
            _ratObjectQueue.Enqueue(newRat);
        }
        Debug.Log(ratCount);
    }

    public void DeleteRats(int ratsToSubstract)
    {
        if (ratCount <= 0) return;

        for (int i = 0; i < ratsToSubstract; i++)
        {
            if (_ratObjectQueue.Count > 0)
            {
                Destroy(_ratObjectQueue.Dequeue());
            }
        }
    }
}