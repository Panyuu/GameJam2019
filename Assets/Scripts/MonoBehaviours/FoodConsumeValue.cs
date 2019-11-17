using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FoodConsumeValue : MonoBehaviour
{
    public float satiation;
    public int ratsPlus;

    public int RespawnTimer;

    private Collider collider;

    private void Awake()
    {
        collider = GetComponent<Collider>();
    }
    public (float,int) Consume()
    {
        collider.enabled = false;
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

        StartCoroutine(Respawn());

        return (satiation, ratsPlus);

    }

    public IEnumerator Respawn()
    {
        yield return new WaitForSecondsRealtime(RespawnTimer);

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
        collider.enabled = true;

    }
}
