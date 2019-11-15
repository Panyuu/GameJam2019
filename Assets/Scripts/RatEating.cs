using UnityEngine;

public class RatEating : MonoBehaviour
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
            var human = gameObject.GetComponent<Human>();

            if (human.IsDead)
            {
                var consuming = human.GetComponent<Human>();
                foodCount += consuming.Consume();
            }
        }

    }
}
