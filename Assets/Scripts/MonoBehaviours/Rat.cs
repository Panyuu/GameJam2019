using UnityEngine;

public class Rat : MonoBehaviour
{
    public GameObject human;
    public float foodCount;
    // Update is called once per frame
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Human"))
        {
            var HumanObject = gameObject.GetComponent<Human>();

            if (HumanObject.isDead)
            {
                var consuming = human.GetComponent<Human>();
                foodCount += consuming.Consume();
            }
            else
            {
                HumanObject.isInfected = true;
            }
        }

    }
}
