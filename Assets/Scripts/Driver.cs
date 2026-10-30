using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour {
    
    [SerializeField] private float turnSpeed = 200f;
    [SerializeField] private float moveSpeed = 10f;
    
    void Start() { }

    void Update() {
        float _turn = 0f; 
        float _move = 0f;
            
        if (Keyboard.current.wKey.isPressed) {
            _move = 1f;
        }

        if (Keyboard.current.sKey.isPressed) {
            _move = -1f;
        }

        if (Keyboard.current.aKey.isPressed) {
            _turn = 1f;
        }

        if (Keyboard.current.dKey.isPressed) {
            _turn = -1f;
        }

        if (_move < 0) {
            _turn = -_turn;
        }
        
        transform.Rotate(0, 0, _turn * turnSpeed * Time.deltaTime);
        transform.Translate(0, _move * moveSpeed * Time.deltaTime, 0);
    }
}
