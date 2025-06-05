using UnityEngine;

[RequireComponent(typeof(Collider))]
public class MaskPicku : MonoBehaviour
{
    [Header("Quel masque débloquer ? 0=Âne, 1=Loup, 2=Lion, 3=Phénix")]
    public int maskIndex;

    private GameObject outlineChild;
    private MaskCyclerUI cycler;

    void Awake()
    {
        outlineChild = transform.Find("Outline")?.gameObject;
        if (outlineChild != null)
            outlineChild.SetActive(false);
        var col = GetComponent<Collider>();
        col.isTrigger = true;

        cycler = FindObjectOfType<MaskCyclerUI>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        outlineChild?.SetActive(true);
        InteractIcon.Instance.SetCurrent(this);
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        outlineChild?.SetActive(false);
        InteractIcon.Instance.ClearCurrent();
    }

    public void Collect()
    {
        cycler?.UnlockMask(maskIndex);

        MaskPopupManager.Instance.ShowPopup(maskIndex);

        Destroy(gameObject);
    }
}
