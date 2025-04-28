using UnityEngine;
using System.Collections;
using System.Collections.Generic;


// Interaction du Joueur vers les PNJ
public class Interaction : MonoBehaviour
{
    private float interactionRange=2f;
    private bool isActive = false;
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
        if(Input.GetKeyDown(KeyCode.Y)|| Input.GetKeyDown(KeyCode.N)|| Input.GetKeyDown(KeyCode.B))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position,interactionRange);
            foreach(Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out IInteract interact))
                {
                    interact.Reponse();
                }  
            }

        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position,interactionRange);
            foreach(Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out IInteract interact))
                {
                    interact.Solution();
                }  
            }

        }
        
    }
}