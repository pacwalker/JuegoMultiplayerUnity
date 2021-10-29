using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameSceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("Level1").buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
