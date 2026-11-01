using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    private int _score = 0;

    [SerializeField] private TMP_Text _scoreText;

    public void UpdateScore() {
        _score += 1;
        Debug.Log("Score updated to: " + _score);
        _scoreText.text = "Score: " + _score;
    }
    
    void Start() {
        _scoreText.text = "Score: " + _score;
    }
}
