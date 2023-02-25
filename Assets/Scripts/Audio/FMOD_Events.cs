using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity; 

public class FMOD_Events : MonoBehaviour
{
    //Player 

    [field: Header("Footsteps")]

    [field: SerializeField] public EventReference Footsteps { get; private set; }


    [field: Header("Ambience")]

    [field: SerializeField] public EventReference ambience { get; private set; }
    //Objects

    //Ambience 

    //Music 

    [field: SerializeField] public EventReference DrainPocket { get; private set; }

    [field: Header("Acorn")]

    [field: SerializeField] public EventReference acornDropped { get; private set; }

    

    [field: Header("Root SFX")]

    [field: SerializeField] public EventReference RootMovement { get; private set; }

    [field: Header("Object SFX")]

    [field: SerializeField] public EventReference ObjectInteracted { get; private set; }

    [field: SerializeField] public EventReference ObjectIdle { get; private set; }

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
