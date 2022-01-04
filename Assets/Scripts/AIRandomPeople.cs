using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class AIRandomPeople : MonoBehaviour
{


    private NavMeshAgent _agent;
    public Transform referance;
    public Transform referance2;
    private int rnd;
    private int rnd2;
    
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

        rnd = Random.Range(0, 2);
        rnd2 = Random.Range(2, 4);
        _agent.speed = rnd2;
        

        if (rnd == 0)
        {
            _agent.SetDestination(referance.transform.position);
        }
        
        else if (rnd == 1)
        {
            _agent.SetDestination(referance2.transform.position);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PeopleRef"))
        {
            _agent.SetDestination(referance2.transform.position);
        }
        
        else if (other.gameObject.CompareTag("PeopleRef2"))
        {
            _agent.SetDestination(referance.transform.position);
        }
    }
}
