using UnityEngine;

public class Cochon : MonoBehaviour , IInteract
{
    [SerializeField] private AutoHideVideo autoHideVideo;

    [SerializeField] private GameObject STARTText;
[SerializeField] private GameObject STARTText2;
  [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;

    //Mission2:
    [SerializeField] private GameObject TextPartie2;

    //Mission3:
    [SerializeField] private GameObject TextPartie3;
    [SerializeField] private GameObject choix1TextPartie3;
    [SerializeField] private GameObject choix2TextPartie3;

    //Mission5:
    [SerializeField] private GameObject TextPartie5;  

    //PARTIE2
    [SerializeField] private GameObject TextPartie2A;
    [SerializeField] private GameObject TextPartie2L;
    [SerializeField] private GameObject TextPartie2LL;
    //17
    //La plus grande conversation avec le porc
    [SerializeField] private GameObject BigDiscution1;
    [SerializeField] private GameObject BigDiscutionChoix1;
    [SerializeField] private GameObject BigDiscutionChoix2;
    [SerializeField] private GameObject BigDiscutionChoix3;
    [SerializeField] private GameObject BigDiscutionChoix1s1;
    [SerializeField] private GameObject BigDiscution1Choix1s2;
    [SerializeField] private GameObject BigDiscution1Choix1s3;
    [SerializeField] private GameObject BigDiscution1Choix2s1;
    [SerializeField] private GameObject BigDiscution1Choix2s2;
    [SerializeField] private GameObject BigDiscution1Choix2s3;
    [SerializeField] private GameObject BigDiscution1Choix3s1;
    [SerializeField] private GameObject BigDiscution1Choix3s2;
    [SerializeField] private GameObject BigDiscution1Choix3s3;
    [SerializeField] private GameObject BigDiscution1Choix4s1;
    [SerializeField] private GameObject BigDiscution1Choix4s2;
    [SerializeField] private GameObject BigDiscution1Choix4s3;
    [SerializeField] private GameObject BigDiscution1Choix4s3bis;



    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;
    private int SuiteBig = 0;


    private void Start()
    {
        STARTText.SetActive(false);
        STARTText2.SetActive(false);

        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);

        TextPartie2.SetActive(false);

        //Mission3
        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);

