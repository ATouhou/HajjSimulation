using UnityEngine;
public class Spawner : MonoBehaviour
{
    public float spawn = 2;
    public GameObject bullet;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        spawn -= Time.deltaTime;
        if (spawn < 0)
        {
            Vector3 myPosition = GetComponent<Transform>().position;
            myPosition.y += 0;

            Quaternion myRotation = GetComponent<Transform>().rotation;

            Instantiate(bullet, myPosition, myRotation);

            spawn = 5;
           
        }
    }

}