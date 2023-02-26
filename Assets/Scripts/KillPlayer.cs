using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            AudioManager.instance.PlayOneShot(FMOD_Events.instance.Death, this.transform.position);
            SceneManager.LoadScene("GameOver");
        }
    }

}
