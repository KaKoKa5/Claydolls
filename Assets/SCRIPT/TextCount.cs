using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;
public class NewMonoBehaviourScript : MonoBehaviour
{

[SerializeField] private string text;
[SerializeField] private TextMeshProUGUI TMPROui;
[SerializeField] private int Count;
private int Textindex;
private float Timeurt;

    void Start()
    {
        Timeurt = Count;
        Textindex=0;
        TMPROui=this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Timeurt -= Time.deltaTime;
        if (Timeurt<=0 && Textindex < text.Length)
        {
            TMPROui.text+= text[Textindex];
            Timeurt += Count;
            Textindex +=1;
        }
    }
}
