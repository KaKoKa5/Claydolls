using UnityEngine;
using UnityEngine.EventSystems;

public class UIButtonSFX : MonoBehaviour,
    IPointerEnterHandler,
    IPointerClickHandler
{
    [Header("Sons UI")]
    public AudioClip hoverSfx;
    public AudioClip clickSfx;
    [Range(0f,1f)] public float hoverVolume = 0.2f;
    [Range(0f,1f)] public float clickVolume = 0.5f;

    // AudioSource partagé par tous les boutons
    private static AudioSource _globalSource;

    void Awake()
    {
        // Crée l'AudioSource global la première fois
        if (_globalSource == null)
        {
            var go = new GameObject("UI_SFX_Source");
            DontDestroyOnLoad(go);
            _globalSource = go.AddComponent<AudioSource>();
            _globalSource.playOnAwake = false;
            _globalSource.spatialBlend = 0f; // son 2D
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverSfx != null)
            _globalSource.PlayOneShot(hoverSfx, hoverVolume);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clickSfx != null)
            _globalSource.PlayOneShot(clickSfx, clickVolume);
    }
}
