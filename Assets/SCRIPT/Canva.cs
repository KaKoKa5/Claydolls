using UnityEngine;

public class Canva : MonoBehaviour
{
    [Header("Liste des Canvas à surveiller")]
    public Canvas[] uiCanvases;

    private CharaterMoovement playerController;

    void Start()
    {
        playerController = FindObjectOfType<CharaterMoovement>();
        if (playerController == null)
            Debug.LogError("PlayerController non trouvé dans la scène !");
    }

    void Update()
    {
        bool anyUIActive = false;

        foreach (Canvas canvas in uiCanvases)
        {
            if (canvas.gameObject.activeInHierarchy)
            {
                anyUIActive = true;
                break;
            }
        }

        if (playerController != null)
        {
            playerController.EnableControls(!anyUIActive);
        }
    }
}