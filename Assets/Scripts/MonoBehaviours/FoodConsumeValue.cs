using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FoodConsumeValue : MonoBehaviour
{
    public float satiation;
    public int ratsPlus;

    [FormerlySerializedAs("RespawnTimer")] public int respawnTimer;

    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
    }
    public (float,int) Consume()
    {
        _collider.enabled = false;
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

        StartCoroutine(Respawn());

        return (satiation, ratsPlus);

    }

    public IEnumerator Respawn()
    {
        yield return new WaitForSecondsRealtime(respawnTimer);

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
        _collider.enabled = true;

    }
}
