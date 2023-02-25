using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health, maxHealth;
    public HealthBar healthBar;
   


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            TakeDamage();
        }
    }

private void TakeDamage()

    {
        health -= 0.5f;
        healthBar.UpdateHealthBar();
    }

}
