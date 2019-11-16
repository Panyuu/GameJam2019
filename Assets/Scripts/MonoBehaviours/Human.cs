using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public float health;

    public bool isDead;

    public bool isInfected;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;

        isDead = false;

        isInfected = false;
    }

    void Update()
    {
        if(isDead == true)
        {
            gameObject.GetComponent<SphereCollider>().radius = 1;
        }

        if (isInfected)
        {
            health -= 10 * Time.deltaTime;
        }
    }

    public int Consume()
    {
        Destroy(gameObject);

        return 1;
    }
}
