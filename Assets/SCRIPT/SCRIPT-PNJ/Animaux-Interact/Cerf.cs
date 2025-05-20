using UnityEngine;
using UnityEngine.Video;

// Interaction du PNJ vers le Joueur
public class Cerf : MonoBehaviour ,IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;

    [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;
    [SerializeField] private GameObject bulleTextEND;
    [SerializeField] private GameObject bulleTextENDPatie1;
    [SerializeField] private GameObject bulleTextPartie1;

    [SerializeField] private GameObject bulleTextDebutPartie1;
    [SerializeField] private GameObject textPartie3;
    [SerializeField] private GameObject AmiDuChien;

    //Mission5:
    [SerializeField] private GameObject TextPartie5;
    [SerializeField] private GameObject TextPartie51;
    [SerializeField] private GameObject TextPartie52;

    //PARTIE2
    [SerializeField] private GameObject TextPartie2A;
    [SerializeField] private GameObject TextPartie2L;
    [SerializeField] private GameObject TextPartie2LL;

    private int dialogueStep = 0;
    private bool isActive = false;
    private bool isTalking = false;


    private void Start()
    {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleTextEND.SetActive(false);
        bulleTextENDPatie1.SetActive(false);
        bulleTextPartie1.SetActive(false);
        bulleTextDebutPartie1.SetActive(false);

        textPartie3.SetActive(false);
        AmiDuChien.SetActive(false);

        //Mission5
        TextPartie5.SetActive(false);
        TextPartie51.SetActive(false);
        TextPartie52.SetActive(false);

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);

    }

    void Update()
    {
    
    }

    public void Interact()
    {
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);
        bulleTextEND.SetActive(false);
        bulleTextENDPatie1.SetActive(false);
        bulleTextPartie1.SetActive(false);
        bulleTextDebutPartie1.SetActive(false);

        textPartie3.SetActive(false);
        AmiDuChien.SetActive(false);

        //Mission5
        TextPartie5.SetActive(false);
        TextPartie51.SetActive(false);
        TextPartie52.SetActive(false);

        isTalking = true;

        //mission1
        TableauMemoire.talkCerf = true;

        if (!TableauMemoire.talkBrebis ||
        !TableauMemoire.talkCerf ||
        !TableauMemoire.talkChien ||
        !TableauMemoire.talkCochon ||
        !TableauMemoire.talkCorbeau ||
        !TableauMemoire.talkSerpent)
        {
            TableauMemoire.talkFirst = true;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
            return;
        }

        if (dialogueStep == 0 && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && TableauMemoire.Partie2 == false)
        {
            autoHideVideo.Video();
            bulleTextPartie1.SetActive(true);
            dialogueStep = 1;

        }  //Début Mission:2
        else if (dialogueStep == 1 && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && TableauMemoire.Partie2 == false)
        {
            bulleTextPartie1.SetActive(false);
            TableauMemoire.confidenceCerf = true;
            isActive = !isActive;
            bulleTextDebutPartie1.SetActive(isActive);
        }

        if (TableauMemoire.AmiChien == true && TableauMemoire.masque == 0 && TableauMemoire.MLionFound == false && TableauMemoire.Partie2 == false)
        {
            isActive = !isActive;
            AmiDuChien.SetActive(isActive);
        }


        if (TableauMemoire.masque == 1 && TableauMemoire.MLionFound == false && TableauMemoire.Partie2 == false)
        {
            isActive = !isActive;
            textPartie3.SetActive(isActive);
            return;
        }
        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false)
        {
            TableauMemoire.MLionFound = true;
            TextPartie5.SetActive(false);
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }

        if (TableauMemoire.MLionFound == true && TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            isActive = !isActive;
            TextPartie51.SetActive(isActive);
        }
        if (TableauMemoire.MLionFound == true && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true)
        {
            isActive = !isActive;
            TextPartie52.SetActive(isActive);
        }
        
        //PARTIE2----------------------------------------------------------------------------
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
        if(TableauMemoire.masque== 2&& TableauMemoire.Partie2==true)
        {
            isActive=!isActive;
            TextPartie2LL.SetActive(isActive);
        }
    }
    
    public void Choix1()
    {
        if (!isTalking)return;
        //mission1
        if (TableauMemoire.masque==0)
        {
        bulleDeText.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        isActive = !isActive;
        choix1Text.SetActive(true);
        }
        //Mission:2

    }
    public void Choix2()
    {
        if (!isTalking)return;
        //mission1
        if(TableauMemoire.masque==0)
        {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix3Text.SetActive(false);
        isActive = !isActive;
        choix2Text.SetActive(true);
        }
        //Mission:2
    }
    public void Choix3()
    {
        if (!isTalking)return;
        //mission1
        if(TableauMemoire.masque==0)
        {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        isActive = !isActive;
        choix3Text.SetActive(true);
        }
        //Mission:2
        
    }


}
