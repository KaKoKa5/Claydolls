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



    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;



    private void Start()
    {
        STARTText.SetActive(false);
        STARTText2.SetActive(false);
        bulleDeText.SetActive(false);
        
        bulleText.SetActive(false);
        bulleChoix1DeText.SetActive(false);
        bulleChoix2DeText.SetActive(false);
        bulleChoix3DeText.SetActive(false);

    }



    public void Interact()
    {
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
            }

        }


        if ((TableauMemoire.masque==1 || TableauMemoire.masque==0)&&TableauMemoire.talkFirst==true)
        {
            isActive = !isActive;
            bulleDeText.SetActive(isActive);    
        }

        if (TableauMemoire.masque==2)
        {
            bulleText.SetActive(isActive);    
        }
    }

    public void Choix1()
    {
        if (!isTalking)return;
        
        if(TableauMemoire.masque==2)
        {
            bulleText.SetActive(false);
        bulleChoix1DeText.SetActive(true);
        bulleChoix2DeText.SetActive(false);
        bulleChoix3DeText.SetActive(false);
            TableauMemoire.CochonHagrad=true;
            autoHideVideo.Video();
        }

    }
    public void Choix2()
    {
        if (!isTalking)return;
        
        if(TableauMemoire.masque==2)
        {
            bulleText.SetActive(false);
        bulleChoix1DeText.SetActive(false);
        bulleChoix2DeText.SetActive(true);
        bulleChoix3DeText.SetActive(false);
        }
    }
    public void Choix3()
    {
        if (!isTalking)return;

        if(TableauMemoire.masque==2)
        {
            bulleText.SetActive(false);
        bulleChoix1DeText.SetActive(false);
        bulleChoix2DeText.SetActive(false);
        bulleChoix3DeText.SetActive(true);
        }
        
    }

}
