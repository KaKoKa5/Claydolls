/*using UnityEngine;

public class Hiboux : MonoBehaviour , IInteract
{
 [SerializeField] private GameObject bulleDeText;
    [SerializeField] private GameObject choix1Text;
    [SerializeField] private GameObject choix2Text;
    [SerializeField] private GameObject choix3Text;
    [SerializeField] private GameObject bulleTextEND;


    private bool isActive = false;
    private bool isTalking = false;


    private void Start()
    {
        bulleDeText.SetActive(false);
        choix1Text.SetActive(false);
        choix2Text.SetActive(false);
        choix3Text.SetActive(false);
        bulleTextEND.SetActive(false);

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
        isTalking = true;
        isSolve = false;

        if (Input.GetKeyDown(KeyCode.E))
        {
            isActive = !isActive;
            bulleDeText.SetActive(isActive);
        }
    }

    public void Choix1()
    {
        if (!isTalking)return;
    
        bulleDeText.SetActive(false);
        isActive = !isActive;
        choix1Text.SetActive(isActive);

    }
    public void Choix2()
    {
        if (!isTalking)return;
    
        bulleDeText.SetActive(false);
        isActive = !isActive;
        choix2Text.SetActive(isActive);
    }
    public void Choix3()
    {
        if (!isTalking)return;
    
        bulleDeText.SetActive(false);
        isActive = !isActive;
        choix3Text.SetActive(isActive);
        
    }

}*/
