using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity; 

public class FMOD_Events : MonoBehaviour
{
    //Player 

    [field: Header("Footsteps")]

    [field: SerializeField] public EventReference Footsteps { get; private set; }

    //Ambience 

    [field: Header("Ambience")]

    [field: SerializeField] public EventReference ambience { get; private set; }
    


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
