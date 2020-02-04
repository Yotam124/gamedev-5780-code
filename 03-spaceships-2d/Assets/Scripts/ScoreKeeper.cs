using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    int score;

    public void SetScore(int newScore) {
        score = newScore;
        GetComponent<Text>().text = "0" + score;
    }

    private void Start() {
        SetScore(0);

    }

    public void IncrementScore() {
        SetScore(score+1);
    }
}
