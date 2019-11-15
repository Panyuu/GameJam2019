using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public float Health;

    public bool IsDead;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100;

        IsDead = false;
    }

    public int Consume()
    {
        Destroy(gameObject);

        return 1;
    }
}
