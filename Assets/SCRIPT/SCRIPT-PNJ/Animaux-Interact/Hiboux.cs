/*using UnityEngine;

public class Hiboux : MonoBehaviour , IInteract
{
 [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;
    [SerializeField] private GameObject bulleTextEND;


    private bool isActive = false;
    private bool isTalking = false;
    private bool isSolve = false;


    private void Start()
    {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleTextEND.SetActive(false);

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
        bulleTextEND.SetActive(false);
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
            choix1Text.SetActive(isActive);
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
        if (!CompareTag("Brebis")) return;
        if(!TableauMemoire.cochonSolved)return;

        if (Input.GetKeyDown(KeyCode.I))
        {
            isActive = !isActive;
            bulleTextEND.SetActive(isActive);
        }

    }
}*/
