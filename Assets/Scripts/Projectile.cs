using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 10f)] [SerializeField] float speed = 5f;
    [SerializeField] bool slowEnemy;
    [SerializeField] float howSlow;
    [SerializeField] float damage = 50;

    IEnumerator Start()
    {
        {
            yield return new WaitForSeconds(2f);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var health = collider.GetComponent<Health>();
        var attacker = collider.GetComponent<Attacker>();

        if(attacker && health)
        {
            if (slowEnemy)
            {
                attacker.slow(howSlow);
            }
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
