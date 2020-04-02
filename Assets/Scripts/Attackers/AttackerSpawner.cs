using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay;
    [SerializeField] float maxSpawnDelay;
    [SerializeField] Attacker attackerPrefab1;
    [SerializeField] Attacker attackerPrefab2;
    [SerializeField] Attacker attackerPrefab3;
    [SerializeField] Attacker attackerPrefab4;
    [SerializeField] Attacker attackerPrefab5;
    [SerializeField] Attacker attackerPrefab6;
    private bool spawn = true;
    private int spawns = 0;
    private int type = 0;


    IEnumerator Start()
    {
        float wait = Random.Range(15f,25f);
        while (spawn)
        {
            yield return new WaitForSeconds(wait);
            wait = Random.Range(minSpawnDelay, maxSpawnDelay + 1);
            type = Random.Range(1, 7);
            spawns++;
            if (spawns < 5)
            {
                spawnEasyAttacker(type);
            }
            else
            {
                SpawnAttacker(type);
            }
        }
    }

    public void stopSpawning()
    {
        spawn = false;
    }

    private void spawnEasyAttacker(int type)
    {
        Attacker newAttacker;

        switch (type)
        {
            case 1:
                newAttacker = Instantiate(attackerPrefab1, transform.position, transform.rotation) as Attacker;
                break;
            case 2:
                newAttacker = Instantiate(attackerPrefab1, transform.position, transform.rotation) as Attacker;
                break;
            case 3:
                newAttacker = Instantiate(attackerPrefab2, transform.position, transform.rotation) as Attacker;
                break;
            case 4:
                newAttacker = Instantiate(attackerPrefab2, transform.position, transform.rotation) as Attacker;
                break;
            case 5:
                newAttacker = Instantiate(attackerPrefab3, transform.position, transform.rotation) as Attacker;
                break;
            case 6:
                newAttacker = Instantiate(attackerPrefab3, transform.position, transform.rotation) as Attacker;
                break;
            default:
                newAttacker = Instantiate(attackerPrefab1, transform.position, transform.rotation) as Attacker;
                break;
        }
        newAttacker.transform.parent = transform;
    }

    private void SpawnAttacker(int type)
    {
        Attacker newAttacker;

        switch (type)
        {
            case 1:
                newAttacker = Instantiate(attackerPrefab1, transform.position, transform.rotation) as Attacker;
                break;
            case 2:
                newAttacker = Instantiate(attackerPrefab2, transform.position, transform.rotation) as Attacker;
                break;
            case 3:
                newAttacker = Instantiate(attackerPrefab3, transform.position, transform.rotation) as Attacker;
                break;
            case 4:
                newAttacker = Instantiate(attackerPrefab4, transform.position, transform.rotation) as Attacker;
                break;
            case 5:
                newAttacker = Instantiate(attackerPrefab5, transform.position, transform.rotation) as Attacker;
                break;
            case 6:
                newAttacker = Instantiate(attackerPrefab6, transform.position, transform.rotation) as Attacker;
                break;
            default:
                newAttacker = Instantiate(attackerPrefab1, transform.position, transform.rotation) as Attacker;
                break;
        }
        newAttacker.transform.parent = transform;
    }

}
