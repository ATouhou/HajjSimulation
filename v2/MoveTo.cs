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
        Random rand;
        if(agent.speed == 0)
        {

        }
        else
        {
          if(Random.value() == 0.0)
          {
            agent.speed = 0;
          }
          else {

          }
        }
       }
    }

