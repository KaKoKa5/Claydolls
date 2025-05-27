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
    [SerializeField] private RectTransform pausePanel;
    [SerializeField] private RectTransform optionsPanel;
    [SerializeField] private RectTransform controlsPanel;
    [SerializeField] private RectTransform audioPanel;

    [Header("Boutons - Pause")]
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button optionsButton;
    [SerializeField] private Button quitButton;

    [Header("Boutons - Options")]
    [SerializeField] private Button optionsBackButton;
    [SerializeField] private Button controlsButton;
    [SerializeField] private Button audioButton;

    [Header("Boutons - Sous-menus")]
    [SerializeField] private Button controlsBackButton;
    [SerializeField] private Button audioBackButton;
    #endregion

    private CanvasGroup canvasGroup;
    private bool isPaused = false;

    #region Unity Callbacks
    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();

        pausePanel    = pausePanel    ?? transform.Find("PausePanel")   as RectTransform;
        optionsPanel  = optionsPanel  ?? transform.Find("OptionsPanel") as RectTransform;
        controlsPanel = controlsPanel ?? transform.Find("ControlsPanel")as RectTransform;
        audioPanel    = audioPanel    ?? transform.Find("AudioPanel")   as RectTransform;

        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        optionsPanel?.gameObject.SetActive(false);
        controlsPanel?.gameObject.SetActive(false);
        audioPanel?.gameObject.SetActive(false);
    }

    private void Start()
    {
        resumeButton.onClick.AddListener(TogglePause);
        optionsButton.onClick.AddListener(OpenOptionsMenu);
        quitButton.onClick.AddListener(QuitToMainMenu);

        optionsBackButton.onClick.AddListener(CloseOptionsMenu);
        controlsButton.onClick.AddListener(OpenControlsMenu);
        audioButton.onClick.AddListener(OpenAudioMenu);

        controlsBackButton.onClick.AddListener(CloseControlsMenu);
        audioBackButton.onClick.AddListener(CloseAudioMenu);
    }

    private void Update()
    {
        bool escPressed =
               Input.GetKeyDown(KeyCode.Escape)
            || Input.GetButtonDown("Cancel")
    #if ENABLE_INPUT_SYSTEM
            || (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
    #endif
            ;

        if (escPressed)
            TogglePause();
    }
    #endregion

    #region Gestion pause et navigation
    private void TogglePause()
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0f : 1f;

        AudioListener.pause = isPaused;

        canvasGroup.alpha = isPaused ? 1f : 0f;
        canvasGroup.interactable = isPaused;
        canvasGroup.blocksRaycasts = isPaused;

        if (isPaused)
        {
            pausePanel.gameObject.SetActive(true);
            optionsPanel.gameObject.SetActive(false);
            controlsPanel.gameObject.SetActive(false);
            audioPanel.gameObject.SetActive(false);
        }

        Cursor.visible = isPaused;
        Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
    }

    private void OpenOptionsMenu()
    {
        pausePanel.gameObject.SetActive(false);
        optionsPanel.gameObject.SetActive(true);
    }

    private void CloseOptionsMenu()
    {
        optionsPanel.gameObject.SetActive(false);
        pausePanel.gameObject.SetActive(true);
    }

    private void OpenControlsMenu()
    {
        optionsPanel.gameObject.SetActive(false);
        controlsPanel.gameObject.SetActive(true);
    }

    private void CloseControlsMenu()
    {
        controlsPanel.gameObject.SetActive(false);
        optionsPanel.gameObject.SetActive(true);
    }

    private void OpenAudioMenu()
    {
        optionsPanel.gameObject.SetActive(false);
        audioPanel.gameObject.SetActive(true);
    }

    private void CloseAudioMenu()
    {
        audioPanel.gameObject.SetActive(false);
        optionsPanel.gameObject.SetActive(true);
    }

    private void QuitToMainMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene("MainMenu");
    }
    #endregion
}
