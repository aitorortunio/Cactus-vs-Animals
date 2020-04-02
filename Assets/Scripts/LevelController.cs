using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int numberOfAttackers = 0;
    private bool levelTimerHasFinished = false;

    public void attackerSpawned()
    {
        numberOfAttackers++;
    }

    public void attackerKilled()
    {
        numberOfAttackers--;
        if (numberOfAttackers<=0 && levelTimerHasFinished)
        {
            FindObjectOfType<LevelLoader>().loadYouWinScene();
        }
    }

    public void levelTimerFinished()
    {
        levelTimerHasFinished = true;
        stopSpawning();
    }

    private void stopSpawning()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners){
            spawner.stopSpawning();
        }
    }
}
