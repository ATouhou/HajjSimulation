  // MoveTo.cs
    using UnityEngine;
    using System.Collections;
    using Random;
    
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
          if(rand.value() == 0.0)
          {
            agent.speed = 0
          }
          else {

          }
        }
       }
    }

