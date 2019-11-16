using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public GameObject rat;

    public float health;

    public bool isDead;

    public bool isInfected;

    public float infectionMeter;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;

        isDead = false;

        isInfected = false;
    }

    void Update()
    {

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
        Debug.Log(infectionMeter);
        if (isInfected)
        {
            health -= (10 + ratCount * 0.25f) * Time.deltaTime;
        }
        else
        {
            infectionMeter += 10 * Time.deltaTime;

            if (infectionMeter <= 100)
                return;

            isInfected = true;

        }

    }

}
