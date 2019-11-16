using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ratspawn : MonoBehaviour
{
    public int instanceCount;
    public GameObject rat;

    public static Rats mainrat;
    private List<GameObject> ratObjectList = new List<GameObject>();

    private void Start()
    {
       // InstantiateRats(instanceCount);
    }

    public void InstantiateRats(int rats)
    {
        for (int i = 0; i < rats; i++)
        {
            rat.GetComponent<Rats>().ratCount++;
            var insideUnitCircle = Random.insideUnitCircle * 5;
            rat.transform.position += new Vector3(insideUnitCircle.x, 0, insideUnitCircle.y);

            var mainratposition = rat.transform.position;
            var newRat = Instantiate(rat, mainratposition, Random.rotation);

            newRat.gameObject.AddComponent<RatFollow>();
            newRat.GetComponent<RatFollow>();
            ratObjectList.Add(newRat);
        }

    }
}
