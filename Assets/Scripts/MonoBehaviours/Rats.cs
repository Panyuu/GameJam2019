using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Rats : MonoBehaviour {

    public float satiation;
    
    private readonly Queue<GameObject> _ratObjectQueue = new Queue<GameObject>();

    int _ratCount;
    public float hungerMulti, infectionMulti, baseDamage, dashMulti;
    public GameObject ratPrefab;
    public bool isDashing;

    // Update is called once per frame
    private void Start()
    {
        RatFollow.Mainrat = transform;
        satiation = 50;
        _ratCount = 1;
        StartCoroutine(Decay());
        
    }

    private void Update()
    {
        Hunger();
        Debug.Log(satiation);
    }

    private void OnTriggerStay(Collider other) {
        
        if(other.gameObject.CompareTag("Incense"))
        {
            InsenceDamage();
        }
        if (other.CompareTag("Human"))
        {
            var human = other.GetComponent<Human>();

            if (!human) return;

            human.Infect(_ratCount);

            human.ratIsClose = true;

            if (human.isDead)
            {
                if (satiation >= 100)
                {
                    satiation = Mathf.Clamp(satiation, -1000, 100);
                }

                var (item1, item2) = human.Consume();
                satiation += item1;
                InstantiateRats(item2);

                //Debug.Log("Satiation" + ": " + _satiation);
            }
        }

        if (!other.CompareTag("Food")) return;
        var food = other.GetComponent<FoodConsumeValue>();

        if (satiation >= 100)
        {
            Mathf.Clamp(satiation, -1000, 100);
        }

        var (item3, item4) = food.Consume();
        satiation += item3;
        InstantiateRats(item4);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Human")) return;
        var human = other.GetComponent<Human>();

        if (!human)
        {
            return;
        }

        human.ratIsClose = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            var human = other.GetComponent<Human>();

            human.ratIsClose = true;

            if (!human) return;

            if (human.isDead)
            {
                if (satiation >= 100)
                {
                    satiation = Mathf.Clamp(satiation, -1000, 100);
                }

                var (item1, item2) = human.Consume();
                satiation += item1;
                InstantiateRats(item2);
                
                //Debug.Log("Satiation" + ": " + _satiation);
            }
        }

        if (!other.CompareTag("Food")) return;
        var food = other.GetComponent<FoodConsumeValue>();

        if (satiation >= 100)
        {
            Mathf.Clamp(satiation, -1000, 100);
        }

        var (item3, item4) = food.Consume();
        satiation += item3;
        InstantiateRats(item4);

    }

    public void Hunger()
    {

        satiation -=  (isDashing?dashMulti:hungerMulti) * Time.deltaTime;
        satiation = Mathf.Clamp(satiation, -100, 1000);
    }
    public IEnumerator Decay()
    {
        while (true)
        {
            DeleteRats(1+(int)(-satiation/25));
            yield return new WaitForSecondsRealtime(1);
        }
    }
    public void InstantiateRats(int rats)
    {
        for (var i = 0; i < rats; i++)
        {
            _ratCount++;
            var insideUnitCircle = Random.insideUnitCircle * 5;
            var mainRat = gameObject;
            var position = mainRat.transform.position;
           

            var mainratposition = position + new Vector3(insideUnitCircle.x, 0, insideUnitCircle.y);
            var newRat = Instantiate(ratPrefab, mainratposition, Random.rotation);

            newRat.gameObject.AddComponent<RatFollow>();
            _ratObjectQueue.Enqueue(newRat);
        }
        Debug.Log(_ratCount);
    }

    public void DeleteRats(int ratsToSubstract)
    {
        if (_ratCount <= 0) return;

        for (var i = 0; i < ratsToSubstract; i++)
        {
            if (_ratObjectQueue.Count > 0)
            {
                _ratCount--;
                Destroy(_ratObjectQueue.Dequeue());
            }
        }
    }

    public void InsenceDamage()
    {
        _ratCount -= (int)(baseDamage * Time.deltaTime);
    }
}