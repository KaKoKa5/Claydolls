using UnityEngine;

public class Chat : MonoBehaviour, IInteract
{
[SerializeField] private AutoHideVideo autoHideVideo;

[SerializeField] private GameObject STARTText;
[SerializeField] private GameObject STARTText2;

[SerializeField] private GameObject bulleDeText;

[SerializeField] private GameObject bulleText;
[SerializeField] private GameObject bulleChoix1DeText;
[SerializeField] private GameObject bulleChoix2DeText;
    [SerializeField] private GameObject bulleChoix3DeText;

    [SerializeField] private GameObject HibouxCave;

    //END
    [SerializeField] private GameObject END;
    
    //Peau D'ane

    [SerializeField] private GameObject AneChapitre8Choix1;
    [SerializeField] private GameObject AneChapitre8Choix2;
    [SerializeField] private GameObject AneChapitre8Choix3;

    public IconFader icon1;


    // Peau d'Ane
    private int CountC1 = 0;
    private int CountC2 = 0;
    private int CountC3 = 0;


    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;
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
    }

    private void Start()
    {
        FindObjectOfType<CameraSwitcher>().SwitchToCam1();
        STARTText.SetActive(false);
        STARTText2.SetActive(false);
        bulleDeText.SetActive(false);

        bulleText.SetActive(false);
        bulleChoix1DeText.SetActive(false);
        bulleChoix2DeText.SetActive(false);
        bulleChoix3DeText.SetActive(false);

        HibouxCave.SetActive(false);

        END.SetActive(false);

        AneChapitre8Choix1.SetActive(false);
        AneChapitre8Choix2.SetActive(false);
        AneChapitre8Choix3.SetActive(false);

    }
    void Update()
    {
        if (TableauMemoire.ICONChat == true)
        {
            icon1.FadeIn();
        }
        else
        {
            icon1.FadeOut();
        }
        
    }


    public void Interact()
    {
        NotMove();
        bulleDeText.SetActive(false);
        bulleText.SetActive(false);
        bulleChoix1DeText.SetActive(false);
        bulleChoix2DeText.SetActive(false);
        bulleChoix3DeText.SetActive(false);

        isTalking = true;

        if (TableauMemoire.talkFirst == false)
        {
            if (CountText == 0)
            {
                isActive = !isActive;
                STARTText.SetActive(isActive);
                FindObjectOfType<CameraSwitcher>().SwitchToCam2();
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
                FindObjectOfType<CameraSwitcher>().SwitchToCam1();
                return;
            }

        }


        if ((TableauMemoire.masque == 1 || TableauMemoire.masque == 0) && TableauMemoire.talkFirst == true && TableauMemoire.UnVUnCochon == false)
        {
            
            CountText = 3;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }

        if (TableauMemoire.masque == 2 && TableauMemoire.UnVUnCochon == false)
        {
            TableauMemoire.ICONChat = false;
            isActive = !isActive;
            bulleText.SetActive(isActive);

            TableauMemoire.CochonHagrad = true;
            TableauMemoire.Partie2 = true;

            TableauMemoire.confidenceCerf = false;
            TableauMemoire.AmiChien = false;
            TableauMemoire.SecretSurCerf = false;
            TableauMemoire.MLionFound = false;
            TableauMemoire.MLoupFound = false;
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
        
        if (TableauMemoire.masque == 2 && CountC1 == 0)
        {
            AneChapitre8Choix1.SetActive(true);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);

            bulleText.SetActive(false);
            bulleChoix1DeText.SetActive(false);
            bulleChoix2DeText.SetActive(false);
            bulleChoix3DeText.SetActive(false);
            
            CountC1 = 1;
            return;
        }

        if (TableauMemoire.masque == 2 && CountC1 == 1)
        {
            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);

            bulleText.SetActive(false);
            bulleChoix1DeText.SetActive(true);
            bulleChoix2DeText.SetActive(false);
            bulleChoix3DeText.SetActive(false);
            TableauMemoire.CochonHagrad = true;
            autoHideVideo.Video();
            TableauMemoire.ICONSerpent = true;

            CountC1 = 0;
            return;
        }

    }
    public void Choix2()
    {
        if (!isTalking)return;

        if (TableauMemoire.masque == 2 && CountC2 == 0)
        {
            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(true);
            AneChapitre8Choix3.SetActive(false);

            bulleText.SetActive(false);
            bulleChoix1DeText.SetActive(false);
            bulleChoix2DeText.SetActive(false);
            bulleChoix3DeText.SetActive(false);

            CountC2 = 1;
            return;
        }

        if (TableauMemoire.masque == 2 && CountC2 == 1)
        {
            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);

            bulleText.SetActive(false);
            bulleChoix1DeText.SetActive(false);
            bulleChoix2DeText.SetActive(true);
            bulleChoix3DeText.SetActive(false);

            CountC2 = 0;
            return;
        }
    }
    public void Choix3()
    {
        if (!isTalking)return;

        if (TableauMemoire.masque == 2 && CountC3 == 0)
        {
            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(true);

            bulleText.SetActive(false);
            bulleChoix1DeText.SetActive(false);
            bulleChoix2DeText.SetActive(false);
            bulleChoix3DeText.SetActive(false);

            CountC3 = 1;
            return;
        }

        if (TableauMemoire.masque == 2 && CountC3 == 1)
        {
            AneChapitre8Choix1.SetActive(false);
            AneChapitre8Choix2.SetActive(false);
            AneChapitre8Choix3.SetActive(false);

            bulleText.SetActive(false);
            bulleChoix1DeText.SetActive(false);
            bulleChoix2DeText.SetActive(false);
            bulleChoix3DeText.SetActive(true);

            CountC3 = 0;
            return;
        }
        
    }

}
