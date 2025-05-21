using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour, IInteractuable
{
    [SerializeField] Transform posicionDestino;

    public void Interactuar(GameObject interactor)
    {
        interactor.transform.position = posicionDestino.position;
    }

  
}
