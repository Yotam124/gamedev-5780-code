using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMover : MonoBehaviour {
    void Update() {
        if (Input.GetMouseButtonDown(0)) {  // left button down
            Vector3 mousePositionInScreenCoordinates = Input.mousePosition;
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }
    }
}
