using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    bool gameHasStarted = false;
    HPLifeSingleton hPLifeSingleton;

    int sceneindex;

    public int CurrentIndex()
    {
        sceneindex = SceneManager.GetActiveScene().buildIndex;
        return sceneindex;

    }



    private void Start()
    {
        
        hPLifeSingleton = FindObjectOfType<HPLifeSingleton>();

        sceneindex = SceneManager.GetActiveScene().buildIndex;
    }



    public void LoadScene(int number)
    {



    }


    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }

   



    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);


    }

    public void LoadCredits(int number)
    {



    }

    public void LoadTutorial(int number)
    {



    }

    public void LoadNextScene()
    {
        

        SceneManager.LoadScene(sceneindex + 1);


    }

    public void RestartCurrentLevel()
    {
        hPLifeSingleton.SetHealth(100);

        SceneManager.LoadScene(CurrentIndex());

    }





}
