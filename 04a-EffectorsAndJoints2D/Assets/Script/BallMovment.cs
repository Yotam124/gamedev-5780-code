using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovment : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float _speed;
    private Vector3 _starting_point;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _starting_point = gameObject.transform.position;
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movment = new Vector3(x, 0, z);
        rb.AddForce(movment * _speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Bound")
        {
            gameObject.transform.position = _starting_point;
        }
    }
}
