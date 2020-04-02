using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    Button defenderButton;
    private bool powerUp = false;

    public bool DefenderSelected()
    {
        return defender != null;
    }

    private void OnMouseDown()
    {
        if (defender != null)
        {
            attempToSpawnDefenderAt(getSquareClik());
        }
    }

    public void SetSelectedDefender(Defender selectedDefender,Button button)
	{
        defender = selectedDefender;
        defenderButton = button;
	}

    public void SetSelectedDefenderPowerUp(Defender selectedDefender, Button button,bool powerUp)
    {
        defender = selectedDefender;
        defenderButton = button;
        this.powerUp = powerUp;
    }

    private void attempToSpawnDefenderAt(Vector2 gridPos)
    {
        var coinDisplay = FindObjectOfType<CoinsDisplay>();
        int defenderCost = defender.getCost();
        if (coinDisplay.enoughCoins(defenderCost))
        {
            SpawnDefender(gridPos);
            coinDisplay.SpendCoins(defenderCost);
        }
    }

    private Vector2 getSquareClik()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        Vector2 proccesedWorldPos = new Vector2(newX, newY);
        return proccesedWorldPos;
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        defenderButton.GetComponent<SpriteRenderer>().color = new Color32(108, 108, 108, 255);
        Defender newDefender = Instantiate(defender, worldPos, Quaternion.identity) as Defender;
        if (powerUp)
        {
            defenderButton.DestroyButton();
        }
        powerUp = false;
        defender = null;
        defenderButton = null;
    }
}
