using UnityEngine;

public class Serpent : MonoBehaviour, IInteract
{

    [SerializeField] private AutoHideVideo autoHideVideo;

    [SerializeField] private GameObject STARTText;
[SerializeField] private GameObject STARTText2;
 [SerializeField] private GameObject bulleDeText;
 [SerializeField] private GameObject TextPartie2;

 [SerializeField] private GameObject TextPartie3;
 
 [SerializeField] private GameObject TextPartie3d;
 [SerializeField] private GameObject TextPartie4;
 [SerializeField] private GameObject TextPartie41;
 [SerializeField] private GameObject TextPartie42;
 [SerializeField] private GameObject AmiDuChien;

//Mission6:
[SerializeField] private GameObject TextPartie6;

    //Mission JSP mais Partie2----------------------------------------------
[SerializeField] private GameObject TextRevelCochon;
[SerializeField] private GameObject TextRevelCochon2;
    [SerializeField] private GameObject TextRevelCochon3;

    [SerializeField] private GameObject HibouxCave;

    //END
    [SerializeField] private GameObject END;

    //Peau D'Ane
    [SerializeField] private GameObject AneChap5;
    [SerializeField] private GameObject AneChap8;



    private bool isActive = false;
    private bool isTalking = false;
    private bool passTalking = false;
    private int stepTalk=0;
    private int stepTalke=0;
    private int stepTalkPartie6=0;
    private int CountText=0;
    private int CountPartie2=0;
    private bool Talk = false; 
    public CharacterController playerController;
    public void NotMove()
    {

        Talk = !Talk;

            FindObjectOfType<CharaterMoovement>().controlsEnabled = !Talk;
            

    }


