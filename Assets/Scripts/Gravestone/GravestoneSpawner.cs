using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravestoneSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay;
    [SerializeField] float maxSpawnDelay;
    [SerializeField] PowerUpButton gravestoneButtonPrefab;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnGravestone();
        }
    }


    private void SpawnGravestone()
    {
        int scale = 100;
        float newX = Random.Range(2 * scale, 8 * scale);
        float newY = Random.Range(1 * scale, 5 * scale);
        Vector2 position = new Vector2(newX / scale, newY / scale);
        PowerUpButton newGravestone = Instantiate(gravestoneButtonPrefab, position, Quaternion.identity) as PowerUpButton;
    }

}
