using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;
    [SerializeField] int range;
    private AttackerSpawner myLaneSpawner;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }

    public void Fire()
    {
        Vector2 projectilePosition = new Vector2(transform.position.x + 0.37f, transform.position.y - 0.1f);
        Instantiate(projectile, projectilePosition, transform.rotation);
        animator.SetBool("isAttacking", false);
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= 0.5);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool attackerInLane()
    {
        if (myLaneSpawner.transform.childCount > 0)
        {
            if (myLaneSpawner.transform.GetChild(0).position.x - transform.position.x < range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
        
    }

    private void Update()
    {
        if (attackerInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
