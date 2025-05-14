using UnityEngine;
using UnityEngine.Video;
using System.Collections;

public class AutoHideVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private GameObject videoObject;
    
    [SerializeField] private float Time = 3f;
    public void Start()
    {
        videoObject.SetActive(false);
        videoPlayer.Stop();

    }

    public void Video()
    {
        videoObject.SetActive(true);
        videoPlayer.Play();
        StartCoroutine(HideAfterSeconds(Time));
    }

    IEnumerator HideAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        videoPlayer.Stop();
        videoObject.SetActive(false);
    }
}
