using UnityEngine;
[RequireComponent(typeof(SphereCollider))] 

public class Human : MonoBehaviour {
    public float currentratCountValue, health, infectionMeter, satiation, infectionMulti,infectBase, healthDrMulti, healthDrBase;

    public bool isDead, isInfected, ratIsClose, docIsClose;
    public int ratsPlus;

    // Start is called before the first frame update
    private void Start() {
        health = 100;
        isDead = false;
        isInfected = false;
        ratIsClose = false;
        docIsClose = false;
    }

    private void Update() {
        if (!ratIsClose && infectionMeter >= 0 && infectionMeter <= 100) {
            Debug.Log("InfectionMeter decay" + ": " + infectionMeter);
            infectionMeter -= 70 * Time.deltaTime;
        }

        if (!docIsClose && isInfected && health >= 0) HealthDrain();

        if (health <= 0) isDead = true;

        if (isDead) gameObject.GetComponent<SphereCollider>().radius = 1;
    }

    public (float, int) Consume()
    {
        gameObject.SetActive(false);

        return (satiation, ratsPlus);
    }

    public void Infect(float ratCount)
    {

        //Debug.Log("InfectionMeter" + " : " + infectionMeter);

        if (health <= 0)

            return;

        if (infectionMeter > 100)
            return;

        infectionMeter += (infectBase +  ratCount* infectionMulti )* Time.deltaTime;

        if (infectionMeter <= 100) {
            currentratCountValue = ratCount;
            return;
        }

        isInfected = true;
    }

    public void HealthDrain()
    {
        health -= (healthDrBase + currentratCountValue * healthDrMulti) * Time.deltaTime;
        //Debug.Log("Health" + " : " + health);
    }
}