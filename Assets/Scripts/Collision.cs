using UnityEngine;

public class Collision : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision detected!");
    }
    
    void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("Trigger entered!");
    }
}
