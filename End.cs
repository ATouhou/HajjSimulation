using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

        public float position = 2;
    // Use this for initialization
    void Start()
    {
        if (transform.position.z >= position)
        {
            Destroy(gameObject);
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
    }