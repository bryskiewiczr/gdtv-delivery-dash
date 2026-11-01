using System.Timers;
using UnityEngine;

public class Delivery : MonoBehaviour {

    [SerializeField] private float _packageDisappearDelay = .3f;
    
    private bool _isDelivering = false;

    private ParticleSystem _particleSystem;
    private Score _scoreManager;

    void Start() {
        _particleSystem = GetComponent<ParticleSystem>();
        _scoreManager = GetComponent<Score>();
    }
    
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Package") && !_isDelivering) {
            _isDelivering = true;
            _particleSystem.Play();
            Destroy(collider.gameObject, _packageDisappearDelay);
        } 
        
        if (collider.CompareTag("Customer")) {
            if (_isDelivering) {
                _isDelivering = false;
                _particleSystem.Stop();
                _scoreManager.UpdateScore();
            }
        }
    }
}
