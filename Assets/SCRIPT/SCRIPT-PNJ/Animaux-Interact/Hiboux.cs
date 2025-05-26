using UnityEngine;

public class Hiboux : MonoBehaviour , IInteract
{
 [SerializeField] private GameObject TextAne;
    [SerializeField] private GameObject TextLoup;
[SerializeField] private GameObject TextLoup1;
[SerializeField] private GameObject TextLion;




    private bool isActive = false;
    private bool isTalking = false;
    private int count = 0;


    private void Start()
    {
        TextAne.SetActive(false);
        TextLoup.SetActive(false);
        TextLoup1.SetActive(false);
        TextLion.SetActive(false);


    }

    void Update()
    {
    
    }

    public void Interact()
    {
        TextAne.SetActive(false);
        TextLoup.SetActive(false);
        TextLoup1.SetActive(false);
        TextLion.SetActive(false);

        isTalking = true;
        if (TableauMemoire.masque == 0 && TableauMemoire.UnVUnCochon == true)
        {
            isActive = !isActive;
            TextAne.SetActive(isActive);
            TextLoup.SetActive(false);
            TextLion.SetActive(false);
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.UnVUnCochon == true && count == 0)
        {
            isActive = !isActive;
            TextAne.SetActive(false);
            TextLoup.SetActive(isActive);
            TextLion.SetActive(false);
            count = 1;
           
            return;
        }
        if (TableauMemoire.masque == 1 && TableauMemoire.UnVUnCochon == true && count == 1)
        {
            TextAne.SetActive(false);
            TextLoup.SetActive(false);
            TextLoup1.SetActive(isActive);
            TextLion.SetActive(false);
            
            count = 0;
            return;
        }



        if (TableauMemoire.masque == 2 && TableauMemoire.UnVUnCochon == true)
        {
            isActive = !isActive;
            TextAne.SetActive(false);
            TextLoup.SetActive(false);
            TextLoup1.SetActive(false);
            TextLion.SetActive(isActive);

            TableauMemoire.HibouxDEAD = true;
        }

    }

    public void Choix1()
    {
        if (!isTalking)return;
    

        isActive = !isActive;


    }
    public void Choix2()
    {
        if (!isTalking)return;
    

        isActive = !isActive;

    }
    public void Choix3()
    {
        if (!isTalking)return;
    

        isActive = !isActive;

        
    }

}
