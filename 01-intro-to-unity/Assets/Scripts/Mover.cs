using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover: MonoBehaviour
{
    [SerializeField] float speed = 1f;   // in units per second

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start");
        //transform.position = new Vector3(0, 0, 0); // origin of world
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0); // move 1 unit right
    }
}
