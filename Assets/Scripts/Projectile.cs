using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 10f)] [SerializeField] float speed = 3.5f;
    [SerializeField] float damage = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var health = collider.GetComponent<Health>();
        health.DealDamage(damage);
        Destroy(gameObject);
    }
}
