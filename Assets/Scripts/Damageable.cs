using UnityEngine;

public class Damageable : MonoBehaviour
{
    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public float damagePerSecond = 10f;
    public Movement script;

    //private Damagable damagable;

    private void Start()
    {
        //damagable = new Damagable(startingHealth, maxHealth, damagePerSecond);
        currentHealth = maxHealth;
    }

    private void Update()
    {

       // if (script.moveInput.x < 0.01 && script.moveInput.y < 0.01 && script.moveInput.y > 0.01 && script.moveInput.x > 0.01)
       if(script.moveInput.x == 0 && script.moveInput.y == 0)
        {
            // Simulate a fixed time step of 1 second
            currentHealth -= damagePerSecond * Time.deltaTime;
        }

        // Take damage over time
       // damagable.TakeDamageOverTime(deltaTime);

        // Check if the object's health has reached 0
        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        // Destroy the game object
        // Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
