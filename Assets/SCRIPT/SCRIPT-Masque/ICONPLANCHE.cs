using UnityEngine;
using UnityEngine.UI;

public class ICONPLANCHE : MonoBehaviour
{
    
    public static ICONPLANCHE Instance;
    private PNJ currentNPC;

    [Header("Image UI de l'icône")]
    public Image leftClickIcon;

    [Header("Caméra principale")]
    public Camera mainCamera;
    Collider other;


    private bool playerInRange = false;

    void Awake()
    {
        Instance = this;
        if (mainCamera == null)
            mainCamera = Camera.main;
        if (leftClickIcon == null)
            Debug.LogError("LeftClickIcon UI non assignée dans l'Inspector !");
        leftClickIcon.enabled = false;
    }

    void Update()
{

        if (currentNPC != null)
        {
            Vector3 worldPos = currentNPC.transform.position + Vector3.up *0; 
            Vector3 screenPos = mainCamera.WorldToScreenPoint(worldPos);

            if (screenPos.z > 0)
            {
                leftClickIcon.rectTransform.position = screenPos;
                leftClickIcon.enabled = true;
                return;
            }
            
    }

    //leftClickIcon.enabled = false;
}

    public void SetCurrentNPC(PNJ npc)
    {
        
        currentNPC = npc;
    }

public void ClearCurrent()  
{
    
    leftClickIcon.enabled = false;
    currentNPC = null;
}
}
