using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour {
    public Image[] treePlaceholders;
    public Sprite iconTreeGreen;
    public Sprite iconTreeGrey;

    public void OnChangeTreeTotal(int treeTotal) {
        for (int i = 0; i < treePlaceholders.Length; ++i) {
            if (i < treeTotal) treePlaceholders[i].sprite = iconTreeGreen;
            else treePlaceholders[i].sprite = iconTreeGrey;
        }
    }
}
