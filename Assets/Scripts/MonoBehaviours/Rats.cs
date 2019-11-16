using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Rats : MonoBehaviour
{

    private float hunger;

    List<Rat> ratObjectList = new List<Rat>();

    public int ratCount;
    // Update is called once per frame
    void Start()
    {
        RatFollow.mainrat = transform;
        hunger = 50;
        ratCount = 1;
    }
    
    void Update()
    {
 
    }

    private void OnTriggerStay(Collider other)
    {
        var human = other.GetComponent<Human>();

        if (!human)
        {
            return;
        }

        human.Infect(ratCount);

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            var human = other.GetComponent<Human>();
            
            if (!human)
            {
                return;
            }

            human.ratIsClose = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            var human = other.GetComponent<Human>();

            human.ratIsClose = true;

            if (!human)
            {
                return;
            }

            if (human.isDead)
            {
                hunger += human.Consume();
            }
        }

        if (other.CompareTag("Food"))
        {
            var food = other.GetComponent<Human>();

            hunger += food.Consume();
            Destroy(food);
        }
    }

    public void RatCounter(int currentcount)
    {
        ratCount = currentcount;
    }
    public void Hunger()
    {

    }
    public void Decay()
    {
        if (hunger < -100) return;


    }
}
