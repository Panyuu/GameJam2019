using UnityEngine;
using UnityEngine.AI;

public class RatFollow : MonoBehaviour
{
    public static Transform Mainrat;
    private NavMeshAgent _agent;

    private void Awake() {
        _agent = GetComponent<NavMeshAgent>();
        transform.parent = transform.root;
    }

    // Update is called once per frame
    private void FixedUpdate() {
        _agent.SetDestination(Mainrat.position);
    }
}
