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

    [SerializeField] private GameObject HibouxCave;

    //END
    [SerializeField] private GameObject END;


    //Dialogue Peau D'Ane
    [SerializeField] private GameObject AneChoix1;
    [SerializeField] private GameObject AneChoix2;
    [SerializeField] private GameObject AneChoix3;
    [SerializeField] private GameObject AneChapitre3;


    private int dialogueStep = 0;
    private int CountC1 = 0;
    private int CountC2 = 0;
    private int CountC3 = 0;
    private bool isActive = false;
    private bool isTalking = false;
    private IInteract currentInteract;
    private bool Talk = false; 
    public CharacterController playerController;
    



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

        HibouxCave.SetActive(false);

        END.SetActive(false);

        // Peau D'Ane
        AneChoix1.SetActive(false);
        AneChoix2.SetActive(false);
        AneChoix3.SetActive(false);
        AneChapitre3.SetActive(false);


    }

    void Update()
    {
       
        
    
    }

    public void Interact()
    {
        NotMove();
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

        HibouxCave.SetActive(false);

        END.SetActive(false);
        

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
            isActive = !isActive;
            TableauMemoire.talkFirst = true;
            bulleDeText.SetActive(isActive);
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);
            return;
        }


        if (dialogueStep == 0 && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            autoHideVideo.Video();
            bulleTextPartie1.SetActive(isActive);
            dialogueStep = 1;
            return;

        }  //Début Mission:2
        if (dialogueStep == 1 && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            AneChapitre3.SetActive(true);
            FindObjectOfType<CharaterMoovement>().controlsEnabled = false;
            dialogueStep = 2;
            return;
        }
        if (dialogueStep == 2 && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == false && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {

            TableauMemoire.confidenceCerf = true;
            AneChapitre3.SetActive(false);
            isActive = !isActive;
            bulleTextDebutPartie1.SetActive(isActive);
            FindObjectOfType<CharaterMoovement>().controlsEnabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
            return;
        }
       

        if (TableauMemoire.AmiChien == true && TableauMemoire.masque == 0 && TableauMemoire.MLionFound == false && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            AmiDuChien.SetActive(isActive);
        }


        if (TableauMemoire.masque == 1 && TableauMemoire.MLionFound == false && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            textPartie3.SetActive(isActive);
            return;
        }
        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            TableauMemoire.MLionFound = true;
            TextPartie5.SetActive(false);
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }

        if (TableauMemoire.MLionFound == true && TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie51.SetActive(isActive);
        }
        if (TableauMemoire.MLionFound == true && TableauMemoire.masque == 0 && TableauMemoire.AmiChien == true && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie52.SetActive(isActive);
        }

        //PARTIE2----------------------------------------------------------------------------
        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true && TableauMemoire.UnVUnCochon == false)
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
        //mission1
        if (TableauMemoire.masque == 0 && CountC1 == 0)
        {
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            AneChoix3.SetActive(false);
            AneChoix2.SetActive(false);
            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            AneChoix1.SetActive(true);
            CountC1 = 1;
            return;
        }
        if (TableauMemoire.masque == 0 && CountC1 == 1)
        {
            choix1Text.SetActive(true);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);
            bulleDeText.SetActive(false);
            CountC1 = 0;
            return;
        }
        //Mission:2

    }
    public void Choix2()
    {
        if (TableauMemoire.masque == 0 && CountC2 == 0)
        {
            choix3Text.SetActive(false);
            choix2Text.SetActive(false);
            AneChoix1.SetActive(false);
            AneChoix3.SetActive(false);
            choix1Text.SetActive(false);
            bulleDeText.SetActive(false);
            AneChoix2.SetActive(true);
            CountC2 = 1;
            return;
        }
        //mission1
        if (TableauMemoire.masque == 0 && CountC2 == 1)
        {
            choix2Text.SetActive(true);
            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            choix3Text.SetActive(false);
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);
            CountC2 = 0;
            return;

        }
        //Mission:2
    }
    public void Choix3()
    {
        if (TableauMemoire.masque == 0 && CountC3 == 0)
        {
            choix2Text.SetActive(false);
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            choix1Text.SetActive(false);
            bulleDeText.SetActive(false);
            choix3Text.SetActive(false);
            AneChoix3.SetActive(true);
            CountC3 = 1;
            return;
        }
        //mission1
        if (TableauMemoire.masque == 0 && CountC3 == 1)
        {
            choix3Text.SetActive(true);
            bulleDeText.SetActive(false);
            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);
            CountC3 = 0;
            return;

        }

    }

    public void NotMove()
    {

        Talk = !Talk;

            FindObjectOfType<CharaterMoovement>().controlsEnabled = !Talk;
            

    }

    


}