    private void Start()
    {

        STARTText.SetActive(false);
        STARTText2.SetActive(false);

        bulleDeText.SetActive(false);
        TextPartie2.SetActive(false);

        TextPartie3.SetActive(false);
        TextPartie3d.SetActive(false);
        stepTalk = 0;

        TextPartie4.SetActive(false);
        TextPartie41.SetActive(false);
        TextPartie42.SetActive(false);

        AmiDuChien.SetActive(false);

        //Mission6
        TextPartie6.SetActive(false);
        stepTalke = 2;

        TextRevelCochon.SetActive(false);
        TextRevelCochon2.SetActive(false);
        TextRevelCochon3.SetActive(false);

        HibouxCave.SetActive(false);

        END.SetActive(false);

        //Peau D'ane
        AneChap5.SetActive(false);

        AneChap8.SetActive(false);

    }
    public void Interact()
    {
        NotMove();
        bulleDeText.SetActive(false);
        TextPartie2.SetActive(false);

        TextPartie3.SetActive(false);
        TextPartie3d.SetActive(false);

        TextPartie4.SetActive(false);
        TextPartie41.SetActive(false);
        TextPartie42.SetActive(false);

        AmiDuChien.SetActive(false);

        //Mission6
        TextPartie6.SetActive(false);

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
                FindObjectOfType<CharaterMoovement>().controlsEnabled = Talk;
                STARTText.SetActive(false);
                STARTText2.SetActive(isActive);
                CountText = 2;
                return;
            }
            else if (CountText == 2)
            {
                FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
                Cursor.visible = true;
                STARTText2.SetActive(false);
                CountText = 1;
                return;
                
            }

        }


        isTalking = true;
        isActive = !isActive;

        //mission1-----------------------------------------
        TableauMemoire.talkSerpent = true;
        if (TableauMemoire.masque == 0 && TableauMemoire.SecretSurCerf == false && TableauMemoire.talkFirst == true && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            CountText = 3;
            bulleDeText.SetActive(isActive);
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == true && TableauMemoire.UnVUnCochon == false)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }

        //Mission 3 ------------------------------------------------------------
        if (TableauMemoire.masque == 1 && stepTalk == 0 && TableauMemoire.UnVUnCochon == false)
        {
            TextPartie3.SetActive(true);
            stepTalk = 1;
            return;

        }
        if (stepTalk == 1 && TableauMemoire.masque == 1 && TableauMemoire.UnVUnCochon == false)
        {
            TextPartie3.SetActive(false);
            AneChap5.SetActive(true);
            stepTalk = 2;
            return;
        }

        if (stepTalk == 2 && TableauMemoire.masque == 1 && TableauMemoire.UnVUnCochon == false)
        {
            AneChap5.SetActive(false);
            TextPartie3.SetActive(false);
            TextPartie3d.SetActive(isActive);
            passTalking = true;
            return;
        }


        if (TableauMemoire.AmiChien == true && TableauMemoire.SecretSurCerf == false && TableauMemoire.masque == 0 && TableauMemoire.UnVUnCochon == false)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(false);
            TextPartie3d.SetActive(false);
            AmiDuChien.SetActive(isActive);
        }

        //Mission 4-----------------------------------------------------------
        if (TableauMemoire.masque == 0 && TableauMemoire.SecretSurCerf == true && stepTalke == 2 && passTalking == true && TableauMemoire.UnVUnCochon == false)
            {
                isActive = true;
                TextPartie4.SetActive(true);
                TextPartie41.SetActive(false);
                TextPartie42.SetActive(false);
                stepTalke = 3;
            }
            else if (TableauMemoire.masque == 0 && TableauMemoire.SecretSurCerf == true && stepTalke == 3 && passTalking == true)
            {
                TextPartie4.SetActive(false);
                TextPartie41.SetActive(true);
                TextPartie42.SetActive(false);
                stepTalke = 4;
            }
            else if (TableauMemoire.masque == 0 && TableauMemoire.SecretSurCerf == true && stepTalke == 4 && passTalking == true)
            {
                TextPartie4.SetActive(false);
                TextPartie41.SetActive(false);
                TextPartie42.SetActive(true);
                autoHideVideo.Video();
                TableauMemoire.Portail = true;
                stepTalke = 5;
            }
            else if (TableauMemoire.masque == 0 && TableauMemoire.SecretSurCerf == true && stepTalke == 5 && passTalking == true)
            {
                TextPartie4.SetActive(false);
                TextPartie41.SetActive(false);
                TextPartie42.SetActive(false);
                stepTalke = 6;

            }
            else if (TableauMemoire.masque == 0 && TableauMemoire.SecretSurCerf == true && stepTalke == 6 && passTalking == true)
            {
                TextPartie4.SetActive(false);
                TextPartie41.SetActive(false);
                TextPartie42.SetActive(false);
                stepTalke = 2; // On boucle
            }


        //Mission5----------------------------------------------------------------------
        if (TableauMemoire.Partie2 == true && TableauMemoire.CochonHagrad == true && CountPartie2 == 0 && TableauMemoire.UnVUnCochon == false)
        {
            AneChap8.SetActive(true);
            CountPartie2 = 1;
            return;
        }

        if (TableauMemoire.Partie2 == true && TableauMemoire.CochonHagrad == true && CountPartie2 == 1 && TableauMemoire.UnVUnCochon == false)
        {
            AneChap8.SetActive(false);
            TextRevelCochon.SetActive(true);
            TextRevelCochon2.SetActive(false);
            TextRevelCochon3.SetActive(false);
            CountPartie2 = 2;
        }
        else if (TableauMemoire.Partie2 == true && TableauMemoire.CochonHagrad == true && CountPartie2 == 2 && TableauMemoire.UnVUnCochon == false)
        {
            TextRevelCochon.SetActive(false);
            TextRevelCochon2.SetActive(true);
            TextRevelCochon3.SetActive(false);
            CountPartie2 =3;
        }
        else if (TableauMemoire.Partie2 == true && TableauMemoire.CochonHagrad == true && CountPartie2 == 3 && TableauMemoire.UnVUnCochon == false)
        {
            TextRevelCochon.SetActive(false);
            TextRevelCochon2.SetActive(false);
            TextRevelCochon3.SetActive(true);
            autoHideVideo.Video();

            CountPartie2 = 4;
        }
        else if (TableauMemoire.Partie2 == true && TableauMemoire.CochonHagrad == true && CountPartie2 == 4 && TableauMemoire.UnVUnCochon == false)
        {
            TextRevelCochon.SetActive(false);
            TextRevelCochon2.SetActive(false);
            TextRevelCochon3.SetActive(false);
            TableauMemoire.RevelSNAKE = true;
            CountPartie2 = 0;
        }
        
        if (TableauMemoire.UnVUnCochon == true &&TableauMemoire.END == false)
        {
            isActive = !isActive;
            HibouxCave.SetActive(isActive);
        }
        if (TableauMemoire.END == true)
        {
            isActive = !isActive;
            END.SetActive(isActive);
            
        }
        
    }
    public void Choix1()
    {
        if (!isTalking)return;
    
        


    }
    public void Choix2()
    {
        if (!isTalking)return;
    
        

    }
    public void Choix3()
    {
        if (!isTalking)return;
    
        
        
    }

}
