using UnityEngine;

public class Corbeaux : MonoBehaviour , IInteract
{
    public IconFader icon1;
    public IconFader icon2;
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

    [SerializeField] private GameObject HibouxCave;

    // FINAL
    [SerializeField] private GameObject TextFinal;
    [SerializeField] private GameObject TextFinal1;
    [SerializeField] private GameObject TextEND;
    [SerializeField] private GameObject TextEND1;
    [SerializeField] private GameObject TextEND2;
    [SerializeField] private GameObject TextEND3;
    [SerializeField] private GameObject TextEND4;
    [SerializeField] private GameObject TextEND5;
    [SerializeField] private GameObject TextEND6;

    //Dialogue Peau D'Ane
    [SerializeField] private GameObject AneChoix1;
    [SerializeField] private GameObject AneChoix2;
    [SerializeField] private GameObject AneChoix3;

    [SerializeField] private GameObject AneEND;
    [SerializeField] private GameObject AneEND2;
    [SerializeField] private GameObject boutonEXIT;
    [SerializeField] private GameObject boutonStay;


    private int CountC1 = 0;
    private int CountC2 = 0;
    private int CountC3 = 0;





    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;
    private int Count = 0;
    private int stepTalk = 3;
    private int num = 0;
    private int Fin = 0;
    private bool Talk = false; 
    public CharacterController playerController;
    public void NotMove()
    {

        Talk = !Talk;

        FindObjectOfType<CharaterMoovement>().controlsEnabled = !Talk;
        FindObjectOfType<AnimationStateController>().controlsEnabled = !Talk;
            

    }
    private void Awake()
    {
        icon1.FadeOut();
        icon2.FadeOut();
    }


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

        HibouxCave.SetActive(false);


        //FINAL
        TextFinal.SetActive(false);
        TextFinal1.SetActive(false);
        TextEND.SetActive(false);
        TextEND1.SetActive(false);
        TextEND2.SetActive(false);
        TextEND3.SetActive(false);
        TextEND4.SetActive(false);
        TextEND5.SetActive(false);
        TextEND6.SetActive(false);
        // Peau D'Ane
        AneChoix1.SetActive(false);
        AneChoix2.SetActive(false);
        AneChoix3.SetActive(false);

        AneEND2.SetActive(false);
        AneEND.SetActive(false);

