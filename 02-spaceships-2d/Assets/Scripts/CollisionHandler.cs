using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {
    private void Start() {
        Debug.Log("start");
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger with " + other);
    }
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision with " + collision);
    }
}
