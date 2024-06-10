using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follower : MonoBehaviour
{
    public float distance = 10;
    private NavMeshAgent agent;
    public Transform target;
    public bool isHit = false;
    [SerializeField] AudioSource zombiesound;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.position) < distance)  
            {
                zombiesound.Play();
                agent.SetDestination(target.position);
            }
        }
    }
}
