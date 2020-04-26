using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] bool isActive = true;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && isActive)
            Destroy(gameObject);
    }



    /* Methods for activating/deactivating the destruction */

    public void Activate() {
        Debug.Log("Activating destruction");
        isActive = true;
    }

    public void Deactivate() {
        Debug.Log("Deactivating destruction");
        isActive = false;
    }

    public IEnumerator DeactivateTemporarily(float duration) {
        Deactivate();
        yield return new WaitForSeconds(duration);
        Activate();
    }
}
