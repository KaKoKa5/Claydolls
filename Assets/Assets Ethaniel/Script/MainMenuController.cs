using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    #region Configurable Fields
    [Header("Scène de jeu")]
    [SerializeField] private string gameSceneName = "SampleScene";

    [Header("Panneaux UI")]
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject audioPanel;
    [SerializeField] private GameObject controlsPanel;
    #endregion

    // Tableau de tous les panels pour faciliter l'affichage exclusif
    private GameObject[] allPanels;

    #region Unity Callbacks
    private void Awake()
    {
        // Initialisation de tous les panels
        allPanels = new[] { creditsPanel, optionsPanel, audioPanel, controlsPanel };

        // Vérification des références assignées dans l'Inspector
        ValidateReferences();

        // Cache tous les panels (montre le menu principal)
        ShowOnly(null);
    }
    #endregion

    #region UI Actions
    // Charge la scène de jeu
    public void StartNewGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    // Quitte l'application ou arrête le Play Mode en éditeur
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // Affiche uniquement le panel Crédits
    public void ShowCredits() => ShowOnly(creditsPanel);
    // Retour au menu principal
    public void HideCredits() => ShowOnly(null);

    // Affiche uniquement le panel Options
    public void ShowOptions() => ShowOnly(optionsPanel);
    // Retour au menu principal
    public void HideOptions() => ShowOnly(null);

    // Affiche uniquement le panel Audio
    public void ShowAudioSettings() => ShowOnly(audioPanel);
    // Retour au panel Options
    public void HideAudioSettings() => ShowOnly(optionsPanel);

    // Affiche uniquement le panel Contrôles
    public void ShowControls() => ShowOnly(controlsPanel);
    // Retour au panel Options
    public void HideControls() => ShowOnly(optionsPanel);

    // Ajuste le volume global (0 à 1)
    public void SetMasterVolume(float volume)
    {
        AudioListener.volume = Mathf.Clamp01(volume);
    }
    #endregion

    #region Helper Methods
    // Active un seul panel et désactive les autres
    private void ShowOnly(GameObject panelToShow)
    {
        foreach (var panel in allPanels)
            if (panel != null)
                panel.SetActive(panel == panelToShow);
    }

    // Vérifie que tous les champs essentiels sont bien assignés
    private void ValidateReferences()
    {
        if (string.IsNullOrEmpty(gameSceneName))
            Debug.LogWarning($"{nameof(gameSceneName)} n'est pas défini.", this);
        if (creditsPanel == null)
            Debug.LogError($"{nameof(creditsPanel)} n'est pas assigné.", this);
        if (optionsPanel == null)
            Debug.LogError($"{nameof(optionsPanel)} n'est pas assigné.", this);
        if (audioPanel == null)
            Debug.LogError($"{nameof(audioPanel)} n'est pas assigné.", this);
        if (controlsPanel == null)
            Debug.LogError($"{nameof(controlsPanel)} n'est pas assigné.", this);
    }
    #endregion
}
