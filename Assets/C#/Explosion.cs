using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] GameObject objetoOriginal;
    [SerializeField] GameObject objetoFracturado;
    //[SerializeField] GameObject fxExplocion;

    [SerializeField] float fuerzaMin = 5;
    [SerializeField] float fuerzaMax = 100;
    [SerializeField] float radioExplocion = 10;
    [SerializeField] float escalaFragmentos;

    [SerializeField] private Vector3 posicionOriginal;

    [SerializeField] private GameObject fragmentosObejto;

    private void Start()
    {
         posicionOriginal = transform.position;
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Explocion();
        }
        
    }

    public void Explocion()
    {
        if(objetoOriginal != null)
        {
            objetoOriginal.SetActive(false);

            if(objetoFracturado != null)
            {
                fragmentosObejto = Instantiate(objetoFracturado) as GameObject;
                objetoFracturado.transform.position = (posicionOriginal);

                foreach (Transform t in fragmentosObejto.transform)
                {
                    var rb = t.GetComponent<Rigidbody>();

                    if(rb != null)
                       rb.AddExplosionForce(Random.Range(fuerzaMin, fuerzaMax),objetoOriginal.transform.position,radioExplocion);

                    //StartCoroutine(Shrink(t, 2));
                }

                Destroy(fragmentosObejto,2);

            }
        }
    }

}
