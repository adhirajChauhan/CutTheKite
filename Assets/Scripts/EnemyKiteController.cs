using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiteController : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject target;
    float moveSpeed;
    Vector3 directionToTarget;

    private PlayerMovement _playerMovement;

    

    void Start()
    {
        
        _playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(1f, 3f);
    }

    void Update()
    {
        MoveKites();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (_playerMovement != null)
            {
                _playerMovement.AddScore(1);
            }
            Destroy(this.gameObject);
        }

    }

    void MoveKites()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToTarget.x * moveSpeed, directionToTarget.y * moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }
}
