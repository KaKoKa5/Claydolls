using UnityEngine;


// Interaction du PNJ vers le Joueur
public class Cerf : MonoBehaviour ,IInteract
{
    [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;
    [SerializeField] private GameObject bulleTextEND;
    [SerializeField] private GameObject bulleTextENDPatie1;
    [SerializeField] private GameObject bulleTextPartie1;



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
        bulleTextENDPatie1.SetActive(false);
        bulleTextPartie1.SetActive(false);

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
        if (Input.GetKeyDown(KeyCode.E))
        {
            //mission1
            TableauMemoire.talkCerf=true;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        
        if (!TableauMemoire.talkBrebis || 
        !TableauMemoire.talkCerf || 
        !TableauMemoire.talkChien || 
        !TableauMemoire.talkCochon || 
        !TableauMemoire.talkCorbeau || 
        !TableauMemoire.talkSerpent)
        {
            return;
        }
       
            bulleTextPartie1.SetActive(isActive);
            
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
    

    }


}
