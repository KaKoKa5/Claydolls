using UnityEngine;

public class Chien : MonoBehaviour , IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;

    [SerializeField] private GameObject STARTText;
    [SerializeField] private GameObject STARTText2;
     [SerializeField] private GameObject bulleDeText;
    
    [SerializeField] private GameObject bulleTextPartie2;
    [SerializeField] private GameObject choix1TextPartie2;
    [SerializeField] private GameObject choix2TextPartie2;
    [SerializeField] private GameObject choix3TextPartie2;
  
  //Mission3------------------------------------------
    [SerializeField] private GameObject TextMA;
    [SerializeField] private GameObject TextPartie3;
    [SerializeField] private GameObject choix1TextPartie3;
    [SerializeField] private GameObject choix2TextPartie3;
    [SerializeField] private GameObject choix3TextPartie3;
    [SerializeField] private GameObject RespectText;

    //Mission5:
    [SerializeField] private GameObject TextPartie5;
    
    //PARTIE2
    [SerializeField] private GameObject TextPartie2A;
    [SerializeField] private GameObject TextPartie2L;
    [SerializeField] private GameObject TextPartie2LL;

    [SerializeField] private GameObject HibouxCave;

//END
    [SerializeField] private GameObject END;
    private int textCount = 0;


    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;


    private void Start()
    {
        CountText = 0;
        STARTText.SetActive(false);
        STARTText2.SetActive(false);
        bulleDeText.SetActive(false);

        //Mission2:

        bulleTextPartie2.SetActive(false);
        choix1TextPartie2.SetActive(false);
        choix2TextPartie2.SetActive(false);
        choix3TextPartie2.SetActive(false);

        //Mission3-----------------------------
        TextMA.SetActive(false);
        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);
        choix3TextPartie3.SetActive(false);
        RespectText.SetActive(false);

        //Mission5
        TextPartie5.SetActive(false);

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);

        HibouxCave.SetActive(false);
        
        END.SetActive(false);
    }
    public void Interact()
    {

        bulleDeText.SetActive(false);

        //Mission2:

        bulleTextPartie2.SetActive(false);
        choix1TextPartie2.SetActive(false);
        choix2TextPartie2.SetActive(false);
        choix3TextPartie2.SetActive(false);

        //Mission3-----------------------------
        TextMA.SetActive(false);
        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);
        choix3TextPartie3.SetActive(false);
        RespectText.SetActive(false);

        //Mission5
        TextPartie5.SetActive(false);
        isTalking = true;

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);

        //mission1
        if (TableauMemoire.talkFirst == false)
        {
            if (CountText == 0)
            {
                isActive = !isActive;
                STARTText.SetActive(isActive);
                CountText = 1;
                return; // Empêche la suite du code de s'exécuter
            }
            else if (CountText == 1)
            {
                STARTText.SetActive(false);
                STARTText2.SetActive(isActive);
                CountText = 2;
                return; // Empêche aussi ici
            }
            else if (CountText == 2)
            {
                STARTText2.SetActive(false);
                CountText = 1;
                return;
            }

        }

        // À partir d’ici, les STARTText sont terminés

        TableauMemoire.talkChien = true;

        if (TableauMemoire.masque == 0 && textCount == 0 && TableauMemoire.talkFirst == true && TableauMemoire.UnVUnCochon == false)
        {
            CountText = 3;
            isActive = !isActive;
            STARTText2.SetActive(false);
            bulleDeText.SetActive(isActive);
        }


        //Mission2:--------------------------------------------------------------------

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == true && textCount == 0)
        {

            bulleDeText.SetActive(false);
            bulleTextPartie2.SetActive(isActive);
            textCount = 1;
        } //Mission3--------------------------------------------
        else if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == true && textCount == 1)
        {
            isActive = !isActive;
            bulleDeText.SetActive(false);
            TextMA.SetActive(isActive);

        }

        if (TableauMemoire.masque == 1 && TableauMemoire.AmiChien == false && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
            TableauMemoire.MLoupFound = true;
            TableauMemoire.confidenceCerf = false;
        }

        if (TableauMemoire.AmiChien == true && !(TableauMemoire.masque == 2))
        {
            isActive = !isActive;
            TextPartie3.SetActive(false);
            RespectText.SetActive(isActive);
        }

        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            TableauMemoire.MLionFound = true;
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }
        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true)
        {
            isActive = !isActive;
            TextPartie2A.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true)
        {
            isActive = !isActive;
            TextPartie2L.SetActive(isActive);
        }
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == true)
        {
            isActive = !isActive;
            TextPartie2LL.SetActive(isActive);
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
        if (TableauMemoire.confidenceCerf==false && TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
        }

        if (TableauMemoire.confidenceCerf==true&& TableauMemoire.masque==0)
        {
            TextMA.SetActive(false);
            bulleDeText.SetActive(false);
            bulleTextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(true);
            choix2TextPartie2.SetActive(false);
            choix3TextPartie2.SetActive(false);
            
        }
         //Mission3--------------------------------------------

        if (TableauMemoire.masque==1)
        {
            autoHideVideo.Video();
            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(true);
            choix2TextPartie3.SetActive(false);
            choix3TextPartie3.SetActive(false);
            RespectText.SetActive(false);
            TableauMemoire.AmiChien=true;
        }

    }
    public void Choix2()
    {
        if (!isTalking)return;
         if (TableauMemoire.confidenceCerf==false && TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
        }

        if (TableauMemoire.confidenceCerf==true&& TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
            TextMA.SetActive(false);
            bulleTextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(true);
            choix3TextPartie2.SetActive(false);
            TableauMemoire.PlancheMaisonLoup = true;
            autoHideVideo.Video();
        }
         //Mission3--------------------------------------------
        if (TableauMemoire.masque==1)
        {
            choix2TextPartie2.SetActive(false);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(true);
            choix3TextPartie3.SetActive(false);
            RespectText.SetActive(false);
        }
    }
    public void Choix3()
    {
        if (!isTalking)return;
    
        if (TableauMemoire.confidenceCerf==false && TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
        }

        if (TableauMemoire.confidenceCerf==true&& TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
            TextMA.SetActive(false);
            bulleTextPartie2.SetActive(false);
            choix1TextPartie2.SetActive(false);
            choix2TextPartie2.SetActive(false);
            choix3TextPartie2.SetActive(true);
        }
         //Mission3--------------------------------------------
        if (TableauMemoire.masque==1)
        {
            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(false);
            choix3TextPartie3.SetActive(true);
            RespectText.SetActive(false);
        }
    }

    }
