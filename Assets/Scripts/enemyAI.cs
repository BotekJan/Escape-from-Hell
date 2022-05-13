using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Transform player;

    public float moveSpeed = 300f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Update(){
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        Debug.Log(movement);
    }

    void FixedUpdate()
    {
        rb.MovePosition((Vector2)transform.position + movement * moveSpeed * Time.fixedDeltaTime);

        
    }

}
