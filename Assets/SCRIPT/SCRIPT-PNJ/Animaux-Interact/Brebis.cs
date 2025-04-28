using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Brebis : MonoBehaviour ,IInteract
{

    [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;

    private bool isActive = false;
    private bool isTalking = false;
    private bool isSolve = false;


    private void Start()
    {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);

    }

    void Update()
    {
    
    }

    public void Interact()
    {
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);
        isTalking = true;

        if (Input.GetKeyDown(KeyCode.E))
        {
            //mission1
            TableauMemoire.talkBrebis = true;
            
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }
    }

    public void Reponse()
    {
        if (!isTalking)return;
    
        bulleDeText.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Y))
        {
            isActive = !isActive;
            choix1Text.SetActive(isActive);
    
        }
         if (Input.GetKeyDown(KeyCode.N))
        {
            isActive = !isActive;
            choix2Text.SetActive(isActive);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            isActive = !isActive;
            choix3Text.SetActive(isActive);
        }
    }

    public void Solution()
    {

        if (Input.GetKeyDown(KeyCode.I))
        {
            isActive = !isActive;
        }

    }


}

