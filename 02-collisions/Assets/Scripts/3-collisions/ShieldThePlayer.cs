using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldThePlayer : MonoBehaviour {
    [Tooltip("The number of seconds that the shield remains active")] [SerializeField] float duration;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("Shield triggered by player");
            var destroyComponent = other.gameObject.GetComponent<DestroyOnTrigger2D>();
            if (destroyComponent) {
                StartCoroutine(destroyComponent.DeactivateTemporarily(duration));
                Destroy(gameObject);
            }
        } else {
            Debug.Log("Shield triggered by "+other.name);
        }
    }
    
    private IEnumerator ShieldTemporarily(DestroyOnTrigger2D destroyComponent) {
        destroyComponent.Deactivate();
        yield return new WaitForSeconds(duration);
        destroyComponent.Activate();
    }
}
