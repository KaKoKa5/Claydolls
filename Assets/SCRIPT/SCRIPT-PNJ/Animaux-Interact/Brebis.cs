using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Brebis : MonoBehaviour ,IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;

    [SerializeField] private GameObject STARTText;
[SerializeField] private GameObject STARTText2;
    //Mission1:
    [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;

    //Mission2:
    [SerializeField] private GameObject TextPartie2;
    [SerializeField] private GameObject choix1TextPartie2;
    [SerializeField] private GameObject choix2TextPartie2;

    //Mission3:
    [SerializeField] private GameObject TextPartie3;
    [SerializeField] private GameObject choix1TextPartie3;
    [SerializeField] private GameObject choix2TextPartie3;
    [SerializeField] private GameObject bulleDeTextAmiChien;

    //Mission5:
    [SerializeField] private GameObject TextPartie5;
    [SerializeField] private GameObject choix1TextPartie5;
    [SerializeField] private GameObject choix2TextPartie5;
    [SerializeField] private GameObject choix3TextPartie5;

    //PARTIE2
    [SerializeField] private GameObject TextPartie2A;
    [SerializeField] private GameObject TextPartie2L;
    [SerializeField] private GameObject TextPartie2LL;

    //PARTIE2chap10-----------------------------------------------
    [SerializeField] private GameObject RevelSNAKE;
    [SerializeField] private GameObject RevelSNAKEchoix1;
    [SerializeField] private GameObject RevelSNAKEchoix1p;
    [SerializeField] private GameObject RevelSNAKEchoix2;
    [SerializeField] private GameObject RevelSNAKEchoix3;
    [SerializeField] private GameObject RevelSNAKEchoix3m;
    [SerializeField] private GameObject RevelSNAKEAnge;
    [SerializeField] private GameObject RevelSNAKEDevil;
    [SerializeField] private GameObject RevelSNAKEDevil2;

    // CHAP13

    [SerializeField] private GameObject HibouxCave;

    //END
    [SerializeField] private GameObject END;

    //Dialogue Peau D'Ane
    [SerializeField] private GameObject AneChoix1;
    [SerializeField] private GameObject AneChoix2;
    [SerializeField] private GameObject AneChoix3;

    [SerializeField] private GameObject AneChapitre4Choix1;
    [SerializeField] private GameObject AneChapitre4Choix2;

    [SerializeField] private GameObject AneChapitre5Choix1;
    [SerializeField] private GameObject AneChapitre5Choix2;

    [SerializeField] private GameObject AneChapitre8Choix1;
    [SerializeField] private GameObject AneChapitre8Choix2;
    [SerializeField] private GameObject AneChapitre8Choix3;

    [SerializeField] private GameObject AneChapitre10Choix1;
    [SerializeField] private GameObject AneChapitre10Choix2;
    [SerializeField] private GameObject AneChapitre10Choix3;
    [SerializeField] private GameObject AneChapitre10Choix3A;
    [SerializeField] private GameObject AneChapitre10ChoixA;
    [SerializeField] private GameObject AneChapitre10ChoixD;

    private bool isActive = false;
    private bool isTalking = false;
    private bool secret = false;
    private int CountText = 0;
    private int Count = 0;
    private int Counte = 0;
    private int CountC1 = 0;
    private int CountC2 = 0;
    private int CountC3 = 0;
    private int CountC1Chap4 = 0;
    private int CountC2Chap4 = 0;
    
    private int CountC1Chap5 = 0;
    private int CountC2Chap5 = 0;

    private int CountC1Chap8 = 0;
    private int CountC2Chap8 = 0;
    private int CountC3Chap8 = 0;
    
    private int CountC1Chap10 = 0;
    private int CountC2Chap10 = 0;
    private int CountC3Chap10 = 0;
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
        //Mission1
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);

        //Mission2
        TextPartie2.SetActive(false);
        choix1TextPartie2.SetActive(false);
        choix2TextPartie2.SetActive(false);

        //Mission3

        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);
        bulleDeTextAmiChien.SetActive(false);
        //Mission5

        TextPartie5.SetActive(false);
        choix1TextPartie5.SetActive(false);
        choix2TextPartie5.SetActive(false);
        choix3TextPartie5.SetActive(false);

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);

        //__________________________________________________________________________

        RevelSNAKE.SetActive(false);
        RevelSNAKEchoix1.SetActive(false);
        RevelSNAKEchoix1p.SetActive(false);
        RevelSNAKEchoix2.SetActive(false);
        RevelSNAKEchoix3.SetActive(false);
        RevelSNAKEchoix3m.SetActive(false);
        RevelSNAKEAnge.SetActive(false);
        RevelSNAKEDevil.SetActive(false);
        RevelSNAKEDevil2.SetActive(false);


        HibouxCave.SetActive(false);

        END.SetActive(false);

        // Peau D'Ane
        AneChoix1.SetActive(false);
        AneChoix2.SetActive(false);
        AneChoix3.SetActive(false);

        AneChapitre4Choix1.SetActive(false);
        AneChapitre4Choix2.SetActive(false);

        AneChapitre5Choix1.SetActive(false);
        AneChapitre5Choix2.SetActive(false);

        AneChapitre8Choix1.SetActive(false);
        AneChapitre8Choix2.SetActive(false);
        AneChapitre8Choix3.SetActive(false);

        AneChapitre10Choix1.SetActive(false);
        AneChapitre10Choix2.SetActive(false);
        AneChapitre10Choix3.SetActive(false);
        AneChapitre10Choix3A.SetActive(false);
        AneChapitre10ChoixA.SetActive(false);
        AneChapitre10ChoixD.SetActive(false);




    }

    public void Interact()
    {
        NotMove();
        //mission1-------------------------------------------------------------------
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);
        //Mission2
        TextPartie2.SetActive(false);
        choix1TextPartie2.SetActive(false);
        choix2TextPartie2.SetActive(false);

        //Mission3

        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);
        bulleDeTextAmiChien.SetActive(false);
        //Mission5

        TextPartie5.SetActive(false);
        choix1TextPartie5.SetActive(false);
        choix2TextPartie5.SetActive(false);
        choix3TextPartie5.SetActive(false);
        isTalking = true;

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);
        // Peau D'Ane
        AneChoix1.SetActive(false);
        AneChoix2.SetActive(false);
        AneChoix3.SetActive(false);

        AneChapitre4Choix1.SetActive(false);
        AneChapitre4Choix2.SetActive(false);

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
            {FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
                STARTText.SetActive(false);
                STARTText2.SetActive(isActive);
                CountText = 2;
                return;
            }
            else if (CountText == 2)
            {FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
            Cursor.visible = true;
                STARTText2.SetActive(false);
                CountText = 1;
                return;
            }

        }
        TableauMemoire.talkBrebis = true;
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && TableauMemoire.talkFirst == true && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            CountText = 3;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && TableauMemoire.UnVUnCochon == false)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            isActive = !isActive;
            bulleDeTextAmiChien.SetActive(isActive);
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            TableauMemoire.MLionFound = true;
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }

        //PARTIE2----------------------------------------------------------------------------
        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie2A.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.RevelSNAKE == false)
        {
            isActive = !isActive;
            TextPartie2L.SetActive(isActive);
        }
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == true && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie2LL.SetActive(isActive);
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            RevelSNAKE.SetActive(isActive);
            RevelSNAKEAnge.SetActive(false);
            RevelSNAKEDevil2.SetActive(false);

        }

        if (TableauMemoire.UnVUnCochon == true && TableauMemoire.END == false)
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
        if (!isTalking) return;
        TextPartie2.SetActive(false);
        TextPartie3.SetActive(false);
        TextPartie5.SetActive(false);


        if (TableauMemoire.confidenceCerf == false && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && CountC1 == 0)
        {
            AneChoix1.SetActive(true);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            bulleDeText.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            choix1Text.SetActive(false);
            CountC1 = 1;
            return;
        }

        if (TableauMemoire.confidenceCerf == false && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && CountC1 == 1)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            bulleDeText.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            choix1Text.SetActive(true);
            CountC1 = 2;
        }

        //Mission2:----------------------------------------------
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0 && CountC1Chap4 == 0)
        {
            choix1Text.SetActive(false);
            TextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(false);
            AneChapitre4Choix1.SetActive(true);
            AneChapitre4Choix2.SetActive(false);
            CountC1Chap4 = 1;
            return;
        }
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0 && CountC1Chap4 == 1)
        {
            choix1Text.SetActive(false);
            TextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(true);
            choix2TextPartie2.SetActive(false);
            AneChapitre4Choix1.SetActive(false);
            AneChapitre4Choix2.SetActive(false);
            CountC1Chap4 = 0;
            return;
        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountC1Chap5==0)
        {
            AneChapitre5Choix1.SetActive(true);
            AneChapitre5Choix2.SetActive(false);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(false);


            CountC1Chap5 = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountC1Chap5==1)
        {
            AneChapitre5Choix1.SetActive(false);
            AneChapitre5Choix2.SetActive(false);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(true);
            choix2TextPartie3.SetActive(false);

            autoHideVideo.Video();

            CountC1Chap5 = 0;
            return;
        }
        //Mission5----------------------------------------------------------------------
        
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && CountC1Chap8==0)
        {
            RevelSNAKE.SetActive(false);
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(false);
            choix2TextPartie5.SetActive(false);
            choix3TextPartie5.SetActive(false);

            AneChapitre8Choix1.SetActive(true);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);
            CountC1Chap8 = 1;
            return;
        }

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && CountC1Chap8 == 1)
        {
            RevelSNAKE.SetActive(false);
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(true);
            choix2TextPartie5.SetActive(false);
            choix3TextPartie5.SetActive(false);

            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);
            CountC1Chap8 = 0;
            return;
        }

        //------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Count == 0 && CountC1Chap10 == 0 && secret==false)
        {
            AneChapitre10Choix1.SetActive(true);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix1.SetActive(false);
            CountC1Chap10 = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Count == 0 && CountC1Chap10 == 1)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix1.SetActive(true);
            Count = 1;
            CountC1Chap10 = 2;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Count == 1)
        {
            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix1.SetActive(false);
            RevelSNAKEchoix1p.SetActive(true);

            Count = 2;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Count == 2)
        {
            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix1.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);
            Count = 3;
            return;
        }
        //--------------------------------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 3 && secret == true && CountC3Chap10 == 2)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(true);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix3m.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);
            RevelSNAKEAnge.SetActive(false);
            CountC1Chap10 = 3;
            Counte = 4;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 4 && secret == true && CountC1Chap10 == 3)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix3m.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);
            RevelSNAKEAnge.SetActive(true);
        }

    }
    public void Choix2()
    {
        if (!isTalking) return;
        TextPartie2.SetActive(false);
        TextPartie3.SetActive(false);
        TextPartie5.SetActive(false);
        // Peau D'Ane
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && CountC2 == 0)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(true);
            AneChoix3.SetActive(false);

            CountC2 = 1;

            bulleDeText.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            choix1Text.SetActive(false);
            return;
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && CountC2 == 1)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            CountC2 = 2;

            bulleDeText.SetActive(false);
            choix2Text.SetActive(true);
            choix3Text.SetActive(false);
            choix1Text.SetActive(false);
            return;
        }

        //Mission2:----------------------------------------------------------
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0 && CountC2Chap4==0)
        {
            TextPartie2.SetActive(false);
            choix2Text.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(false);
            AneChapitre4Choix1.SetActive(false);
            AneChapitre4Choix2.SetActive(true);
            CountC2Chap4 = 1;
            return;

        }
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0 && CountC2Chap4 == 1)
        {
            TextPartie2.SetActive(false);
            choix2Text.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(true);
            AneChapitre4Choix1.SetActive(false);
            AneChapitre4Choix2.SetActive(false);
            CountC2Chap4 = 0;
            return;

        }

        //Mission3:----------------------------------------------------------
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountC2Chap5==0)
        {

            AneChapitre5Choix1.SetActive(false);
            AneChapitre5Choix2.SetActive(true);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(false);
            CountC2Chap5 = 1;
            return;

        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountC2Chap5 == 1)
        {

            AneChapitre5Choix1.SetActive(false);
            AneChapitre5Choix2.SetActive(false);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(true);
            CountC2Chap5 = 0;
            return;

        }
        //Mission5----------------------------------------------------------------------
        
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && CountC2Chap8==0)
        {
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(false);
            choix2TextPartie5.SetActive(false);
            choix3TextPartie5.SetActive(false);

            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(true);
            AneChapitre8Choix3.SetActive(false);
            CountC2Chap8 = 1;
            return;
        }

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && CountC2Chap8 == 1)
        {
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(false);
            choix2TextPartie5.SetActive(true);
            choix3TextPartie5.SetActive(false);

            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);
            CountC2Chap8 = 0;
            return;
        }

        //--------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && TableauMemoire.Partie2 == true && CountC2Chap10 == 0)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(true);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKEchoix1.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);
            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(false);
            CountC2Chap10 = 1;
            return;
            
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && TableauMemoire.Partie2 == true && CountC2Chap10 == 1)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKEchoix1.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);
            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(isActive);
        }
    }
    public void Choix3()
    {
        if (!isTalking) return;

        TextPartie2.SetActive(false);
        TextPartie3.SetActive(false);
        TextPartie5.SetActive(false);
        // Peau D'Ane

        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && CountC3 == 0)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(true);
            CountC3 = 1;
            bulleDeText.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            choix1Text.SetActive(false);
            return;
        }


        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && CountC3 == 1)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);
            CountC3 = 0;
            bulleDeText.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(true);
            choix1Text.SetActive(false);
            return;
        }
        //Mission2:
        if (TableauMemoire.confidenceCerf == true)
        {
            choix3Text.SetActive(false);
            TextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(false);

        }
        //Mission5----------------------------------------------------------------------
        
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && CountC3Chap8==0)
        {
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(false);
            choix2TextPartie5.SetActive(false);
            choix3TextPartie5.SetActive(false);

            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(true);
            CountC3Chap8 = 1;
            return;
        }

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && CountC3Chap8 == 1)
        {
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(false);
            choix2TextPartie5.SetActive(false);
            choix3TextPartie5.SetActive(true);

            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);
            CountC3Chap8 = 0;
            return;
        }

        //-----------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 0 && CountC3Chap10 == 0)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(true);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(false);
            RevelSNAKEchoix3.SetActive(false);
            RevelSNAKEchoix1.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);

            CountC3Chap10 = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 0 && CountC3Chap10 == 1)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(false);
            RevelSNAKEchoix3.SetActive(true);
            RevelSNAKEchoix1.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);
            Counte = 1;
            return;
        }

        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 1)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3A.SetActive(true);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(false);
            RevelSNAKEchoix3.SetActive(false);
            RevelSNAKEchoix1.SetActive(false);
            RevelSNAKEchoix1p.SetActive(false);

            Counte = 2;
            return;
        }

        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 2)
        {
            RevelSNAKEchoix3m.SetActive(true);
            RevelSNAKE.SetActive(false);

            AneChapitre10Choix3A.SetActive(false);

            RevelSNAKEchoix2.SetActive(false);
            RevelSNAKEchoix3.SetActive(false);
            secret = true;
            CountC3Chap10 = 2;
            Counte = 3;
            return;
        }
        //--------------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 3 && secret == true && CountC3Chap10 == 2)
        {

            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(true);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(false);
            RevelSNAKEchoix3m.SetActive(false);
            RevelSNAKEAnge.SetActive(false);
            RevelSNAKEDevil.SetActive(false);
            Counte = 4;
            CountC3Chap10 = 3;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 4 && secret == true && CountC3Chap10 == 3)
        {
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(false);
            RevelSNAKEchoix3m.SetActive(false);
            RevelSNAKEAnge.SetActive(false);
            RevelSNAKEDevil.SetActive(true);
            Counte = 5;
            return;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 5 && secret == true)
        {
            RevelSNAKE.SetActive(false);
            RevelSNAKEDevil.SetActive(false);
            AneChapitre10Choix1.SetActive(false);
            AneChapitre10Choix2.SetActive(false);
            AneChapitre10Choix3.SetActive(false);
            AneChapitre10ChoixA.SetActive(false);
            AneChapitre10ChoixD.SetActive(false);

            RevelSNAKE.SetActive(false);
            RevelSNAKEchoix2.SetActive(false);
            RevelSNAKEchoix3m.SetActive(false);
            RevelSNAKEAnge.SetActive(false);
            RevelSNAKEDevil.SetActive(false);
            RevelSNAKEDevil2.SetActive(isActive);
            autoHideVideo.Video();
            TableauMemoire.HibouxFound = true;
            return;

        }

    }


}

