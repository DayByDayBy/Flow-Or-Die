using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyEnemy : MonoBehaviour
{

    private Rigidbody2D _enemyRB;
    Vector3 lastVelocity;

   
    private void Awake()
    {
        _enemyRB = GetComponent<Rigidbody2D>();

    }

  
    void Update()
    {
        lastVelocity = _enemyRB.velocity;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

        _enemyRB.velocity = direction * Mathf.Max(speed, 0f);
    }

}
