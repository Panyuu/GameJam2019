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
        if (!ratIsClose && infectionMeter >= 0)
        {
            Debug.Log("InfectionMeter decay" + ": " + infectionMeter);
            infectionMeter -= 10 * Time.deltaTime;
        }

        if (isDead == true)
        {
            gameObject.GetComponent<SphereCollider>().radius = 1;
        }

    }

    public int Consume()
    {
        Destroy(gameObject);

        return 1;
    }

    public void Infect(float ratCount)
    {

        Debug.Log("InfectionMeter" + " : " + infectionMeter);

        if (health <= 0)
        {
            isDead = true;
            return;
        }

        if (isInfected)
        {
            health -= (10 + ratCount * 0.25f) * Time.deltaTime;
            Debug.Log("Health" + " : " + health);
        }
        else
        {
            if (infectionMeter > 100)
                return;

            infectionMeter += 10 * Time.deltaTime;

            if (infectionMeter <= 100)
                return;

            isInfected = true;

        }

    }

}
