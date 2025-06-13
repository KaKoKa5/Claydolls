using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public static AudioManager I;
    void Awake()
    {
        if (I != null && I != this) { Destroy(gameObject); return; }
        I = this;
        DontDestroyOnLoad(gameObject);
    }
}
