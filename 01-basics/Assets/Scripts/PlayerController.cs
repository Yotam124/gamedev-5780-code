﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [Tooltip("in meters per second")]
    [SerializeField] float speed = 1f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}