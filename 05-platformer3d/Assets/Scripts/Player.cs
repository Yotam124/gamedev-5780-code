using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    CharacterController characterController;

    [Tooltip("In meters per second")] [SerializeField] float speed = 6.0f;
    [SerializeField] float jumpHeight = 8.0f;
    [SerializeField] float gravity = 1.0f;
    [SerializeField] float yVelocity = 0f;

    void Start() {
        characterController = GetComponent<CharacterController>();
    }

    void Update() {
        Vector3 velocity = new Vector3(0, 0, 0);
        velocity.x = Input.GetAxis("Horizontal") * speed;

        if (characterController.isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                yVelocity = jumpHeight;
            }
        } else {
            yVelocity -= gravity;
        }
        velocity.y = yVelocity;
        characterController.Move(velocity * Time.deltaTime); // in meters per frame
    }
}