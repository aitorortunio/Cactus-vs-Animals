using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 2f)] [SerializeField] float speed = 1f;
    [SerializeField] float damage;
    GameObject currentTarget;
    private float currentSpeed;

    private void Awake()
    {
        FindObjectOfType<LevelController>().attackerSpawned();
    }

    private void OnDestroy()
    {
        FindObjectOfType<LevelController>().attackerKilled();

    }

    private void Start()
    {
        currentSpeed = speed;
    }

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    public void slow(float slow)
    {
        speed *= 1-(slow/100);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void normalSpeed()
    {
        SetMovementSpeed(speed);
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;   
    }

    public void strikeTarget()
    {
        if (!currentTarget)
        {
            return;
        }
        Health health = currentTarget.GetComponent<Health>();
        health.DealDamage(damage);
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }
}
