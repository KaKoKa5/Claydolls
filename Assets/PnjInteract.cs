using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Interaction du PNJ vers le Joueur
public class PnjInteract : MonoBehaviour
{
    [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject YESbulleDeText;
    [SerializeField] private GameObject NObulleDeText;
    [SerializeField] private GameObject SolutionText;


    private bool isActive = false;
    private bool isTalking = false;
    private bool isSolve = false;


    private void Start()
    {
        bulleDeText.SetActive(false);
        NObulleDeText.SetActive(false);
        YESbulleDeText.SetActive(false);
        SolutionText.SetActive(false);

    }

    void Update()
    {
    
    }

    public void Interact()
    {
        NObulleDeText.SetActive(false);
        YESbulleDeText.SetActive(false);
        SolutionText.SetActive(false);
        bulleDeText.SetActive(false);
        isTalking = true;
        isSolve = false;

        if (Input.GetKeyDown(KeyCode.E))
        {
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
            YESbulleDeText.SetActive(isActive);
            if (CompareTag("Cochon"))
            {
                TableauMemoire.cochonSolved = true;
                isSolve = true;
                return;
            }
        }
         if (Input.GetKeyDown(KeyCode.N))
        {
            isActive = !isActive;
            NObulleDeText.SetActive(isActive);
        }
    }

    public void Solution()
    {
        if (!CompareTag("Brebis")) return;
        if(!TableauMemoire.cochonSolved)return;

        if (Input.GetKeyDown(KeyCode.I))
        {
            isActive = !isActive;
            SolutionText.SetActive(isActive);
        }

    }


}
