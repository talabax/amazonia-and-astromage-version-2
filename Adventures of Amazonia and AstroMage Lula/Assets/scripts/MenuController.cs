using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    HPLifeSingleton hpSingleton;

    int sceneindex;




    public int CurrentIndex()
    {
        sceneindex = SceneManager.GetActiveScene().buildIndex;
        return sceneindex;

    }

    private void Awake()
    {
        hpSingleton = FindObjectOfType<HPLifeSingleton>();
        if (hpSingleton != null)
        {
            Destroy(hpSingleton);
        }


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

        SceneManager.LoadScene(CurrentIndex());

    }



  

}
