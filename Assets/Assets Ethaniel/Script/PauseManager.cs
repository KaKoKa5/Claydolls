#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class PauseManager : MonoBehaviour
{
    #region Champs configurables
    [Header("Panels UI")]
    [SerializeField] private RectTransform pausePanel;       // panneau principal de pause
    [SerializeField] private RectTransform optionsPanel;     // panneau des options
    [SerializeField] private RectTransform controlsPanel;    // panneau des contrôles
    [SerializeField] private RectTransform audioPanel;       // panneau audio

    [Header("Boutons - Pause")]
    [SerializeField] private Button resumeButton;            // bouton Reprendre
    [SerializeField] private Button optionsButton;           // bouton Options
    [SerializeField] private Button quitButton;              // bouton Quitter

    [Header("Boutons - Options")]
    [SerializeField] private Button optionsBackButton;       // bouton Retour du menu Options
    [SerializeField] private Button controlsButton;          // bouton Contrôles
    [SerializeField] private Button audioButton;             // bouton Audio

    [Header("Boutons - Sous-menus")]
    [SerializeField] private Button controlsBackButton;      // bouton Retour du sous-menu Contrôles
    [SerializeField] private Button audioBackButton;         // bouton Retour du sous-menu Audio
    #endregion

    private CanvasGroup canvasGroup;  // référence au CanvasGroup pour gérer visibilité et interactions
    private bool isPaused = false;    // état de la pause

    #region Unity Callbacks
    private void Awake()
    {
        // Récupère le CanvasGroup (obligatoire via RequireComponent)
        canvasGroup = GetComponent<CanvasGroup>();

        // Liaison automatique des panels si non assignés
        pausePanel    = pausePanel    ?? transform.Find("PausePanel")   as RectTransform;
        optionsPanel  = optionsPanel  ?? transform.Find("OptionsPanel") as RectTransform;
        controlsPanel = controlsPanel ?? transform.Find("ControlsPanel") as RectTransform;
        audioPanel    = audioPanel    ?? transform.Find("AudioPanel")    as RectTransform;

        // Cache l'UI au lancement
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        // Désactive les sous-menus
        if (optionsPanel  != null) optionsPanel.gameObject.SetActive(false);
        if (controlsPanel != null) controlsPanel.gameObject.SetActive(false);
        if (audioPanel    != null) audioPanel.gameObject.SetActive(false);
    }

    private void Start()
    {
        // Attache les callbacks des boutons du menu pause
        resumeButton.onClick.AddListener(TogglePause);
        optionsButton.onClick.AddListener(OpenOptionsMenu);
        quitButton.onClick.AddListener(QuitToMainMenu);

        // Attache les callbacks des boutons du menu options
        optionsBackButton.onClick.AddListener(CloseOptionsMenu);
        controlsButton.onClick.AddListener(OpenControlsMenu);
        audioButton.onClick.AddListener(OpenAudioMenu);

        // Attache les callbacks des sous-menus
        controlsBackButton.onClick.AddListener(CloseControlsMenu);
        audioBackButton.onClick.AddListener(CloseAudioMenu);
    }

    private void Update()
    {
        // Détection d'appui sur Échap (ancien et nouveau Input System)
        bool escPressed =
               Input.GetKeyDown(KeyCode.Escape)
            || Input.GetButtonDown("Cancel")
    #if ENABLE_INPUT_SYSTEM
            || (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
    #endif
            ;

        if (escPressed)
            TogglePause(); // bascule l'état de pause
    }
    #endregion

    #region Gestion pause et navigation
    private void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f; // fige ou reprend le temps

        // Affiche ou masque l'UI de pause
        canvasGroup.alpha = isPaused ? 1f : 0f;
        canvasGroup.interactable = isPaused;
        canvasGroup.blocksRaycasts = isPaused;

        if (isPaused)
        {
            // Affiche le panneau principal et cache les autres
            pausePanel.gameObject.SetActive(true);
            optionsPanel.gameObject.SetActive(false);
            controlsPanel.gameObject.SetActive(false);
            audioPanel.gameObject.SetActive(false);
            
        }

        // Gestion du curseur
        Cursor.visible = isPaused;
        Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
    }

    private void OpenOptionsMenu()
    {
        pausePanel.gameObject.SetActive(false);    // cache le panneau pause
        optionsPanel.gameObject.SetActive(true);   // affiche le panneau options
    }

    private void CloseOptionsMenu()
    {
        optionsPanel.gameObject.SetActive(false);  // cache le panneau options
        pausePanel.gameObject.SetActive(true);     // affiche le panneau pause
    }

    private void OpenControlsMenu()
    {
        optionsPanel.gameObject.SetActive(false);   // cache le panneau options
        controlsPanel.gameObject.SetActive(true);   // affiche le panneau contrôles
    }

    private void CloseControlsMenu()
    {
        controlsPanel.gameObject.SetActive(false);  // cache le panneau contrôles
        optionsPanel.gameObject.SetActive(true);    // affiche le panneau options
    }

    private void OpenAudioMenu()
    {
        optionsPanel.gameObject.SetActive(false);   // cache le panneau options
        audioPanel.gameObject.SetActive(true);      // affiche le panneau audio
    }

    private void CloseAudioMenu()
    {
        audioPanel.gameObject.SetActive(false);     // cache le panneau audio
        optionsPanel.gameObject.SetActive(true);    // affiche le panneau options
    }

    private void QuitToMainMenu()
    {
        Time.timeScale = 1f;                        // assure le temps normal
        SceneManager.LoadScene("MainMenu");       // retourne au menu principal
    }
    #endregion
}
