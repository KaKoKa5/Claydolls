using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashLogoController : MonoBehaviour
{
    [Header("Nom de la scène suivante")]
    [Tooltip("Met ici le nom exact de ta scène de menu principal ou de jeu")]
    public string nextScene = "MainMenu";

    [Header("Durée du splash (secondes)")]
    public float duration = 2.0f;

    private void Start()
    {
        StartCoroutine(ShowThenLoad());
    }

    private IEnumerator ShowThenLoad()
    {
        // Attend la durée souhaitée
        yield return new WaitForSeconds(duration);
        // Charge la scène suivante
        SceneManager.LoadScene(nextScene);
    }
}
