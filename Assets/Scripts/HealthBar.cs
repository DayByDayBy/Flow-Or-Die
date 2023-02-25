using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public Damageable player;
    public virtual void UpdateHealthBar()
    {
        healthBarImage.fillAmount = Mathf.Clamp(player.currentHealth/ player.maxHealth, 0, 100f);
    }
}