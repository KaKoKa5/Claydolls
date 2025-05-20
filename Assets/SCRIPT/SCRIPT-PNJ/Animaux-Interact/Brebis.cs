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
    [SerializeField] private GameObject choix3TextPartie2;

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

    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;
    private int Count = 0;
    private int Counte = 0;



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
        choix3TextPartie2.SetActive(false);

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


    }

    public void Interact()
    {
        //mission1-------------------------------------------------------------------
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);
        //Mission2
        TextPartie2.SetActive(false);
        choix1TextPartie2.SetActive(false);
        choix2TextPartie2.SetActive(false);
        choix3TextPartie2.SetActive(false);

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
        TableauMemoire.talkBrebis = true;
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && TableauMemoire.talkFirst == true && TableauMemoire.Partie2 == false)
        {
            CountText = 3;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true)
        {
            isActive = !isActive;
            bulleDeTextAmiChien.SetActive(isActive);
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false)
        {
            TableauMemoire.MLionFound = true;
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }

        //PARTIE2----------------------------------------------------------------------------
        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true)
        {
            isActive = !isActive;
            TextPartie2A.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.RevelSNAKE == false)
        {
            isActive = !isActive;
            TextPartie2L.SetActive(isActive);
        }
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == true)
        {
            isActive = !isActive;
            TextPartie2LL.SetActive(isActive);
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true)
        {
            isActive = !isActive;
            RevelSNAKE.SetActive(isActive);
        }

    }

    public void Choix1()
    {
        if (!isTalking) return;
        TextPartie2.SetActive(false);
        TextPartie3.SetActive(false);
        TextPartie5.SetActive(false);

        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false)
        {
            bulleDeText.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            choix1Text.SetActive(true);
        }

        //Mission2:----------------------------------------------
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0)
        {
            choix1Text.SetActive(false);
            TextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(true);
            choix2TextPartie2.SetActive(false);
            choix3TextPartie2.SetActive(false);

        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(true);
            choix2TextPartie3.SetActive(false);

            autoHideVideo.Video();


        }
        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false)
        {
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(true);
            choix2TextPartie5.SetActive(false);
            choix3TextPartie5.SetActive(false);

        }
        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Count == 0)
        {
            isActive = !isActive;
            RevelSNAKEchoix1.SetActive(isActive);
            Count = 1;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Count == 1)
        {
            RevelSNAKEchoix1p.SetActive(isActive);

            Count = 2;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Count == 2)
        {
            RevelSNAKEAnge.SetActive(isActive);
            Count = 0;
        }

    }
    public void Choix2()
    {
        if (!isTalking) return;
        TextPartie2.SetActive(false);
        TextPartie3.SetActive(false);
        TextPartie5.SetActive(false);
        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false)
        {
            bulleDeText.SetActive(false);
            choix2Text.SetActive(true);
            choix3Text.SetActive(false);
            choix1Text.SetActive(false);
        }

        //Mission2:----------------------------------------------------------
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0)
        {
            TextPartie2.SetActive(false);
            choix2Text.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(true);
            choix3TextPartie2.SetActive(false);

        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(true);

        }
        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false)
        {
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(false);
            choix2TextPartie5.SetActive(true);
            choix3TextPartie5.SetActive(false);

        }
        
        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true)
        {
            isActive = !isActive;
            RevelSNAKEchoix2.SetActive(isActive);   
        }
    }
    public void Choix3()
    {
        if (!isTalking) return;

        TextPartie2.SetActive(false);
        TextPartie3.SetActive(false);
        TextPartie5.SetActive(false);

        if (TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false)
        {
            bulleDeText.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(true);
            choix1Text.SetActive(false);
        }
        //Mission2:
        if (TableauMemoire.confidenceCerf == true)
        {
            choix3Text.SetActive(false);
            TextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(false);
            choix3TextPartie2.SetActive(true);

        }
        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false)
        {
            TextPartie5.SetActive(false);
            choix1TextPartie5.SetActive(false);
            choix2TextPartie5.SetActive(false);
            choix3TextPartie5.SetActive(true);

        }

        if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 0)
        {
            isActive = !isActive;
            RevelSNAKEchoix3.SetActive(isActive);
            Counte = 1;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 1)
        {
            RevelSNAKEchoix3m.SetActive(isActive);

            Counte = 2;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte == 2)
        {
            RevelSNAKEDevil.SetActive(isActive);
            Counte = 3;
        }
        else if (TableauMemoire.masque == 1 && TableauMemoire.RevelSNAKE == true && Counte ==3)
        {
            RevelSNAKEDevil2.SetActive(isActive);
            Counte = 2;
        }

    }


}

