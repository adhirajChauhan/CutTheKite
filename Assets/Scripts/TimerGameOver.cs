using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGameOver : MonoBehaviour
{
    public GameObject restartScene, gameOvertext;

    int countdownStartValue = 6;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
        restartScene.SetActive(false);
        gameOvertext.SetActive(false);
    }

    void countDownTimer()
    {
        if (countdownStartValue > 0)
        {
            timerUI.text = "TIMER : " + countdownStartValue;
            countdownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "GameOver";
            gameOvertext.SetActive(true);
            restartScene.SetActive(true);
            //gameObject.SetActive(false);
        }
    }


}
