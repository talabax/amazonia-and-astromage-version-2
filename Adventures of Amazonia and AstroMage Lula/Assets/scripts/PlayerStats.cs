using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    int currentHealth;

    int y;
    int startingMana = 100;
    int currentMana;
    bool result;
    
    PlayerLives playerLives;
    HPLifeSingleton hPLifeSingleton;
    SceneController sceneController;
    GameObject player;
    SpriteRenderer spriteR;
    Movement movements;
    Rigidbody2D rb2d;
    
    

    int sceneIndex;


    DamageEffects damageEffects;

    void Start()
    {
        playerLives = FindObjectOfType<PlayerLives>();
        hPLifeSingleton = FindObjectOfType<HPLifeSingleton>();
        currentHealth = hPLifeSingleton.HPValue();
        currentMana = hPLifeSingleton.ManaValue();

        

        player = GameObject.FindGameObjectWithTag("Player");
        rb2d = player.GetComponent<Rigidbody2D>();
        damageEffects = FindObjectOfType<DamageEffects>();

        

        sceneController = FindObjectOfType<SceneController>();
        sceneIndex = sceneController.CurrentIndex();


        player = GameObject.FindGameObjectWithTag("Player");
        spriteR = player.GetComponent<SpriteRenderer>();
        movements = player.GetComponent<Movement>();
        sceneController = FindObjectOfType<SceneController>();






        
    }

    void Update()
    {
    }



    public void PlayerDeath()
    {
        


        StopActions();


    }

    public void PlayerTakesDamage( int amount)
    {
        damageEffects.DamageWarning();
        currentHealth = currentHealth - amount;
        hPLifeSingleton.SetHealth(currentHealth);         

        if (currentHealth <= 0)
        {

            StopActions();

        }

    }

    public void PlayerGainsLife(int amount)
    {
        currentHealth = currentHealth + amount;

    }


    public int PlayerHealth()
    {

        return currentHealth;


    }




    //handle mana



    public void PlayerGainsMana(int amount)
    {
        currentMana = currentMana + amount;



    }

    


    void StopActions()
    {
        playerLives.LifeLost();
        
        //remove sprite
        Destroy(spriteR);
        
        //stop movement inputs
        movements.Dead();
        
        //stop physics
        rb2d.bodyType = RigidbodyType2D.Static;

        StartCoroutine(WaitDelay());

    }


    public int PlayerMana()
    {

        return currentMana;


    }

    
    public bool PlayerLosesMana(int amount)
    {
        if( amount <= currentMana)
        {
            currentMana = currentMana - amount;

            result = true;
        }
        else if (amount > currentMana)
        {
            result= false;  
        }

        return result;
    }
    

    IEnumerator WaitDelay()
    {

        yield return new WaitForSeconds(2);
        //sceneController.RestartCurrentLevel();

    }





}
