﻿using UnityEngine;

public class CameraSwitch : MonoBehaviour {
    public Camera camera;
    public Camera camera2;
    // Use this for initialization
    void Start () {
            camera.enabled = true;
            camera2.enabled = false;
        }
    void Update()
    {
        //This will toggle the enabled state of the two cameras between true and false each time
        if (Input.GetKeyUp(KeyCode.R))
        {
            camera.enabled = !camera.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}