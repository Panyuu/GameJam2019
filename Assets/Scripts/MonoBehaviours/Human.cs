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

<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
    public bool ratIsClose, docIsClose;

    public float currentratCountValue;

>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
        health = 100;

        isDead = false;
<<<<<<< Updated upstream
=======
        isInfected = false;
        ratIsClose = false;
        docIsClose = false;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

        isInfected = false;
    }

    void Update()
    {
<<<<<<< Updated upstream

        if(isDead == true)
=======
        if (!ratIsClose && infectionMeter >= 0 && infectionMeter <= 100)
        {

            Debug.Log("InfectionMeter decay" + ": " + infectionMeter);
            infectionMeter -= 10 * Rats.ratCount * Time.deltaTime;
        }

        if (!docIsClose && isInfected && health >= 0)
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

    public void Infect(float ratCount)
    {

        Debug.Log("InfectionMeter" + " : " + infectionMeter);

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
        health -= (5 + currentratCountValue * 0.25f) * Time.deltaTime;
        Debug.Log("Health" + " : " + health);
    }

>>>>>>> Stashed changes
}
