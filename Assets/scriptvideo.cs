using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class scriptvideo : MonoBehaviour

{
    public VideoPlayer videoPlayer;
    public string sceneToLoad = "SampleScene"; // Met le nom de ta scène ici (ou utilise l’index si tu préfères)

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