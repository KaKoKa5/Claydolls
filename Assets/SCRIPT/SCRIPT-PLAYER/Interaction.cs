using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// Interaction du Joueur vers les PNJ
public class Interaction : MonoBehaviour
{
    private bool isPlayerNear = false;
    private float interactionRange = 2f;
    private int count = 0;
    void Start()
    {

    }
    void Update()
    {
        
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactionRange);
                foreach (Collider collider in colliderArray)
                {
                if (collider.TryGetComponent(out IInteract interact) && count == 0)
                {
                    interact.Interact();
                    InteractIcon.Instance.ClearCurrent();
                    Cursor.lockState = CursorLockMode.None; // Débloque la souris
                    Cursor.visible = true;
                    count++;
                    Debug.Log("Count: " + count);
                    return;

                }
                }

            }
        if (Input.GetKeyDown(KeyCode.E) && count == 1)
        {
            Debug.Log("Interaction started");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            count = 0;
            return;
        }
        
        /*if (Input.GetKeyDown(KeyCode.V))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactionRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out IInteract interact))
                {
                    interact.Choix1();
                }
            }

        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactionRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out IInteract interact))
                {
                    interact.Choix2();
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactionRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out IInteract interact))
                {
                    interact.Choix3();
                }
            }

        }*/


    }
}