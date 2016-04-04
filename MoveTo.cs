  // MoveTo.cs
    using UnityEngine;
    using System.Collections;
   
    public class MoveTo : MonoBehaviour {
       
       public Transform goal;
       public int randomMax;
       public int agentRadius;
       public int tripFactor;
       void Start () {
          NavMeshAgent agent = GetComponent<NavMeshAgent>();
          agent.destination = goal.position; 

       }

       void Update()
       {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, agentRadius);
        int numColliders = hitColliders.Length;
        int rand = Random.Range(0,randomMax)*numColliders;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if(agent.speed == 0)
        {

        }
        else
        {
         
          if(rand >= tripFactor)
          {
            agent.speed = 0;
          }
          else {

          }
        }
       }
    }

