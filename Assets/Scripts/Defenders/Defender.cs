using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Defender : MonoBehaviour
{
    [SerializeField] int cost;

    public int getCost()
    {
        return cost;
    }

    public void AddCoins(int amount)
    {
        FindObjectOfType<CoinsDisplay>().AddCoins(amount);
    }

    
}
