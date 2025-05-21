using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] float velocidad;

    bool inTrigger = false;

    protected IInteractuable interactables;

    [SerializeField] Joystick joystick;


    public void GoToInteract(IInteractuable interactableSystem)
    {
        interactables = interactableSystem;
    }

    private void Update()
    {
        //if (inTrigger && Input.GetKeyDown(KeyCode.E))
        //{
        //    interactables.Interactuar();
        //}

        float horizontal = joystick.Horizontal;/*Input.GetAxis("Horizontal")*/
        float vertical = joystick.Vertical;/*Input.GetAxis("Vertical")*/;

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        transform.Translate(movement * velocidad * Time.deltaTime);
    }

    public void InterartuarBoton()
    {
        if (interactables != null)
        {
            interactables.Interactuar(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IInteractuable>(out var interactable))
        {
            GoToInteract(interactable);
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<IInteractuable>(out var interactable) && interactable == interactables)
        {
            interactables = null;
            inTrigger = true;
        }
    }

}
