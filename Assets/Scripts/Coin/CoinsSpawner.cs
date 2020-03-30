using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 2f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Coin coinPrefab;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnCoin();
        }
    }


    private void SpawnCoin()
    {
        int scale = 100;
        float newX = Random.Range(2*scale, 8*scale);
        float newY = Random.Range(1*scale, 5*scale);
        Vector2 position = new Vector2(newX/scale, newY/scale);
        Coin newCoin = Instantiate(coinPrefab, position, Quaternion.identity) as Coin;
    }

}
