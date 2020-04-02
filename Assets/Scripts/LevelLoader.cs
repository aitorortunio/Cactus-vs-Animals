using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver_Screen");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Start_Screen");
    }

    public void loadYouWinScene()
    {
        SceneManager.LoadScene("Win_Screen");
    }

    public void loadHowToPlay1()
    {
        SceneManager.LoadScene("HTP_Screen_1");
    }

    public void loadHowToPlay2()
    {
        SceneManager.LoadScene("HTP_Screen_2");
    }

    public void loadHowToPlay3()
    {
        SceneManager.LoadScene("HTP_Screen_3");
    }
}
