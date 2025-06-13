using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class MasterVolumeSlider : MonoBehaviour
{
    [Header("Key PlayerPrefs pour persister")]
    [SerializeField] private string prefsKey = "MasterVolume";

    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();
        // Conserve ce slider et son GameObject avec l’AudioManager
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        // 1) Config slider
        slider.minValue = 0f;
        slider.maxValue = 1f;
        slider.wholeNumbers = false;

        // 2) Charger et appliquer la valeur
        float saved = PlayerPrefs.GetFloat(prefsKey, 1f);
        AudioListener.volume = saved;
        slider.value = saved;

        // 3) Écouter les changements
        slider.onValueChanged.AddListener(OnSliderChanged);
    }

    private void OnSliderChanged(float value)
    {
        // Applique à tout le son du jeu
        AudioListener.volume = value;
        // Sauvegarde immédiatement
        PlayerPrefs.SetFloat(prefsKey, value);
        PlayerPrefs.Save();
    }
}
