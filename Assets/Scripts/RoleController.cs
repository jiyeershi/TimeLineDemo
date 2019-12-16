using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RoleController : MonoBehaviour
{

    private NavMeshAgent man;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        man = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        man.SetDestination(target.position);
    }
}
