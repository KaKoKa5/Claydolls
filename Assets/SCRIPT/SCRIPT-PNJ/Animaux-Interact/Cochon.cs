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

    [SerializeField] private GameObject HibouxCave;

    //END
    [SerializeField] private GameObject END;

    //Dialogue Peau D'Ane
    [SerializeField] private GameObject AneChoix1;
    [SerializeField] private GameObject AneChoix2;
    [SerializeField] private GameObject AneChoix3;

    [SerializeField] private GameObject AneChap5Choix1;
    [SerializeField] private GameObject AneChap5Choix2;

    [SerializeField] private GameObject AneBigDChoix1;
    [SerializeField] private GameObject AneBigDChoix2;
    [SerializeField] private GameObject AneBigDChoix3;

    [SerializeField] private GameObject AneBigDChoix1A;
    [SerializeField] private GameObject AneBigDChoix2B;
    [SerializeField] private GameObject AneBigDChoix3C;

    [SerializeField] private GameObject AneBigDChoix1AA;
    [SerializeField] private GameObject AneBigDChoix2BB;
    [SerializeField] private GameObject AneBigDChoix3CC;

    [SerializeField] private GameObject AneBigDChoix1AA1;
    [SerializeField] private GameObject AneBigDChoix2BB2;
    [SerializeField] private GameObject AneBigDChoix3CC3;

    [SerializeField] private GameObject AneBigDChoix1AA1A;
    [SerializeField] private GameObject AneBigDChoix2BB2B;
    [SerializeField] private GameObject AneBigDChoix3CC3C;


    private int CountC1 = 0;
    private int CountC2 = 0;
    private int CountC3 = 0;

    private int CountChap5C1 = 0;
    private int CountChap5C2 = 0;
    private bool isActive = false;
    private bool isTalking = false;
    private int CountText=0;
    private int SuiteBig = 0;

    private int CountENDC1 = 0;
    private int CountENDC2 = 0;
    private int CountENDC3 = 0;



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

        HibouxCave.SetActive(false);

        END.SetActive(false);

        // Peau D'Ane
        AneChoix1.SetActive(false);
        AneChoix2.SetActive(false);
        AneChoix3.SetActive(false);

        AneChap5Choix1.SetActive(false);
        AneChap5Choix2.SetActive(false);

        AneBigDChoix1.SetActive(false);
        AneBigDChoix2.SetActive(false);
        AneBigDChoix3.SetActive(false);

        AneBigDChoix1A.SetActive(false);
        AneBigDChoix2B.SetActive(false);
        AneBigDChoix3C.SetActive(false);

        AneBigDChoix1AA.SetActive(false);
        AneBigDChoix2BB.SetActive(false);
        AneBigDChoix3CC.SetActive(false);

        AneBigDChoix1AA1.SetActive(false);
        AneBigDChoix2BB2.SetActive(false);
        AneBigDChoix3CC3.SetActive(false);

        AneBigDChoix1AA1A.SetActive(false);
        AneBigDChoix2BB2B.SetActive(false);
        AneBigDChoix3CC3C.SetActive(false);
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

        if (TableauMemoire.talkFirst == false && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
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
        if (TableauMemoire.masque == 0 && TableauMemoire.talkFirst == true && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
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
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie3.SetActive(isActive);
        }

        //Mission5----------------------------------------------------------------------

        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == false && TableauMemoire.UnVUnCochon == false)
        {
            TableauMemoire.MLionFound = true;
            TextPartie5.SetActive(false);
            isActive = !isActive;
            TextPartie5.SetActive(isActive);
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.Partie2 == true && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie2A.SetActive(isActive);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == false && TableauMemoire.UnVUnCochon == false)
        {
            isActive = !isActive;
            TextPartie2L.SetActive(isActive);
        }
        if (TableauMemoire.masque == 2 && TableauMemoire.Partie2 == true && TableauMemoire.UnVUnCochon == false)
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
        if (!isTalking) return;
        
        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false&& CountC1==0)
        {

            AneChoix1.SetActive(true);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            bulleDeText.SetActive(false);
            CountC1 = 1;
            return;
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false && CountC1 == 1)
        {

            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            choix1Text.SetActive(true);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            bulleDeText.SetActive(false);
            CountC1 = 0;
            return;
        }

        //Mission3:----------------------------------------------------------
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountChap5C1==0)
        {
            AneChap5Choix1.SetActive(true);
            AneChap5Choix2.SetActive(false);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(false);
            CountChap5C1 = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountChap5C1 == 1)
        {
            AneChap5Choix1.SetActive(false);
            AneChap5Choix2.SetActive(false);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(true);
            choix2TextPartie3.SetActive(false);
            CountChap5C1 = 0;
            return;
        }


        //BIG DISCUTION---------------------------------------------------------------------------------------
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0 && CountENDC1 ==0)
        {
            AneBigDChoix1.SetActive(true);
            AneBigDChoix2.SetActive(false);
            AneBigDChoix3.SetActive(false);

            BigDiscution1.SetActive(false);
            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix1.SetActive(false);
            BigDiscutionChoix2.SetActive(false);
            CountENDC1 = 1;
            return;   
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0 && CountENDC1 == 1)
        {
            AneBigDChoix1.SetActive(false);
            AneBigDChoix2.SetActive(false);
            AneBigDChoix3.SetActive(false);

            BigDiscution1.SetActive(false);
            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix1.SetActive(true);
            BigDiscutionChoix2.SetActive(false);
            CountENDC1 = 2;
            return;
        }
        //-----------------------------------------------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1 && CountENDC1 == 2)
        {
            AneBigDChoix1A.SetActive(true);
            AneBigDChoix2B.SetActive(false);
            AneBigDChoix3C.SetActive(false);

            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix1s1.SetActive(false);
            BigDiscution1Choix1s2.SetActive(false);
            CountENDC1 = 3;
            return;
            
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1 && CountENDC1 == 3)
        {
            AneBigDChoix1A.SetActive(false);
            AneBigDChoix2B.SetActive(false);
            AneBigDChoix3C.SetActive(false);

            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix1s1.SetActive(true);
            BigDiscution1Choix1s2.SetActive(false);
            CountENDC1 = 4;
            return;

        }
        //--------------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2 && CountENDC1 == 4)
        {
            AneBigDChoix1AA.SetActive(true);
            AneBigDChoix2BB.SetActive(false);
            AneBigDChoix3CC.SetActive(false);

            BigDiscution1Choix1s3.SetActive(false);
            BigDiscution1Choix2s1.SetActive(false);
            BigDiscutionChoix2.SetActive(false);
            BigDiscution1Choix2s2.SetActive(false);
            CountENDC1 = 5;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2 && CountENDC1 == 5)
        {
            AneBigDChoix1AA.SetActive(false);
            AneBigDChoix2BB.SetActive(false);
            AneBigDChoix3CC.SetActive(false);

            BigDiscution1Choix1s3.SetActive(false);
            BigDiscution1Choix2s1.SetActive(true);
            BigDiscutionChoix2.SetActive(false);
            BigDiscution1Choix2s2.SetActive(false);
            CountENDC1 = 6;
            return;
        }
        //--------------------------------------------------------------------------------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3 && CountENDC1 == 6)
        {
            AneBigDChoix1AA1.SetActive(true);
            AneBigDChoix2BB2.SetActive(false);
            AneBigDChoix3CC3.SetActive(false);

            BigDiscution1Choix2s3.SetActive(false);
            BigDiscution1Choix3s1.SetActive(false);
            BigDiscution1Choix3s2.SetActive(false);
            CountENDC1 = 7;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3 && CountENDC1 == 7)
        {
            AneBigDChoix1AA1.SetActive(false);
            AneBigDChoix2BB2.SetActive(false);
            AneBigDChoix3CC3.SetActive(false);

            BigDiscution1Choix2s3.SetActive(false);
            BigDiscution1Choix3s1.SetActive(true);
            BigDiscution1Choix3s2.SetActive(false);
            CountENDC1 = 8;
            return;
        }
        //---------------------------------------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4 && CountENDC1 == 8)
        {
            AneBigDChoix1AA1A.SetActive(true);
            AneBigDChoix2BB2B.SetActive(false);
            AneBigDChoix3CC3C.SetActive(false);

            BigDiscution1Choix3s3.SetActive(false);
            BigDiscution1Choix4s1.SetActive(false);
            BigDiscution1Choix4s2.SetActive(false);

            CountENDC1 = 9;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4 && CountENDC1 == 9)
        {
            AneBigDChoix1AA1A.SetActive(false);
            AneBigDChoix2BB2B.SetActive(false);
            AneBigDChoix3CC3C.SetActive(false);

            BigDiscution1Choix3s3.SetActive(false);
            BigDiscution1Choix4s1.SetActive(true);
            BigDiscution1Choix4s2.SetActive(false);

            CountENDC1 = 9;
            return;
        }
    }
    public void Choix2()
    {
        if (!isTalking) return;

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false && CountC2 == 0)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(true);
            AneChoix3.SetActive(false);

            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            bulleDeText.SetActive(false);
            CountC2 = 1;
            return;
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false && CountC2 == 1)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            choix1Text.SetActive(false);
            choix2Text.SetActive(true);
            choix3Text.SetActive(false);
            bulleDeText.SetActive(false);
            CountC2 = 0;
            return;
        }

        //Mission3:----------------------------------------------------------
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountChap5C2==0)
        {
            AneChap5Choix1.SetActive(false);
            AneChap5Choix2.SetActive(true);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(false);
            CountChap5C2 = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == false && CountChap5C2 == 1)
        {
            AneChap5Choix1.SetActive(false);
            AneChap5Choix2.SetActive(false);

            TextPartie3.SetActive(false);
            choix1TextPartie3.SetActive(false);
            choix2TextPartie3.SetActive(true);
            CountChap5C2 = 0;
            return;
        }

        //BIG DISCUTION-------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0 && CountENDC2 == 0)
        {
            AneBigDChoix1.SetActive(false);
            AneBigDChoix2.SetActive(true);
            AneBigDChoix3.SetActive(false);

            BigDiscution1.SetActive(false);
            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix2.SetActive(false);
            BigDiscutionChoix1.SetActive(false);
            CountENDC2 = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0 && CountENDC2 == 1)
        {
            AneBigDChoix1.SetActive(false);
            AneBigDChoix2.SetActive(false);
            AneBigDChoix3.SetActive(false);

            BigDiscution1.SetActive(false);
            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix2.SetActive(true);
            BigDiscutionChoix1.SetActive(false);
            CountENDC2 = 2;
            return;
        }
        //------------------------------------------------------------------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1 && CountENDC2==2)
        {
            AneBigDChoix1A.SetActive(false);
            AneBigDChoix2B.SetActive(true);
            AneBigDChoix3C.SetActive(false);

            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix1s1.SetActive(false);
            BigDiscution1Choix1s2.SetActive(false);
            CountENDC2 = 3;
            return;

        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1 && CountENDC2 == 3)
        {
            AneBigDChoix1A.SetActive(false);
            AneBigDChoix2B.SetActive(false);
            AneBigDChoix3C.SetActive(false);

            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix1s1.SetActive(false);
            BigDiscution1Choix1s2.SetActive(true);
            CountENDC2 = 4;
            return;
        }
        //-------------------------------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2 && CountENDC2 == 4)
        {
            AneBigDChoix1AA.SetActive(false);
            AneBigDChoix2BB.SetActive(true);
            AneBigDChoix3CC.SetActive(false);

            BigDiscution1Choix1s3.SetActive(false);
            BigDiscution1Choix2s2.SetActive(false);
            BigDiscution1Choix2s1.SetActive(false);

            CountENDC2 = 5;
            return;

        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2 && CountENDC2 == 5)
        {
            AneBigDChoix1AA.SetActive(false);
            AneBigDChoix2BB.SetActive(false);
            AneBigDChoix3CC.SetActive(false);

            BigDiscution1Choix1s3.SetActive(false);
            BigDiscution1Choix2s2.SetActive(true);
            BigDiscution1Choix2s1.SetActive(false);

            CountENDC2 = 6;
            return;

        }
        //----------------------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3 && CountENDC2 == 6)
        {
            AneBigDChoix1AA1.SetActive(false);
            AneBigDChoix2BB2.SetActive(true);
            AneBigDChoix3CC3.SetActive(false);

            BigDiscution1Choix2s3.SetActive(false);
            BigDiscution1Choix3s2.SetActive(false);
            BigDiscution1Choix3s1.SetActive(false);
            CountENDC2 = 7;
            return;

        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3 && CountENDC2 == 7)
        {
            AneBigDChoix1AA1.SetActive(false);
            AneBigDChoix2BB2.SetActive(false);
            AneBigDChoix3CC3.SetActive(false);

            BigDiscution1Choix2s3.SetActive(false);
            BigDiscution1Choix3s2.SetActive(true);
            BigDiscution1Choix3s1.SetActive(false);
            CountENDC2 = 8;
            return;

        }
        //-----------------------------------------------------------------------------------------------------
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4 && CountENDC2 == 8)
        {
            AneBigDChoix1AA1A.SetActive(false);
            AneBigDChoix2BB2B.SetActive(true);
            AneBigDChoix3CC3C.SetActive(false);

            BigDiscution1Choix3s3.SetActive(false);
            BigDiscution1Choix4s2.SetActive(false);
            BigDiscution1Choix4s1.SetActive(false);
            CountENDC2 = 9;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4 && CountENDC2 == 9)
        {
            AneBigDChoix1AA1A.SetActive(false);
            AneBigDChoix2BB2B.SetActive(false);
            AneBigDChoix3CC3C.SetActive(false);

            BigDiscution1Choix3s3.SetActive(false);
            BigDiscution1Choix4s2.SetActive(true);
            BigDiscution1Choix4s1.SetActive(false);
            CountENDC2 = 10;
            return;
        }
        
    }
    public void Choix3()
    {
        if (!isTalking) return;

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false && CountC3 == 0)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(true);

            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(false);
            bulleDeText.SetActive(false);
            CountC3 = 1;
            return;
        }

        if (TableauMemoire.masque == 0 && TableauMemoire.confidenceCerf == false && CountC3 == 1)
        {
            AneChoix1.SetActive(false);
            AneChoix2.SetActive(false);
            AneChoix3.SetActive(false);

            choix1Text.SetActive(false);
            choix2Text.SetActive(false);
            choix3Text.SetActive(true);
            bulleDeText.SetActive(false);
            CountC3 = 0;
            return;
        }

        //BIG DISCUTION
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0 && CountENDC3==0)
        {
            AneBigDChoix1.SetActive(false);
            AneBigDChoix2.SetActive(false);
            AneBigDChoix3.SetActive(true);

            BigDiscution1.SetActive(false);
            BigDiscutionChoix3.SetActive(false);
            BigDiscutionChoix1.SetActive(false);
            BigDiscutionChoix2.SetActive(false);
            CountENDC3 = 1;
            CountENDC2 = 1;
            CountENDC1 = 1;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 0 && CountENDC3 == 1)
        {
            AneBigDChoix1.SetActive(false);
            AneBigDChoix2.SetActive(false);
            AneBigDChoix3.SetActive(false);

            BigDiscution1.SetActive(false);
            BigDiscutionChoix3.SetActive(true);
            BigDiscutionChoix1.SetActive(false);
            BigDiscutionChoix2.SetActive(false);
            CountENDC3 = 2;
            CountENDC2 = 2;
            CountENDC1 = 2;
            SuiteBig = 1;
            return;
        }
        //----------------------------------------------------------------------------------------------------------------

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1 && CountENDC3 == 2)
        {
            AneBigDChoix1A.SetActive(false);
            AneBigDChoix2B.SetActive(false);
            AneBigDChoix3C.SetActive(true);

            BigDiscutionChoix3.SetActive(false);
            BigDiscution1Choix1s3.SetActive(false);
            BigDiscutionChoix1s1.SetActive(false);
            BigDiscution1Choix1s2.SetActive(false);
            CountENDC3 = 3;
            CountENDC2 = 3;
            CountENDC1 = 3;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 1 && CountENDC3 == 3)
        {
            AneBigDChoix1A.SetActive(false);
            AneBigDChoix2B.SetActive(false);
            AneBigDChoix3C.SetActive(false);

            BigDiscutionChoix3.SetActive(false);
            BigDiscution1Choix1s3.SetActive(true);
            BigDiscutionChoix1s1.SetActive(false);
            BigDiscution1Choix1s2.SetActive(false);
            CountENDC3 = 4;
            CountENDC2 = 4;
            CountENDC1 = 4;
            SuiteBig = 2;
            return;
        }
        //-----------------------------------------------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2 && CountENDC3 == 4)
        {
            AneBigDChoix1AA.SetActive(false);
            AneBigDChoix2BB.SetActive(false);
            AneBigDChoix3CC.SetActive(true);

            BigDiscution1Choix1s3.SetActive(false);
            BigDiscutionChoix1s1.SetActive(false);
            BigDiscution1Choix2s3.SetActive(false);
            BigDiscution1Choix2s1.SetActive(false);
            BigDiscution1Choix2s2.SetActive(false);
            CountENDC3 = 5;
            CountENDC2 = 5;
            CountENDC1 = 5;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 2 && CountENDC3 == 5)
        {
            AneBigDChoix1AA.SetActive(false);
            AneBigDChoix2BB.SetActive(false);
            AneBigDChoix3CC.SetActive(false);

            BigDiscution1Choix1s3.SetActive(false);
            BigDiscutionChoix1s1.SetActive(false);
            BigDiscution1Choix2s3.SetActive(true);
            BigDiscution1Choix2s1.SetActive(false);
            BigDiscution1Choix2s2.SetActive(false);
            CountENDC3 = 6;
            CountENDC2 = 6;
            CountENDC1 = 6;
            SuiteBig = 3;
            return;
        }
        //----------------------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3 && CountENDC3 == 6)
        {
            AneBigDChoix1AA1.SetActive(false);
            AneBigDChoix2BB2.SetActive(false);
            AneBigDChoix3CC3.SetActive(true);

            BigDiscution1Choix2s3.SetActive(false);
            BigDiscution1Choix3s3.SetActive(false);
            BigDiscution1Choix3s1.SetActive(false);
            BigDiscution1Choix3s2.SetActive(false);
            CountENDC3 = 7;
            CountENDC2 = 7;
            CountENDC1 = 7;
            return;
        }

        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 3 && CountENDC3 == 7)
        {
            AneBigDChoix1AA1.SetActive(false);
            AneBigDChoix2BB2.SetActive(false);
            AneBigDChoix3CC3.SetActive(false);

            BigDiscution1Choix2s3.SetActive(false);
            BigDiscution1Choix3s3.SetActive(true);
            BigDiscution1Choix3s1.SetActive(false);
            BigDiscution1Choix3s2.SetActive(false);
            CountENDC3 = 8;
            CountENDC2 = 8;
            CountENDC1 = 8;
            SuiteBig = 4;
            return;
        }
        //------------------------------------------------------
        
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4 && CountENDC3 == 8)
        {
            AneBigDChoix1AA1A.SetActive(false);
            AneBigDChoix2BB2B.SetActive(false);
            AneBigDChoix3CC3C.SetActive(true);
            
            BigDiscution1Choix3s3.SetActive(false);
            BigDiscution1Choix4s3.SetActive(false);
            BigDiscution1Choix3s2.SetActive(false);
            BigDiscution1Choix4s1.SetActive(false);
            BigDiscution1Choix4s2.SetActive(false);
            CountENDC3 = 9;
            CountENDC2 = 9;
            CountENDC1 = 9;
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 4 && CountENDC3 == 9)
        {
            AneBigDChoix1AA1A.SetActive(false);
            AneBigDChoix2BB2B.SetActive(false);
            AneBigDChoix3CC3C.SetActive(false);

            BigDiscution1Choix3s3.SetActive(false);
            BigDiscution1Choix4s3.SetActive(true);
            BigDiscution1Choix3s2.SetActive(false);
            BigDiscution1Choix4s1.SetActive(false);
            BigDiscution1Choix4s2.SetActive(false);
            CountENDC3 = 10;
            CountENDC2 = 10;
            CountENDC1 = 10;
            SuiteBig = 5;
            return;
        }
        //-------------------------------------------------------------------------------
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 5)
        {
            isActive = !isActive;
            BigDiscution1Choix4s2.SetActive(false);
            BigDiscution1Choix4s3.SetActive(false);
            BigDiscution1Choix4s3bis.SetActive(true);
            SuiteBig = 6;
            autoHideVideo.Video();

            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.Partie2 == true && TableauMemoire.StoryCorbeau == true && SuiteBig == 6)
        {
            isActive = !isActive;
            BigDiscution1Choix4s3.SetActive(false);
            BigDiscution1Choix4s3bis.SetActive(false);
            SuiteBig = 5;
            
            TableauMemoire.UnVUnCochon = true;
            TableauMemoire.CochonHagrad = false;
            TableauMemoire.RevelSNAKE = false;
            TableauMemoire.HibouxFound = false;
            TableauMemoire.StoryCorbeau = false;
            TableauMemoire.AmiChien = false;
            TableauMemoire.Partie2 = false;
            return;
        }
        
    }

}
