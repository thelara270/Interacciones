using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour, IInteractuable
{

    private AudioSource sonido;

    void Start()
    {
        gameObject.TryGetComponent<AudioSource>(out sonido);
    }

    public void Interactuar()
    {
        if (sonido.enabled == false)
        {
            sonido.enabled = true;
        }
        else
        {
            sonido.enabled = false;
        }
    }

}
