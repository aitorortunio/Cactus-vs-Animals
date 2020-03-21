using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;

    public void Fire()
    {
        Vector2 projectilePosition = new Vector2(transform.position.x + 0.37f, transform.position.y - 0.1f);
        Instantiate(projectile, projectilePosition, transform.rotation);
    }
}
