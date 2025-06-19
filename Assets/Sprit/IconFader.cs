using UnityEngine;
using System.Collections;

public class IconFader : MonoBehaviour
{
    public CanvasGroup[] icons;
    public float fadeDuration = 1f;

    public void FadeIn()
    {
        StopAllCoroutines();
        foreach (CanvasGroup cg in icons)
            StartCoroutine(FadeTo(cg, 1f));
    }

    public void FadeOut()
    {
        StopAllCoroutines();
        foreach (CanvasGroup cg in icons)
            StartCoroutine(FadeTo(cg, 0f));
    }

    private IEnumerator FadeTo(CanvasGroup cg, float targetAlpha)
    {
        float startAlpha = cg.alpha;
        float elapsed = 0f;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / fadeDuration);
            cg.alpha = Mathf.Lerp(startAlpha, targetAlpha, t);
            yield return null;
        }

        cg.alpha = targetAlpha;
        cg.interactable = targetAlpha > 0f;
        cg.blocksRaycasts = targetAlpha > 0f;
    }
}
