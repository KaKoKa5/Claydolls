using System.Collections;
using UnityEngine;

public class MaskPopupManager : MonoBehaviour
{
    public static MaskPopupManager Instance;

    [Header("Popups par masque (0=Âne, 1=Loup, 2=Lion, 3=Phénix)")]
    public GameObject[] maskPopups;
    public float popupDuration = 2f;

    private void Awake()
    {
        Instance = this;
        // Assure-toi que tout est désactivé au démarrage
        foreach (var popup in maskPopups)
        {
            if (popup != null)
                popup.SetActive(false);
        }
    }

    public void ShowPopup(int maskIndex)
    {
        if (maskIndex < 0 || maskIndex >= maskPopups.Length)
        {
            Debug.LogWarning("Index de masque invalide !");
            return;
        }

        StartCoroutine(ShowTemporarily(maskPopups[maskIndex]));
    }

    private IEnumerator ShowTemporarily(GameObject popup)
    {
        popup.SetActive(true);

        yield return new WaitForSeconds(popupDuration);

        popup.SetActive(false);
    }
}