        boutonEXIT.SetActive(false);
        boutonStay.SetActive(false);
        
    }
    void Update()
    {
        if (TableauMemoire.ICONCorbeau == true)
        {
            icon1.FadeIn();
        }
        else
        {
            icon1.FadeOut();
        }
        if (TableauMemoire.ICONPhenix == true)
        {
            icon2.FadeIn();
        }
        else
        {
            icon2.FadeOut();
        }
        
    }

    public void Interact()
    {
        NotMove();
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

        HibouxCave.SetActive(false);


        //FINAL
        TextFinal.SetActive(false);
        TextFinal1.SetActive(false);
        TextEND.SetActive(false);
        TextEND1.SetActive(false);
        TextEND2.SetActive(false);
        TextEND3.SetActive(false);
        TextEND4.SetActive(false);
        TextEND5.SetActive(false);
        TextEND6.SetActive(false);
        // Peau D'Ane
        AneChoix1.SetActive(false);
        AneChoix2.SetActive(false);
        AneChoix3.SetActive(false);

        AneEND2.SetActive(false);
        AneEND.SetActive(false);

        boutonEXIT.SetActive(false);
        boutonStay.SetActive(false);
        isTalking = true;

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
                FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
                FindObjectOfType<AnimationStateController>().controlsEnabled = false;
                STARTText.SetActive(false);
                STARTText2.SetActive(isActive);
                CountText = 2;
                return;
            }
            else if (CountText == 2)
            {
                FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
                FindObjectOfType<AnimationStateController>().controlsEnabled = true;
                Cursor.visible = true;
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
        if (TableauMemoire.AmiChien == false && TableauMemoire.masque == 0 && TableauMemoire.talkFirst == true && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            CountText = 3;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }

        //Mission2:----------------------------------------------
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission 4-------------------------------------------------
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && stepTalk == 4 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TableauMemoire.ICONCorbeau = false;
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextPartie41.SetActive(false);
            TextPartie42.SetActive(false);

            TextPartie4.SetActive(true);
            stepTalk = 1;
            return;
        }
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && stepTalk == 1)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            isActive = !isActive;
            TextPartie4.SetActive(false);
            TextPartie42.SetActive(false);

            TextPartie41.SetActive(true);
            stepTalk = 2;
            return;
        }
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && stepTalk == 2)
        {
            isActive = !isActive;
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(false);

            TextPartie42.SetActive(true);
            autoHideVideo.Video();
            TableauMemoire.SecretSurCerf = true;
            stepTalk = 3;
            return;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && stepTalk == 3)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
            FindObjectOfType<AnimationStateController>().controlsEnabled = true;
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(false);

            TextPartie42.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            TableauMemoire.SecretSurCerf = true;
            stepTalk = 4;
            TableauMemoire.ICONSerpent = true;
            return;
        }
        //Mission5----------------------------------------------------------------------
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            TableauMemoire.MLionFound = true;
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }


        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true && TableauMemoire.HibouxFound == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie2A.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie2L.SetActive(isActive);
        }
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == true && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie2LL.SetActive(isActive);
        }
        // Partie2Hiboux
        if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 0 && TableauMemoire.UnVUnCochon == false)
        {
            TableauMemoire.ICONCorbeau = false;
            TextPartieHiboux.SetActive(true);

            Count = 1;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 1)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(true);
            TextPartieHiboux1.SetActive(false);
            TextPartieHiboux2.SetActive(false);
            Count = 2;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 2)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(false);
            TextPartieHiboux1.SetActive(true);
            TextPartieHiboux2.SetActive(false);
            Count = 3;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 3)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(false);
            TextPartieHiboux1.SetActive(false);
            TextPartieHiboux2.SetActive(true);
            Count = 4;
        }
        else if (TableauMemoire.masque == 0 && TableauMemoire.HibouxFound == true && Count == 4)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
            FindObjectOfType<AnimationStateController>().controlsEnabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            TextPartieHiboux.SetActive(false);
            TextPartieHiboux0.SetActive(false);
            TextPartieHiboux1.SetActive(false);
            TextPartieHiboux2.SetActive(false);
            TableauMemoire.StoryCorbeau = true;
            autoHideVideo.Video();
            TableauMemoire.ICONCochon = true;
            Count = 0;
        }

        if (TableauMemoire.HibouxDEAD == false && TableauMemoire.UnVUnCochon == true)
        {
            isActive = !isActive;
            HibouxCave.SetActive(isActive);
            return;
        }


        if (TableauMemoire.masque == 0 && TableauMemoire.HibouxDEAD == true && TableauMemoire.UnVUnCochon == true && num == 0)
        {
            TableauMemoire.ICONCorbeau = false;
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            AneEND.SetActive(true);
            num++;
            return;
        }
        if (TableauMemoire.masque == 0 && TableauMemoire.HibouxDEAD == true && TableauMemoire.UnVUnCochon == true && num == 1)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            AneEND.SetActive(false);
            TextFinal1.SetActive(false);
            TextFinal.SetActive(true);
            num++;
            return;
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.HibouxDEAD == true && TableauMemoire.UnVUnCochon == true && num == 2)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            AneEND2.SetActive(true);
            TextFinal.SetActive(false);
            num++;
            return;
        }
        if (TableauMemoire.masque == 0 && TableauMemoire.HibouxDEAD == true && TableauMemoire.UnVUnCochon == true && num == 3)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextFinal.SetActive(false);
            AneEND2.SetActive(false);
            TextFinal1.SetActive(true);
            num++;
            autoHideVideo.Video();
            TableauMemoire.MaisonHibou = true;
            return;

        }
        if (TableauMemoire.masque == 0 && TableauMemoire.HibouxDEAD == true && TableauMemoire.UnVUnCochon == true && num == 4)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
            FindObjectOfType<AnimationStateController>().controlsEnabled = true;
            TextFinal.SetActive(false);
            AneEND2.SetActive(false);
            TextFinal1.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            num = 3;
            TableauMemoire.ICONPhenix=true;
            return;

        }


        if (TableauMemoire.masque == 3 && Fin == 0)
        {
            TableauMemoire.ICONCorbeau = false;
            TableauMemoire.ICONPhenix=false;
            TextEND.SetActive(true);
            Fin++;
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            return;
        }
        if (TableauMemoire.masque == 3 && Fin == 1)
        {

            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextEND.SetActive(false);
            TextEND1.SetActive(true);
            Fin++;
            return;
        }
        if (TableauMemoire.masque == 3 && Fin == 2)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextEND1.SetActive(false);
            TextEND2.SetActive(true);
            Fin++;
            return;
        }
        if (TableauMemoire.masque == 3 && Fin == 3)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextEND2.SetActive(false);
            TextEND3.SetActive(true);
            Fin++;
            return;
        }
        if (TableauMemoire.masque == 3 && Fin == 4)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextEND3.SetActive(false);
            TextEND4.SetActive(true);
            Fin++;
            return;
        }
        if (TableauMemoire.masque == 3 && Fin == 5)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextEND4.SetActive(false);
            TextEND5.SetActive(true);
            Fin++;
            return;
        }
        if (TableauMemoire.masque == 3 && Fin == 6)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            TextEND5.SetActive(false);
            TextEND6.SetActive(true);
            TableauMemoire.END = true;
            boutonEXIT.SetActive(true);
            boutonStay.SetActive(true);
            Fin++;
            Cursor.visible = false;
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            FindObjectOfType<AnimationStateController>().controlsEnabled = false;
            return;
        }
        if (TableauMemoire.masque == 3 && Fin == 7)
        {
            TextEND5.SetActive(false);
            TextEND6.SetActive(false);
            boutonEXIT.SetActive(false);
            boutonStay.SetActive(false);
            Fin = 6;
            Cursor.visible = true;
            FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
            FindObjectOfType<AnimationStateController>().controlsEnabled = true;
            return;
        }

    }
    public void Choix1()
    {
        if (!isTalking)return;
        if(TableauMemoire.confidenceCerf==true)return;
        
        if (TableauMemoire.AmiChien == false && CountC1==0)
        {
            // Peau D'Ane
            AneChoix1.SetActive(true);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            CountC1 = 1;
            return;
        }

        if (TableauMemoire.AmiChien == false && CountC1 == 1)
        {
            // Peau D'Ane
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            bulleDeText.SetActive(false);
            choix1Text.SetActive(true);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            CountC1 = 0;
            return;
        }

    }
    public void Choix2()
    {
        if (!isTalking)return;
        if(TableauMemoire.confidenceCerf==true)return;
        
        if (TableauMemoire.AmiChien == false && CountC2==0)
        {
            // Peau D'Ane
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(true);
            AneChoix3.SetActive(false);

            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            CountC2 = 1;
            return;
        }

        if (TableauMemoire.AmiChien == false && CountC2 == 1)
        {
            // Peau D'Ane
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            choix2Text.SetActive(true);
            choix3Text.SetActive(false);
            CountC2 = 0;
            return;
        }
    }
    public void Choix3()
    {
        if (!isTalking)return;
        if(TableauMemoire.confidenceCerf==true)return;
        
        if (TableauMemoire.AmiChien == false && CountC3==0)
        {
            // Peau D'Ane
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(true);

            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            CountC3 = 1;
            return;
        }

        if (TableauMemoire.AmiChien == false && CountC3 == 1)
        {
            // Peau D'Ane
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(true);
            CountC3 = 0;
            return;
        }
    }

}
