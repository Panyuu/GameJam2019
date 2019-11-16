using System;
using UnityEngine;

public class Rats : MonoBehaviour
{
    public GameObject human;
    public GameObject food;

    public float foodCount;

    public static int ratCount;
    
    // Update is called once per frame
    void Start()
    {
        foodCount = 1;
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
                foodCount += human.Consume();
            }
        }

        if (other.CompareTag("Food"))
        {
            var food = other.GetComponent<Human>();

            //foodCount += food.Consume;
            Destroy(food);
        }
    }

    void Multiply()
    {
        if (foodCount == 10f + (ratCount - 1f) * 4f)
        {
            ratCount++;
        }
    }
}
