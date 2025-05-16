using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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

    [Header("Fondu de l'écran (overlay)")]
    [Tooltip("CanvasGroup couvrant l'écran en noir pour le fondu à l'ouverture")]
    [SerializeField] private CanvasGroup fadeCoverCanvasGroup;
    [Tooltip("Durée du fondu hors du noir (secondes)")]
    [SerializeField] private float fadeDuration = 1f;

    [Header("Révélation des boutons")]
    [Tooltip("Liste des CanvasGroup attachés à chaque bouton, dans l'ordre vertical du menu")]
    [SerializeField] private CanvasGroup[] mainMenuButtonGroups;
    [Tooltip("Délai entre chaque bouton (secondes)")]
    [SerializeField] private float buttonRevealDelay = 0.3f;
    [Tooltip("Durée du fondu d'un bouton (secondes)")]
    [SerializeField] private float buttonFadeDuration = 0.5f;
    #endregion

    private GameObject[] allPanels;

    #region Unity Callbacks
    private void Awake()
    {
        allPanels = new[] { creditsPanel, optionsPanel, audioPanel, controlsPanel };
        ValidateReferences();

        // Cache les panel secondaires et prépare le menu principal
        ShowOnly(null);

        // Prépare et affiche l'overlay noir
        if (fadeCoverCanvasGroup != null)
        {
            fadeCoverCanvasGroup.alpha = 1f;
            fadeCoverCanvasGroup.gameObject.SetActive(true);
        }

        // Prépare les boutons cachés et non-interactifs
        foreach (var cg in mainMenuButtonGroups)
        {
            if (cg != null)
            {
                cg.alpha = 0f;
                cg.interactable = false;
                cg.blocksRaycasts = false;
                cg.gameObject.SetActive(true);
            }
        }
    }

    private void Start()
    {
        // Lance la transition
        if (fadeCoverCanvasGroup != null)
            StartCoroutine(FadeOutOverlayAndShowButtons());
        else
            StartCoroutine(ShowButtonsSequentially());
    }
    #endregion

    #region Coroutines de transition
    private IEnumerator FadeOutOverlayAndShowButtons()
    {
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            fadeCoverCanvasGroup.alpha = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        fadeCoverCanvasGroup.alpha = 0f;
        fadeCoverCanvasGroup.gameObject.SetActive(false);

        yield return StartCoroutine(ShowButtonsSequentially());
    }

    private IEnumerator ShowButtonsSequentially()
    {
        foreach (var cg in mainMenuButtonGroups)
        {
            if (cg == null) continue;

            float t = 0f;
            while (t < buttonFadeDuration)
            {
                cg.alpha = Mathf.Lerp(0f, 1f, t / buttonFadeDuration);
                t += Time.deltaTime;
                yield return null;
            }
            cg.alpha = 1f;
            cg.interactable = true;
            cg.blocksRaycasts = true;

            yield return new WaitForSeconds(buttonRevealDelay);
        }
    }
    #endregion

    #region UI Actions
    public void StartNewGame() => SceneManager.LoadScene(gameSceneName);

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void ShowCredits() => ShowOnly(creditsPanel);
    public void HideCredits() => ShowOnly(null);

    public void ShowOptions() => ShowOnly(optionsPanel);
    public void HideOptions() => ShowOnly(null);

    public void ShowAudioSettings() => ShowOnly(audioPanel);
    public void HideAudioSettings() => ShowOnly(optionsPanel);

    public void ShowControls() => ShowOnly(controlsPanel);
    public void HideControls() => ShowOnly(optionsPanel);

    public void SetMasterVolume(float volume) => AudioListener.volume = Mathf.Clamp01(volume);
    #endregion

    #region Helper Methods
    private void ShowOnly(GameObject panelToShow)
    {
        foreach (var p in allPanels)
            if (p != null)
                p.SetActive(p == panelToShow);
    }

    private void ValidateReferences()
    {
        if (creditsPanel == null) Debug.LogError("creditsPanel n'est pas assigné.", this);
        if (optionsPanel == null) Debug.LogError("optionsPanel n'est pas assigné.", this);
        if (audioPanel == null) Debug.LogError("audioPanel n'est pas assigné.", this);
        if (controlsPanel == null) Debug.LogError("controlsPanel n'est pas assigné.", this);
        // fadeCoverCanvasGroup et mainMenuButtonGroups peuvent rester vides
    }
    #endregion
}
