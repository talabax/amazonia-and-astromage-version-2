 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerLives : MonoBehaviour
{
    [SerializeField] TMP_Text life;

    
    int currentPlayerLives;
    HPLifeSingleton hPLifeSingleton;
    SceneController sceneController;
    

    void Start()
    {
        sceneController = FindObjectOfType<SceneController>();
        hPLifeSingleton = FindObjectOfType<HPLifeSingleton>();
        currentPlayerLives = hPLifeSingleton.LifeValue();

    }

    void Update()
    {
        life.text = "x" + HPLifeSingleton.Instance.LifeValue();
       // Debug.Log(HPLifeSingleton.Instance.LifeValue());
    }


    public void LifeLost()
    {


        if (HPLifeSingleton.Instance.LifeValue() >= 1)
        {

            HPLifeSingleton.Instance.RemoveLife();
            Debug.Log("life lost here");




            sceneController.RestartCurrentLevel();
        }
        else if (HPLifeSingleton.Instance.LifeValue() < 1)
        {

            Debug.Log("you died");
            sceneController.ReturnMenu();

        }

    }



      

    
    

  

   



   




    

    

}
