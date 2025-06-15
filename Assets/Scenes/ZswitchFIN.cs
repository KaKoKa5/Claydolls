using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class ZswitchFIN : MonoBehaviour
{
    [SerializeField] private string FIN = "FIN";

    public void StartNewGame() => SceneManager.LoadScene(FIN);

}
