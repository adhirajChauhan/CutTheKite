using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;

    [SerializeField]
    private int _score;

    private UI_manager _uiManager;

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UI_manager>();
    }
    void Update()
    {
        CalculateMovement();

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    void CalculateMovement()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (transform.position.y > 4.5)
        {
            transform.position = new Vector2(transform.position.x, 4.5f);
        }
        else if (transform.position.y < -4.5)
        {
            transform.position = new Vector2(transform.position.x, -4.5f);
        }

        if (transform.position.x > 2.4)
        {
            transform.position = new Vector2(2.4f, transform.position.y);
        }
        else if (transform.position.x < -2.4)
        {
            transform.position = new Vector2(-2.4f, transform.position.y);
        }
    }

    public void AddScore(int points)
    {
        _score += points;
        _uiManager.UpdateScore(_score); 
    }
}
