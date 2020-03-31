using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaperMan1: Attacker
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if (otherObject.GetComponent<Defender>())
        {
            this.Attack(otherObject);
        }
    }
}
