using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
    public float destroytime = 2;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, destroytime);
    }
	
	// Update is called once per frame
	void Update () {
        
    }


}
