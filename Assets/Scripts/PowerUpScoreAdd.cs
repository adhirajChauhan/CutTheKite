using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScoreAdd : MonoBehaviour
{
    public int playerScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            PickUp(collision);

        }
    }

    void PickUp(Collider2D player)
    {
        UI_manager ui = player.GetComponent<UI_manager>();
        ui.UpdateScore(playerScore);
        Destroy(gameObject);
        Debug.Log("Picked Up");
    }

    public void AddScore()
    {
        //UI_manager ui = 
    }

}

