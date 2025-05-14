using UnityEngine;

public class Chien : MonoBehaviour , IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;
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


    private int textCount=0;



    private bool isActive = false;
    private bool isTalking = false;


    private void Start()
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

        //mission1
        TableauMemoire.talkChien = true;
        isActive = !isActive;
        if (TableauMemoire.masque==0 && textCount==0)
        {
            bulleDeText.SetActive(isActive);
        }
        

        //Mission2:--------------------------------------------------------------------

        if (TableauMemoire.masque==0 && TableauMemoire.confidenceCerf==true && textCount==0)
        {
            bulleDeText.SetActive(false);
            bulleTextPartie2.SetActive(isActive);
            textCount = 1;
        } //Mission3--------------------------------------------
        else if (TableauMemoire.masque==0 && TableauMemoire.confidenceCerf==true && textCount==1)
        {
            
            bulleDeText.SetActive(false);
            TextMA.SetActive(isActive);
            
        }

        if (TableauMemoire.masque==1 && TableauMemoire.AmiChien==false)
        {
            TextPartie3.SetActive(true);
            TableauMemoire.MLoupFound=true;
            TableauMemoire.confidenceCerf=false;
        }
        
        if (TableauMemoire.AmiChien==true && !(TableauMemoire.masque==2))
        {
            TextPartie3.SetActive(false);
            RespectText.SetActive(isActive);
        }

        //Mission5----------------------------------------------------------------------

        if(TableauMemoire.masque==2)
        {
            TableauMemoire.MLionFound=true;
            
            TextPartie5.SetActive(isActive);
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
