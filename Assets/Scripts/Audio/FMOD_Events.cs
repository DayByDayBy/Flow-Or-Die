using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity; 

public class FMOD_Events : MonoBehaviour
{
    //Player 

    [field: Header("Footsteps")]

    [field: SerializeField] public EventReference Footsteps { get; private set; }

    [field: Header("HeartBeat")]

    [field: SerializeField] public EventReference HeartBeat { get; private set; }

    [field: Header("Death")]

    [field: SerializeField] public EventReference Death { get; private set; }

    //Ambience 

    [field: Header("Ambience")]

    [field: SerializeField] public EventReference ambience { get; private set; }

    //Music

    [field: Header("Music")]

    [field: SerializeField] public EventReference Music { get; private set; }

   
    //Enemy


    [field: Header("Swisher")]

    [field: SerializeField] public EventReference Swisher { get; private set; }

    [field: Header("Bounce")]

    [field: SerializeField] public EventReference Bounce { get; private set; }

    [field: Header("EnemyNoise")]

    [field: SerializeField] public EventReference EnemyNoise { get; private set;}




public static FMOD_Events instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Fmod Events instancein the Scene.");
        }
        instance = this;
    }
}
