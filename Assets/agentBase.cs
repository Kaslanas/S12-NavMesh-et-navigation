using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentBase : MonoBehaviour
{
    [SerializeField] private GameObject _Target;
    private NavMeshAgent _agent;
    

    void Start()
    {
       _agent = GetComponent<NavMeshAgent>();
  
    }

    // Update is called once per frame
    void Update()
    {

       _agent.SetDestination(_Target.transform.position);     
        
    }
}