        //Mission6
        TextPartie5.SetActive(false);

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);
        //17
        //La plus grande conversation avec le porc
        SuiteBig = 0;

        BigDiscution1.SetActive(false);
        BigDiscutionChoix1.SetActive(false);
        BigDiscutionChoix2.SetActive(false);
        BigDiscutionChoix3.SetActive(false);
        BigDiscutionChoix1s1.SetActive(false);
        BigDiscution1Choix1s2.SetActive(false);
        BigDiscution1Choix1s3.SetActive(false);
        BigDiscution1Choix2s1.SetActive(false);
        BigDiscution1Choix2s2.SetActive(false);
        BigDiscution1Choix2s3.SetActive(false);
        BigDiscution1Choix3s1.SetActive(false);
        BigDiscution1Choix3s2.SetActive(false);
        BigDiscution1Choix3s3.SetActive(false);
        BigDiscution1Choix4s1.SetActive(false);
        BigDiscution1Choix4s2.SetActive(false);
        BigDiscution1Choix4s3.SetActive(false);
        BigDiscution1Choix4s3bis.SetActive(false);


    }

    public void Interact()
    {
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleDeText.SetActive(false);

        TextPartie2.SetActive(false);

        //Mission3
        TextPartie3.SetActive(false);
        choix1TextPartie3.SetActive(false);
        choix2TextPartie3.SetActive(false);

        //Mission6
        TextPartie5.SetActive(false);

        //PARTIE2
        TextPartie2A.SetActive(false);
        TextPartie2L.SetActive(false);
        TextPartie2LL.SetActive(false);

        if (TableauMemoire.talkFirst == false && TableauMemoire.Partie2 == false)
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

        isTalking = true;

        //mission1
        TableauMemoire.talkCochon = true;
        if (TableauMemoire.masque == 0 && TableauMemoire.talkFirst == true && TableauMemoire.Partie2 == false)
        {
            CountText = 3;
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }
        //Mission2:--------------------------------------------------------------------

        TextPartie2.SetActive(false);
        if (TableauMemoire.confidenceCerf == true && TableauMemoire.masque == 0 && TableauMemoire.Partie2 == false)
        {
            bulleDeText.SetActive(false);
            TextPartie2.SetActive(isActive);
        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false)
        {
            TableauMemoire.MLionFound = true;
            TextPartie5.SetActive(false);
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true)
        {
            isActive = !isActive;
            TextPartie2A.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == false)
        {
            isActive = !isActive;
            TextPartie2L.SetActive(isActive);
        }
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == true)
        {
            isActive = !isActive;
            TextPartie2LL.SetActive(isActive);
        }

        //BIG DISCUTION

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true)
        {
            isActive = !isActive;
            BigDiscution1.SetActive(isActive);
        }
        

    }

    public void Choix1()
    {
        if (!isTalking) return;

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false)
        {
            choix1Text.SetActive(true);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            bulleDeText.SetActive(false);
        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(true);
            choix2TextPartie3.SetActive(false);
        }
        //BIG DISCUTION

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0)
        {
            isActive = !isActive;
            BigDiscutionChoix1.SetActive(isActive);
        }
        
        //BIG DISCUTION

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0)
        {
            BigDiscution1.SetActive(false);
            isActive = !isActive;
            BigDiscutionChoix1.SetActive(isActive);
        }
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1)
        {
            isActive = !isActive;
            BigDiscutionChoix1s1.SetActive(isActive);
            
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2)
        {
            isActive = !isActive;
            BigDiscution1Choix2s1.SetActive(isActive);
            
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3)
        {
            isActive = !isActive;
            BigDiscution1Choix3s1.SetActive(isActive);
            
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4)
        {
            isActive = !isActive;
            BigDiscution1Choix4s1.SetActive(isActive);
            
        }
    }
    public void Choix2()
    {
        if (!isTalking) return;

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false)
        {
            choix1Text.SetActive(false);
            choix2Text.SetActive(true);
            choix3Text.SetActive(false);
            bulleDeText.SetActive(false);
        }

        //Mission3:----------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false)
        {
            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(true);
        }

        //BIG DISCUTION

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0)
        {
            BigDiscution1.SetActive(false);
            isActive = !isActive;
            BigDiscutionChoix2.SetActive(isActive);
        }
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1)
        {
            isActive = !isActive;
            BigDiscution1Choix1s2.SetActive(isActive);
            
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2)
        {
            isActive = !isActive;
            BigDiscution1Choix2s2.SetActive(isActive);
            
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3)
        {
            isActive = !isActive;
            BigDiscution1Choix3s2.SetActive(isActive);
            
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4)
        {
            isActive = !isActive;
            BigDiscution1Choix4s2.SetActive(isActive);
            
        }
        
    }
    public void Choix3()
    {
        if (!isTalking) return;

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false)
        {
            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(true);
            bulleDeText.SetActive(false);
        }

        //BIG DISCUTION

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0)
        {
            BigDiscution1.SetActive(false);
            isActive = !isActive;
            BigDiscutionChoix3.SetActive(isActive);
            SuiteBig = 1;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1)
        {
            isActive = !isActive;
            BigDiscution1Choix1s3.SetActive(isActive);
            SuiteBig = 2;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2)
        {
            isActive = !isActive;
            BigDiscution1Choix2s3.SetActive(isActive);
            SuiteBig = 3;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3)
        {
            isActive = !isActive;
            BigDiscution1Choix3s3.SetActive(isActive);
            SuiteBig = 4;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4)
        {
            isActive = !isActive;
            BigDiscution1Choix4s3.SetActive(isActive);
            SuiteBig = 5;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 5)
        {
            isActive = !isActive;
            BigDiscution1Choix4s3bis.SetActive(isActive);
            SuiteBig = 5;
            return;
        }
        
    }

}
