  // MoveTo.cs
    using UnityEngine;
    using System.Collections;
   
    public class MoveTo : MonoBehaviour {
       
       public Transform goal;
       
       
       void Start () {
          NavMeshAgent agent = GetComponent<NavMeshAgent>();
          agent.destination = goal.position; 
       }

       void Update()
       {
        int rand = Random.Range(0,500);
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if(agent.speed == 0)
        {

        }
        else
        {
         
          if(rand == 0)
          {
            agent.speed = 0;
          }
          else {

          }
        }
       }
    }

