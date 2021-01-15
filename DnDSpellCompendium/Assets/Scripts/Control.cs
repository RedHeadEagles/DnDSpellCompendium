using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    private int currentScene;

    private Scene s;

    private void Start()
    {
        s = SceneManager.GetActiveScene();
        currentScene = s.buildIndex;
    }

    // Update is called once per frame
    private void Update()
    {
        BackButtonPressed();
    }

    public void NextScene(int index)
    {
        SceneManager.LoadScene(index);
        currentScene = index;
    }

    private void BackButtonPressed()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentScene == 0)
            {
                Application.Quit();
            }
            if (currentScene == 1 || currentScene == 2)
            {
                NextScene(0);
            }
            if (currentScene >= 3 && currentScene <= 9)
            {
                NextScene(1);
            }
            if (currentScene >= 10 && currentScene <= 18)
            {
                NextScene(2);
            }
            if (currentScene >= 19 && currentScene <= 42)
            {
                NextScene(3);
            }
            if (currentScene >= 43 && currentScene <= 69)
            {
                NextScene(4);
            }
            if (currentScene >= 70 && currentScene <= 99)
            {
                NextScene(5);
            }
            if (currentScene >= 100 && currentScene <= 124)
            {
                NextScene(6);
            }
            if (currentScene >= 125 && currentScene <= 147)
            {
                NextScene(7);
            }
            if (currentScene >= 148 && currentScene <= 169)
            {
                NextScene(8);
            }
            if (currentScene >= 170 && currentScene <= 190)
            {
                NextScene(9);
            }
            if (currentScene >= 191 && currentScene <= 235)
            {
                NextScene(10);
            }
            if (currentScene >= 236 && currentScene <= 278)
            {
                NextScene(11);
            }
            if (currentScene >= 279 && currentScene <= 314)
            {
                NextScene(12);
            }
            if (currentScene >= 315 && currentScene <= 356)
            {
                NextScene(13);
            }
            if (currentScene >= 357 && currentScene <= 396)
            {
                NextScene(14);
            }
            if (currentScene >= 397 && currentScene <= 436)
            {
                NextScene(15);
            }
            if (currentScene >= 437 && currentScene <= 462)
            {
                NextScene(16);
            }
            if (currentScene >= 463 && currentScene <= 484)
            {
                NextScene(17);
            }
            if (currentScene >= 485 && currentScene <= 502)
            {
                NextScene(18);
            }
        }
    }
}
