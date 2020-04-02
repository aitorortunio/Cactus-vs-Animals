using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpButton : Button
{
    [SerializeField] Defender defenderPrefab;

    public override void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 0);
        FindObjectOfType<DefenderSpawner>().SetSelectedDefenderPowerUp(defenderPrefab, this,true);
    }

    public override void DestroyButton()
    {
        Destroy(gameObject);
    }
}
