using TMPro;
using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] TextMeshPro textField;
    [SerializeField] int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            int currentScore = int.Parse(textField.text);
            int newScore = currentScore + pointsToAdd;
            textField.text = newScore.ToString();
        }
    }

    public void SetTextField(TextMeshPro newTextField) {
        this.textField = newTextField;
    }
}
