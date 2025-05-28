using UnityEngine;
using UnityEngine.UI;

public class CHOIXDialogue : MonoBehaviour, IInteract
{
    [Header("Boutons de choix")]
    [SerializeField] private GameObject choixPanel;
    [SerializeField] private Button buttonChoix1;
    [SerializeField] private Button buttonChoix2;
    [SerializeField] private Button buttonChoix3;

    private float interactionRange = 2f;
    private bool isTalking = false;

    public void Start()
    {
        // Assurez-vous que le panel de choix est désactivé au début
        choixPanel.SetActive(false);
    }

    public void Interact()
    {}
    public void Choix1()
    {
        Cursor.lockState = CursorLockMode.None; // Débloque la souris
Cursor.visible = true;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactionRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out IInteract interact))
            {
                interact.Choix1();
            }
        }
        
    }
    public void Choix2()
    {
        Cursor.lockState = CursorLockMode.None; // Débloque la souris
Cursor.visible = true;
         Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactionRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out IInteract interact))
            {
                interact.Choix2();
            }
        }
        

    }
    public void Choix3()
    {
        Cursor.lockState = CursorLockMode.None; // Débloque la souris
Cursor.visible = true;
         Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactionRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out IInteract interact))
            {
                interact.Choix3();
            }
        }
        
    }
}
