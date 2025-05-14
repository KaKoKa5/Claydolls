using UnityEngine;

public class Cochon : MonoBehaviour , IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;
  [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;

    //Mission2:
    [SerializeField] private GameObject TextPartie2;

    //Mission3:
    [SerializeField] private GameObject TextPartie3;
    [SerializeField] private GameObject choix1TextPartie3;
    [SerializeField] private GameObject choix2TextPartie3;

    //Mission5:
    [SerializeField] private GameObject TextPartie5;  


    private bool isActive = false;
    private bool isTalking = false;


    private void Start()
    {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        
        TextPartie2.SetActive(false);

        //Mission3
        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);

        //Mission6
        TextPartie5.SetActive(false);


    }

    public void Interact()
    {
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);

        TextPartie2.SetActive(false);

        //Mission3
        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);

        //Mission6
        TextPartie5.SetActive(false);

        isTalking = true;

            //mission1
            TableauMemoire.talkCochon = true;
        if (TableauMemoire.masque==0)
        {
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }
        //Mission2:--------------------------------------------------------------------

        TextPartie2.SetActive(false);
        if (TableauMemoire.confidenceCerf==true && TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
            return;
        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque==1)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission5----------------------------------------------------------------------

        if(TableauMemoire.masque==2)
        {
            TableauMemoire.MLionFound=true;
            TextPartie5.SetActive(false);
            isActive=!isActive;
            TextPartie5.SetActive(isActive);
        }


    }

    public void Choix1()
    {
        if (!isTalking)return;

        if (TableauMemoire.masque==0 && TableauMemoire.confidenceCerf==false)
        {
        choix1Text.SetActive(true);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);
        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque==1)
        {
            TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(true);
        choix2TextPartie3.SetActive(false);
        }
    }
    public void Choix2()
    {
        if (!isTalking)return;

        if (TableauMemoire.masque==0 && TableauMemoire.confidenceCerf==false)
        {
            choix1Text.SetActive(false);
        choix2Text.SetActive(true);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);
        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque==1)
        {
            TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(true);
        }
    }
    public void Choix3()
    {
        if (!isTalking)return;

        if (TableauMemoire.masque==0 && TableauMemoire.confidenceCerf==false)
        {
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(true);
        bulleDeText.SetActive(false);
        }
        
    }

}
