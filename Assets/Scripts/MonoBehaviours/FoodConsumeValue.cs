using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodConsumeValue : MonoBehaviour
{
    public float satiation;
    public int ratsPlus;

    public (float,int) Consume()
    {
        gameObject.SetActive(false);

        return (satiation, ratsPlus);
    }
}
