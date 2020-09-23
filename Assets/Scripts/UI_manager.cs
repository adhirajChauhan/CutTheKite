using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    private bool doubleScore;
    // Start is called before the first frame update
    void Start()
    {   
        doubleScore = false;    
        _scoreText.text = "Score : " + 0;
    }

    public void UpdateScore(int playerScore)
    {
        _scoreText.text = "Score : " + playerScore.ToString(); 
    }
    
}
