using UnityEngine;

public class Hiboux : MonoBehaviour , IInteract
{
 [SerializeField] private GameObject TextAne;
[SerializeField] private GameObject TextLoup;
[SerializeField] private GameObject TextLoup1;
    [SerializeField] private GameObject TextLion;

    // Peau d'ane
[SerializeField] private GameObject AneAne;
[SerializeField] private GameObject AneLoup;

    private bool isActive = false;
    private bool isTalking = false;
    private int count = 0;

    private int countAne = 0;
    private int countLoup = 0;
    private bool Talk = false; 
    public CharacterController playerController;
    public void NotMove()
    {

        Talk = !Talk;

            FindObjectOfType<CharaterMoovement>().controlsEnabled = !Talk;
            

    }


    private void Start()
    {
        TextAne.SetActive(false);
        TextLoup.SetActive(false);
        TextLoup1.SetActive(false);
        TextLion.SetActive(false);

        AneAne.SetActive(false);
        AneLoup.SetActive(false);


    }

    void Update()
    {
    
    }

    public void Interact()
    {
        NotMove();
        TextAne.SetActive(false);
        TextLoup.SetActive(false);
        TextLoup1.SetActive(false);
        TextLion.SetActive(false);

        isTalking = true;
        
        if (TableauMemoire.masque == 0 && TableauMemoire.UnVUnCochon == true && countAne==0)
        {
            AneAne.SetActive(true);
            AneLoup.SetActive(false);

            TextAne.SetActive(false);
            TextLoup.SetActive(false);
            TextLion.SetActive(false);
            countAne = 1;
            return;
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.UnVUnCochon == true && countAne == 1)
        {
            AneAne.SetActive(false);
            AneLoup.SetActive(false);

            isActive = !isActive;
            TextAne.SetActive(isActive);
            TextLoup.SetActive(false);
            TextLion.SetActive(false);
            return;
        }
        
        if (TableauMemoire.masque == 1 && TableauMemoire.UnVUnCochon == true && count == 0 && countLoup==0)
        {
            AneAne.SetActive(false);
            AneLoup.SetActive(true);

            TextAne.SetActive(false);
            TextLoup.SetActive(false);
            TextLion.SetActive(false);
            countLoup = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.UnVUnCochon == true && count == 0 && countLoup == 1)
        {
            AneAne.SetActive(false);
            AneLoup.SetActive(false);

            TextAne.SetActive(false);
            TextLoup.SetActive(true);
            TextLion.SetActive(false);
            count = 1;

            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.UnVUnCochon == true && count == 1)
        {
            AneAne.SetActive(false);
            AneLoup.SetActive(false);

            isActive = !isActive;
            TextAne.SetActive(false);
            TextLoup.SetActive(false);
            TextLoup1.SetActive(isActive);
            TextLion.SetActive(false);
            
            return;
        }




        if (TableauMemoire.masque == 2 && TableauMemoire.UnVUnCochon == true)
        {
            AneAne.SetActive(false);
            AneLoup.SetActive(false);

            isActive = !isActive;
            TextAne.SetActive(false);
            TextLoup.SetActive(false);
            TextLoup1.SetActive(false);
            TextLion.SetActive(isActive);

            TableauMemoire.HibouxDEAD = true;
            return;
        }

    }

    public void Choix1()
    {
        if (!isTalking)return;
    

        isActive = !isActive;


    }
    public void Choix2()
    {
        if (!isTalking)return;
    

        isActive = !isActive;

    }
    public void Choix3()
    {
        if (!isTalking)return;
    

        isActive = !isActive;

        
    }

}
