using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsDisplay : MonoBehaviour
{
    [SerializeField] int coins = 100;
    [SerializeField] AudioClip sound;
    Text coinsText;

    void Start()
    {
        coinsText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        coinsText.text = coins.ToString();
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateDisplay();
        AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position, 0.2f);
    }

    public void SpendCoins(int amount)
    {
        if (coins >= amount)
        {
            coins -= amount;
            UpdateDisplay();
        }
    }

    public bool enoughCoins(int amount)
    {
        return coins >= amount;
    }

}
