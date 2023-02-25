using UnityEngine;

public class Damageable : MonoBehaviour
{
    public float startingHealth = 100f;
    public float maxHealth = 100f;
    public float damagePerSecond = 10f;

    private Damagable damagable;

    private void Start()
    {
        damagable = new Damagable(startingHealth, maxHealth, damagePerSecond);
    }

    private void Update()
    {
        // Simulate a fixed time step of 1 second
        float deltaTime = Time.deltaTime;

        // Take damage over time
        damagable.TakeDamageOverTime(deltaTime);

        // Check if the object's health has reached 0
        if (damagable.Health <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        // Destroy the game object
        Destroy(gameObject);
    }
}
