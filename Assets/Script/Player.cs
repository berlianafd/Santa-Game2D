using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour {
    public Text candyText;
    private int totalCandys = 0;

    public Image starImage;
    public Sprite iconStar;
    public Sprite iconNoStar;
    private bool carryingStar = false;

    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalTree = 0;

    void Start() {
        UpdateCandyText();
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }

    void OnTriggerEnter2D(Collider2D hit) {
        if (hit.CompareTag("Candy")) {
            totalCandys++;
            UpdateCandyText();
            Destroy(hit.gameObject);
        }
        else if (hit.CompareTag("Star"))
        {
            carryingStar = true;
            UpdateStarImage();
            Destroy(hit.gameObject);
        }
        else if (hit.CompareTag("Tree"))
        {
            totalTree++;
            playerInventoryDisplay.OnChangeTreeTotal(totalTree);
            Destroy(hit.gameObject);
        }
    }

    private void UpdateCandyText() {
        string candyMessage = "Candy = " + totalCandys;
        candyText.text = candyMessage;
    }

    private void UpdateStarImage() {
        if (carryingStar) starImage.sprite = iconStar;
        else starImage.sprite = iconNoStar;
    }

} 