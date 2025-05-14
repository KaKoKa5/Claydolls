using UnityEngine;
using UnityEngine.UI;

public class InteractIcon : MonoBehaviour
{
    public static InteractIcon Instance;

    [Header("Image UI de l'icône")]
    public Image leftClickIcon;    
    
    [Header("Caméra principale")]
    public Camera mainCamera;     

    private MaskPicku currentPickup;

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
        if (currentPickup != null)
        {
            Vector3 worldPos = currentPickup.transform.position + Vector3.up * 0.5f;
            Vector3 screenPos = mainCamera.WorldToScreenPoint(worldPos);

            if (screenPos.z > 0)
            {
                leftClickIcon.rectTransform.position = screenPos;
                leftClickIcon.enabled = true;

                if (Input.GetMouseButtonDown(0))
                {
                    currentPickup.Collect();
                    ClearCurrent();
                }
                return;
            }
        }

        leftClickIcon.enabled = false;
    }

    public void SetCurrent(MaskPicku pickup)
    {
        currentPickup = pickup;
    }

    public void ClearCurrent()
    {
        currentPickup = null;
    }
}