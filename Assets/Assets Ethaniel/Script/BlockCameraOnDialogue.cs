using UnityEngine;

public class BlockCameraOnDialogue : MonoBehaviour
{
    [Tooltip("Le tag à appliquer à tes vrais dialogues UI")]
    public string dialogueTag = "DialogueUI";

    private CameraOrbit camOrbit;

    void Start()
    {
        // Récupère le CameraOrbit sur la Main Camera une fois pour toutes
        var cam = Camera.main;
        if (cam == null)
        {
            Debug.LogError("BlockCameraOnDialogueByTag → pas de Main Camera trouvée !");
            enabled = false;
            return;
        }
        camOrbit = cam.GetComponent<CameraOrbit>();
        if (camOrbit == null)
        {
            Debug.LogError("BlockCameraOnDialogueByTag → pas de CameraOrbit sur la Main Camera !");
            enabled = false;
        }
    }

    void Update()
    {
        if (camOrbit == null) return;

        // Recherche TOUS les objets taggés "DialogueUI"
        var dialogues = GameObject.FindGameObjectsWithTag(dialogueTag);
        bool dialogueOpen = false;
        foreach (var go in dialogues)
        {
            if (go.activeInHierarchy)
            {
                dialogueOpen = true;
                break;
            }
        }

        // Active ou désactive CameraOrbit
        camOrbit.enabled = !dialogueOpen;
    }
}
