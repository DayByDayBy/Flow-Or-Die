using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D Rigidbody;
    public Vector2 moveInput;

    private EventInstance Footsteps;

    // Start is called before the first frame update
    void Start()
    {
        Footsteps = AudioManager.instance.CreateInstance(FMOD_Events.instance.Footsteps);
        AudioManager.instance.PlayOneShot(FMOD_Events.instance.ambience, this.transform.position);
        AudioManager.instance.PlayOneShot(FMOD_Events.instance.Music, this.transform.position);
    }

    // Update is called once per frame
    public void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        Rigidbody.velocity = moveInput * moveSpeed;
    

        
        

    }
    private void UpdateSound()
    {
        if (moveInput.x != 0)
        {
            PLAYBACK_STATE playbackState;
            Footsteps.getPlaybackState(out playbackState);
            if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                Footsteps.start();
            }
            else
            {
                Footsteps.stop(STOP_MODE.ALLOWFADEOUT);
            }
        }
        if (moveInput.y != 0)
        {
            PLAYBACK_STATE playbackState;
            Footsteps.getPlaybackState(out playbackState);
            if (playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                Footsteps.start();
            }
            else
            {
                Footsteps.stop(STOP_MODE.ALLOWFADEOUT);
            }
        }
    }
}



