using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour, IInteractuable
{
    [SerializeField] AudioSource sonido;

    public void Interactuar(GameObject interactor)
    {
        if (sonido.isPlaying == false)  
        {
            sonido.Play();
        }
        else
        {
            sonido.Pause();
        }

    }

}
