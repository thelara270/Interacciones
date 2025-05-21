using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour, IInteractuable
{
    bool encendido = false;
    [SerializeField] List<GameObject> luces;

    public void Interactuar()
    {
        encendido = !encendido;

        foreach (GameObject go in luces)
            go.SetActive(encendido);

    }
}