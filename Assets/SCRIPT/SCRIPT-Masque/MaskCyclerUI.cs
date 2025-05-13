using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class MaskCyclerUI : MonoBehaviour
{
    [Header("Tous les masques (Âne, Loup, Lion, Phénix)")]
    public GameObject[] masks;    
    [Header("Icône UI")]
    public Image maskIcon;        
    public Sprite[] maskSprites;  

    private List<int> unlocked = new List<int>();
    private int cursor = 0;
    private int equippedMask = 0;

    void Start()
    {
        for (int i = 0; i < masks.Length; i++)
            masks[i].SetActive(false);

        unlocked.Clear();
        unlocked.Add(0);
        cursor = 0;
        equippedMask = 0;
        UpdateEquippedMask(0);
    }

    void Update()
    {
        if (unlocked.Count <= 1)
            return;

        if (Input.GetMouseButtonDown(1))
        {
            cursor = (cursor + 1) % unlocked.Count;

            TableauMemoire.masque =  unlocked[cursor];
            
            if(TableauMemoire.masque == 0)
            {
                Debug.Log("Ane");
            }
            else if (TableauMemoire.masque==1)
            {
                Debug.Log("loup");
            }
            else if (TableauMemoire.masque==2)
            {
                Debug.Log("lion");
            }
            else if (TableauMemoire.masque==3)
            {
                Debug.Log("phenix");
            }
            else
            {
                return;
            }

            UpdateEquippedMask(unlocked[cursor]);
        }
    }

    public void UnlockMask(int maskIndex)
    {
        if (maskIndex < 0 || maskIndex >= masks.Length) return;
        if (unlocked.Contains(maskIndex)) return;

        unlocked.Add(maskIndex);
        cursor = unlocked.Count - 1;
        UpdateEquippedMask(maskIndex);
    }

    private void UpdateEquippedMask(int maskIndex)
    {
        masks[equippedMask].SetActive(false);

        masks[maskIndex].SetActive(true);

        if (maskIcon != null && maskSprites.Length > maskIndex)
            maskIcon.sprite = maskSprites[maskIndex];

        equippedMask = maskIndex;
    }
}