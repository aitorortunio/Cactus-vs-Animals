using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLife : MonoBehaviour
{
    [SerializeField] int lives = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadGameOverScene();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherObject = other.gameObject;

        if (otherObject.GetComponent<Attacker>())
        {
            LoseLife();
            Destroy(other.gameObject);
        }
    }
}
