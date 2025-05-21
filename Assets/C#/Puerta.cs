using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour, IInteractuable
{

    [SerializeField] float velocidaRotacion;
    [SerializeField] Vector3 abierto = new Vector3(0, -90, 0);
    [SerializeField] Vector3 cerrado = Vector3.zero;

    private Quaternion targetRot;
    private bool estaAbierto = false;

    void Start()
    {
        targetRot = Quaternion.Euler(cerrado);
    }

    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, velocidaRotacion * Time.deltaTime);
    }

    public void Interactuar(GameObject interactor)
    {
        estaAbierto = !estaAbierto;

        targetRot = estaAbierto ? Quaternion.Euler(abierto) : Quaternion.Euler(cerrado);
    }
}