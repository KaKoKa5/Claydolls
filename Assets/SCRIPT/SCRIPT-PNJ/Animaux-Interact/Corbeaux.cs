using UnityEngine;

public class Corbeaux : MonoBehaviour , IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;

    [SerializeField] private GameObject STARTText;
[SerializeField] private GameObject STARTText2;
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

    //PARTIE2
    [SerializeField] private GameObject TextPartie2A;
    [SerializeField] private GameObject TextPartie2L;
    [SerializeField] private GameObject TextPartie2LL;

    // Partie2Hiboux
    [SerializeField] private GameObject TextPartieHiboux;
    [SerializeField] private GameObject TextPartieHiboux0;
    [SerializeField] private GameObject TextPartieHiboux1;
    [SerializeField] private GameObject TextPartieHiboux2;


    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;
    private int Count = 0;

    private int stepTalk = 3;



    private void Start()
    {

        STARTText.SetActive(false);
        STARTText2.SetActive(false);
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

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);
        
        // Partie2Hiboux
        TextPartieHiboux.SetActive(false);
        TextPartieHiboux0.SetActive(false);
        TextPartieHiboux1.SetActive(false);
        TextPartieHiboux2.SetActive(false);

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

        TextPartieHiboux.SetActive(false);
        TextPartieHiboux0.SetActive(false);
        TextPartieHiboux1.SetActive(false);
        TextPartieHiboux2.SetActive(false);

        if (TableauMemoire.talkFirst == false)
        {
            if (CountText == 0)
            {
                isActive = !isActive;
                STARTText.SetActive(isActive);
                CountText = 1;
                return;
            }
            else if (CountText == 1)
            {
                STARTText.SetActive(false);
                STARTText2.SetActive(isActive);
                CountText = 2;
                return;
            }
            else if (CountText == 2)
            {
                STARTText2.SetActive(false);
                CountText = 1;
                return;
            }

        }

        //Mission6
        TextPartie5.SetActive(false);

        isTalking = true;

        //mission1
        TableauMemoire.talkCorbeau = true;
        if (TableauMemoire.AmiChien == false && TableauMemoire.masque == 0 && TableauMemoire.talkFirst == true && TableauMemoire.Partie2 == false)
        {
            CountText = 3;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }

        //Mission2:----------------------------------------------
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0 && TableauMemoire.Partie2 == false)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission 4-------------------------------------------------
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && stepTalk == 3 && TableauMemoire.Partie2 == false)
        {
            isActive = !isActive;

            TextPartie41.SetActive(false);
            TextPartie42.SetActive(false);

            TextPartie4.SetActive(isActive);
            stepTalk = 1;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && stepTalk == 1)
        {
            isActive = !isActive;
            TextPartie4.SetActive(false);
            TextPartie42.SetActive(false);

            TextPartie42.SetActive(isActive);
            stepTalk = 2;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && stepTalk == 2)
        {
            isActive = !isActive;
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(false);

            TextPartie41.SetActive(isActive);
            autoHideVideo.Video();
            TableauMemoire.SecretSurCerf = true;
            stepTalk = 3;
        }
        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false)
        {
            TableauMemoire.MLionFound = true;
            TextPartie5.SetActive(false);
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true && TableauMemoire.HibouxFound == false)
        {
            isActive = !isActive;
            TextPartie2A.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true )
        {
            isActive = !isActive;
            TextPartie2L.SetActive(isActive);
        }
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == true )
        {
            isActive = !isActive;
            TextPartie2LL.SetActive(isActive);
        }
        // Partie2Hiboux
        if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 0)
        {
            TextPartieHiboux.SetActive(true);
            
            Count = 1;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 1)
        {
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(true);
            TextPartieHiboux1.SetActive(false);
            TextPartieHiboux2.SetActive(false);
            Count = 2;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 2)
        {
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(false);
            TextPartieHiboux1.SetActive(true);
            TextPartieHiboux2.SetActive(false);
            Count = 3;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 3)
        {
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(false);
            TextPartieHiboux1.SetActive(false);
            TextPartieHiboux2.SetActive(true);
            Count = 4;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 4)
        {
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(false);
            TextPartieHiboux1.SetActive(false);
            TextPartieHiboux2.SetActive(false);
            TableauMemoire.StoryCorbeau = true;
            autoHideVideo.Video();
            Count = 0;
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
