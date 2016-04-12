  // MoveTo.cs
    using UnityEngine;
    using System.Collections;
    
   
    public class MoveTo : MonoBehaviour {
       
       public Transform goal;
       public float randomMax;
       public float agentRadius;
       public float tripFactor;
       public float a,b;
       public int minAge;
       public int maxAge;
       public float age, ageFactor;


     // Equation: a()
     // public GUIText scoreText;
       void Start () {
          NavMeshAgent agent = GetComponent<NavMeshAgent>();
          agent.destination = goal.position; 
          age = Random.Range(minAge, maxAge);
          
          
          
          ageFactor = b*((float)0.00156*(Mathf.Pow(age-(float)20, (float)1.409)));

       }

       void Update()
       {
         

        Collider[] hitColliders = Physics.OverlapSphere(transform.position, agentRadius);
        float numColliders = hitColliders.Length;
        float rand = a*(Random.Range(0,randomMax)*numColliders)+ ageFactor;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
     //   scoreText.text = score.ToString();
        if(age >= 65 && agent.speed != 0)
          {
            GetComponent<Renderer>().material.color = Color.blue;
          } 
          else
          {

          }
        if(agent.speed == 0)
        {

        }
        else
        {
         
          if(rand >= tripFactor)
          {
            agent.speed = 0;
            GetComponent<Renderer>().material.color = Color.red;
       //     score++;
          }
          else {

          }
        }
       }
    }
