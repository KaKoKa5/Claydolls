using UnityEngine;

public class Corbeaux : MonoBehaviour , IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;
 [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;

//Mission2
    [SerializeField] private GameObject TextPartie2;

    [SerializeField] private GameObject TextPartie3;

    [SerializeField] private GameObject TextPartie4;
    [SerializeField] private GameObject TextPartie41;
    [SerializeField] private GameObject TextPartie42;

    //Mission5:
    [SerializeField] private GameObject TextPartie5; 


    private bool isActive = false;
    private bool isTalking = false;

    private int stepTalk = 3;



    private void Start()
    {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);

        TextPartie2.SetActive(false);
        
        TextPartie3.SetActive(false);

        TextPartie4.SetActive(false);
        TextPartie41.SetActive(false);
        TextPartie42.SetActive(false);

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

        TextPartie3.SetActive(false);

        TextPartie4.SetActive(false);
        TextPartie41.SetActive(false);
        TextPartie42.SetActive(false);
        
        //Mission6
        TextPartie5.SetActive(false);

        isTalking = true;

            //mission1
            TableauMemoire.talkCorbeau = true;
            if(TableauMemoire.AmiChien==false && TableauMemoire.masque==0)
            {
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
            }

            //Mission2:----------------------------------------------
        if (TableauMemoire.confidenceCerf==true && TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }
        if(TableauMemoire.masque==1)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission 4-------------------------------------------------
        if(TableauMemoire.masque==0 && TableauMemoire.AmiChien==true && stepTalk==3)
        {
            isActive = !isActive;

            TextPartie41.SetActive(false);
            TextPartie42.SetActive(false);

            TextPartie4.SetActive(isActive);
            stepTalk = 1;
        }
        else if(TableauMemoire.masque==0 && TableauMemoire.AmiChien==true && stepTalk==1)
        {
            isActive = !isActive;
            TextPartie4.SetActive(false);
            TextPartie42.SetActive(false);

            TextPartie42.SetActive(isActive);
            stepTalk = 2;
        }
        else if(TableauMemoire.masque==0 && TableauMemoire.AmiChien==true && stepTalk==2)
        {
            isActive = !isActive;
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(false);
        
            TextPartie41.SetActive(isActive);
            autoHideVideo.Video();
            TableauMemoire.SecretSurCerf=true;
            stepTalk = 3;
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
        if(TableauMemoire.confidenceCerf==true)return;

        if(TableauMemoire.AmiChien==false)
        {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(true);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        }

    }
    public void Choix2()
    {
        if (!isTalking)return;
        if(TableauMemoire.confidenceCerf==true)return;

        if(TableauMemoire.AmiChien==false)
        {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(true);
        choix3Text.SetActive(false);
        }
    }
    public void Choix3()
    {
        if (!isTalking)return;
        if(TableauMemoire.confidenceCerf==true)return;

        if(TableauMemoire.AmiChien==false)
        {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(true);
        }
    }

}
