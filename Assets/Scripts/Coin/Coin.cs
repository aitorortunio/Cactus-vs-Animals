using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int points = 15;

    public void OnMouseDown()
    {
        FindObjectOfType<CoinsDisplay>().AddCoins(15);
        Destroy(gameObject);
    }
}
