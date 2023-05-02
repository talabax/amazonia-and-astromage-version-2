using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HPLifeSingleton : MonoBehaviour
{
    int startingHP = 100;
    int currentHP;

    int startingMana = 100;
    int currentMana;

    int vida = 2;


    //

    SceneController sceneController;




    // 
    void Start()
    {


    }

    public static HPLifeSingleton Instance
    {
        get;

        private set;


    }

    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);

        }

    }

    private void Update()
    {
        //Debug.Log(LifeValue());
    }


    public int HPValue()
    {
        return startingHP;

    }

    public int ManaValue()
    {
        return startingMana;

    }

    public int LifeValue()
    {
        return vida;

    }

    public void RemoveLife()
    {
        vida = vida - 1;
        

    }

    public void SetHealth(int amount)
    {
        startingHP = amount;
    }

  




}
