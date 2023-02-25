using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damagable : MonoBehaviour
{
    private float health; // current health of the object
    private float maxHealth; // maximum health of the object
    private float damagePerSecond; // amount of damage the object takes per second

    public Damagable(float startingHealth, float maxHealth, float damagePerSecond)
    {
        this.health = startingHealth;
        this.maxHealth = maxHealth;
        this.damagePerSecond = damagePerSecond;
    }

    public void TakeDamageOverTime(float deltaTime)
    {

        float damage = damagePerSecond * deltaTime;

        health -= damage;

        health = Mathf.Clamp(health, 0f, maxHealth);
    }
}

