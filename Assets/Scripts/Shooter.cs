using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;

    public void Fire()
    {
        Vector2 newVector = new Vector2(transform.position.x + 0.9f, transform.position.y - 0.1f);
        Instantiate(projectile,newVector, transform.rotation);
    }
}
