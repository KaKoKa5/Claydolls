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
 [SerializeField] private GameObject TextPartie43;
 [SerializeField] private GameObject AmiDuChien;

 //Mission6:
    [SerializeField] private GameObject TextPartie6;

 


    private bool isActive = false;
    private bool isTalking = false;
    private bool passTalking = false;
    private int stepTalk=0;
    private int stepTalke=0;
    private int stepTalkPartie6=0;
    private int CountText=0;



    private void Start()
    {

        STARTText.SetActive(false);
        STARTText2.SetActive(false);

        bulleDeText.SetActive(false);
        TextPartie2.SetActive(false);

        TextPartie3.SetActive(false);
        TextPartie3d.SetActive(false);
        stepTalk=0;

        TextPartie4.SetActive(false);
        TextPartie41.SetActive(false);
        TextPartie42.SetActive(false);
        TextPartie43.SetActive(false);

        AmiDuChien.SetActive(false);

        //Mission6
        TextPartie6.SetActive(false);
        stepTalke=0;

    }
    public void Interact()
    {
  
        bulleDeText.SetActive(false);
        TextPartie2.SetActive(false);

        TextPartie3.SetActive(false);
        TextPartie3d.SetActive(false);

        TextPartie4.SetActive(false);
        TextPartie41.SetActive(false);
        TextPartie42.SetActive(false);
        TextPartie43.SetActive(false);

        AmiDuChien.SetActive(false);

        //Mission6
        TextPartie6.SetActive(false);


        isTalking = true;
        isActive = !isActive;
        
        //mission1-----------------------------------------
        TableauMemoire.talkSerpent = true;
        if (TableauMemoire.masque==0 && TableauMemoire.SecretSurCerf==false)
        {
            
            bulleDeText.SetActive(isActive);
        }
        
        if (TableauMemoire.masque==0 &&TableauMemoire.confidenceCerf==true)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }
        
        //Mission 3 ------------------------------------------------------------
        if(TableauMemoire.masque==1 && stepTalk==0)
        {
            isActive = !isActive;
            TextPartie3.SetActive(true);
            stepTalk = 1;
            
        }
        else if(stepTalk==1 && TableauMemoire.masque==1)
        {
            TextPartie3.SetActive(false);
            
            TextPartie3d.SetActive(isActive);
            passTalking=true;
        }
        

        if (TableauMemoire.AmiChien==true && TableauMemoire.SecretSurCerf==false && TableauMemoire.masque==0)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(false);
            TextPartie3d.SetActive(false);
            AmiDuChien.SetActive(isActive);
        }

        //Mission 4-----------------------------------------------------------

        if (TableauMemoire.masque==0 && TableauMemoire.SecretSurCerf==true && stepTalke == 0 && passTalking == true)
        {
            isActive = true;
            TextPartie4.SetActive(true);
            TextPartie41.SetActive(false);
            TextPartie42.SetActive(false);
            TextPartie43.SetActive(false);
            stepTalke = 3;
        }
        else if (TableauMemoire.masque==0 && TableauMemoire.SecretSurCerf==true && stepTalke == 3 && passTalking == true)
        {
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(true);
            TextPartie42.SetActive(false);
            TextPartie43.SetActive(false);
            stepTalke = 4;
        }
        else if (TableauMemoire.masque==0 && TableauMemoire.SecretSurCerf==true && stepTalke == 4 && passTalking == true)
        {
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(false);
            TextPartie42.SetActive(true);
            TextPartie43.SetActive(false);
            autoHideVideo.Video();
            stepTalke = 5;
        }
        else if (TableauMemoire.masque==0 && TableauMemoire.SecretSurCerf==true && stepTalke == 5 && passTalking == true)
        {
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(false);
            TextPartie42.SetActive(false);
            TextPartie43.SetActive(true);
            stepTalke = 6;

        }else if (TableauMemoire.masque==0 && TableauMemoire.SecretSurCerf==true && stepTalke == 6 && passTalking == true)
        {
            TextPartie4.SetActive(false);
            TextPartie41.SetActive(false);
            TextPartie42.SetActive(false);
            TextPartie43.SetActive(false);
            stepTalke = 0; // On boucle
        }


        //Mission5----------------------------------------------------------------------

        if(TableauMemoire.masque==2)
        {
            TableauMemoire.MLionFound=true;
            TextPartie6.SetActive(false);
            isActive=!isActive;
            TextPartie6.SetActive(isActive);
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
