using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesKeeper : MonoBehaviour {
    int numLifeImages;

    void Start() {
        numLifeImages = transform.childCount; // each child is an image that represents one life.
        SetLives(numLifeImages);
    }

    public void SetLives(int newLives) {
        for (int i=0; i<newLives; ++i) {
            transform.GetChild(i).gameObject.SetActive(true);
        }
        for (int i = newLives; i < numLifeImages; ++i) {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }

}
