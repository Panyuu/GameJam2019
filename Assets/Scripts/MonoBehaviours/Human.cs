using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{

    public float health;

    public bool isDead;

    public bool isInfected;

    public float infectionMeter;

    public bool ratIsClose;

    public float currentratCountValue;

    public float satiation;

    public int ratsPlus;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        isDead = false;
        isInfected = false;
        ratIsClose = false;

    }

    void Update()
    {
        if (!ratIsClose && infectionMeter >= 0 && infectionMeter <= 100)
        {
            Debug.Log("InfectionMeter decay" + ": " + infectionMeter);
            infectionMeter -= 70 * Time.deltaTime;
        }

        if (isInfected && health >= 0)
        {
            HealthDrain();
        }
        
        if(health <= 0)
        {
            isDead = true;
        }

        if (isDead == true)
        {
            gameObject.GetComponent<SphereCollider>().radius = 1;
        }

    }

    public (float, int) Consume()
    {
        gameObject.SetActive(false);

        return (satiation, ratsPlus);
    }

    public void Infect(float ratCount)
    {

        //Debug.Log("InfectionMeter" + " : " + infectionMeter);

        if (health <= 0)
        {
            return;
        }
        else
        {
            if (infectionMeter > 100)
                return;

            infectionMeter += 10 * Time.deltaTime;

            if (infectionMeter <= 100)
            {
                currentratCountValue = ratCount;
                return;
            }

            isInfected = true;

        }

    }

    public void HealthDrain()
    {
        health -= (80 + currentratCountValue * 0.25f) * Time.deltaTime;
        //Debug.Log("Health" + " : " + health);
    }

}
