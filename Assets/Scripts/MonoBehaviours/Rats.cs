using UnityEngine;

public class Rats : MonoBehaviour
{
    public GameObject human;
    public float foodCount;

    public int ratCount;
    // Update is called once per frame
    void Start()
    {
        foodCount = 1;
        ratCount = 1;
    }
    
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HumanScript"))
        {
            var HumanObject = gameObject.GetComponent<Human>();

            if (HumanObject.isDead)
            {
                var consuming = human.GetComponent<Human>();
                foodCount += consuming.Consume();
            }
            else
            {
                if (HumanObject.infectionMeter != 100)
                {
                    HumanObject.infectionMeter += 10 * Time.deltaTime;
                }
                else
                {
                    HumanObject.isInfected = true;
                }
            }
        }

    }
}
