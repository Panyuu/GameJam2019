using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanScript : MonoBehaviour
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

        if(isDead == true)
        {
            gameObject.GetComponent<SphereCollider>().radius = 1;
        }

        if (isInfected)
        {
            var RatScript = rat.GetComponent<RatScript>();
            health -= (10 + RatScript.ratCount * 0.25f)  * Time.deltaTime;
        }
    }

    public int Consume()
    {
        Destroy(gameObject);

        return 1;
    }
}
