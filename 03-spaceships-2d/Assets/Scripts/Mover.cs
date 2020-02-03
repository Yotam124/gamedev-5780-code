using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover: MonoBehaviour
{
    [Tooltip("Direction and speed of movement, in meters per second")]
    [SerializeField] Vector3 speed;

    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }
}
