using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// Interaction du Joueur vers les PNJ
public class Interaction : MonoBehaviour
{
    private float interactionRange=2f;
   void Start()
    {
    
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position,interactionRange);
            foreach(Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out IInteract interact))
                {
                    interact.Interact();
                }  
            }

        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position,interactionRange);
            foreach(Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out IInteract interact))
                {
                    interact.Choix1();
                }  
            }

        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position,interactionRange);
            foreach(Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out IInteract interact))
                {
                    interact.Choix2();
                }  
            }

        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position,interactionRange);
            foreach(Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out IInteract interact))
                {
                    interact.Choix3();
                }  
            }

        }
        
    }
}