using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatFollow : MonoBehaviour
{
    public static Transform mainrat;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, mainrat.position, Time.deltaTime);
    }
}
