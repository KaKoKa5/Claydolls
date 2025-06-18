using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class videofin : MonoBehaviour

{
    public VideoPlayer videoPlayer;
    public string sceneToLoad = "Main Menu"; // Met le nom de ta scène ici (ou utilise l’index si tu préfères)

    void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}