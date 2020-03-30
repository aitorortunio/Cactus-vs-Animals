using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        var coinDisplay = FindObjectOfType<CoinsDisplay>();
        int defenderCost = defenderPrefab.getCost();
        if (coinDisplay.enoughCoins(defenderCost))
        {
            if (GetComponent<SpriteRenderer>().color == Color.white)
            {
                GetComponent<SpriteRenderer>().color = new Color32(108, 108, 108, 255);
                FindObjectOfType<DefenderSpawner>().SetSelectedDefender(null, this);
            }
            else
            {
                var buttons = FindObjectsOfType<DefenderButton>();
                foreach (DefenderButton button in buttons)
                {
                    button.GetComponent<SpriteRenderer>().color = new Color32(108, 108, 108, 255);
                }
                GetComponent<SpriteRenderer>().color = Color.white;
                FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab, this);
            }
        }
    }
}
