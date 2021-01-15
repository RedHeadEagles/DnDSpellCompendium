using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static int lastScene;

    private int currentScene;

    // Start is called before the first frame update
    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    private void Update()
    {
        BackButtonPressed();
    }

    public void LoadNextScene(int numberOfSceneToLoad)
    {
        StartCoroutine(LoadScene(numberOfSceneToLoad));
    }

    private IEnumerator LoadScene(int numberOfScene)
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SetLastScene(currentScene);

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(numberOfScene);
    }

    private void BackButtonPressed()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Current scene: " + currentScene);
            Debug.Log("Last scene (scene to load): " + GetLastScene());
            SceneManager.LoadScene(GetLastScene());
            currentScene = GetLastScene();
            lastScene -= lastScene;
            Debug.Log("Now the Current scene is: " + currentScene);
            Debug.Log("And the scene to load is: " + lastScene);
        }
    }

    public static void SetLastScene(int currentSceneToLastScene)
    {
        lastScene = currentSceneToLastScene;
    }

    public static int GetLastScene()
    {
        return lastScene;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
