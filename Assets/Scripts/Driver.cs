using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour {
    
    [SerializeField] private float _turnSpeed = 0.5f;
    [SerializeField] private float _moveSpeed = 0.04f;
    private float _maxMoveSpeed = 0.2f;
    
    void Start() { }

    void Update() {
        if (Keyboard.current.wKey.isPressed) {
            _moveSpeed = 0.1f;
        }

        if (Keyboard.current.sKey.isPressed) {
            _moveSpeed = -0.1f;
        }

        if (Keyboard.current.aKey.isPressed) {
            transform.Rotate(0, 0, _turnSpeed);
        }

        if (Keyboard.current.dKey.isPressed) {
            transform.Rotate(0, 0, -_turnSpeed);
        }

        _moveSpeed = Mathf.Clamp(_moveSpeed, 0, _maxMoveSpeed);
       
    }
}
