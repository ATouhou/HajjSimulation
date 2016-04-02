using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
    public static float speed = 5;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        float distance = speed * Time.deltaTime;
        transform.Translate(Vector3.right * distance);
    }

}
