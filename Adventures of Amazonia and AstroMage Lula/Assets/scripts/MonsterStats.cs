using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStats : MonoBehaviour
{
    PowerUPSpawner powerUpSpawner;
    int monsterHealth = 50;
    int monsterCurrentHealth;
    Vector3 location;


    // Start is called before the first frame update
    void Start()
    {
        powerUpSpawner = GetComponent<PowerUPSpawner>();
        monsterCurrentHealth = monsterHealth;  
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(transform.position);
    }

    


    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collision entered");
        if(collision.gameObject.tag == "star")
        {
            GameObject weaponDamage = collision.gameObject;
            ProjectileDirections weaponDam = weaponDamage.GetComponent<ProjectileDirections>();
            //Debug.Log(weaponDam.Damage());
            TakeDamage(weaponDam.Damage());
            Destroy(collision.gameObject);
        }

    }



    void TakeDamage(int dam)
    {
        monsterCurrentHealth = monsterCurrentHealth - dam;
        if(monsterCurrentHealth <= 0)
        {
            location = transform.position;
            Debug.Log(location + " is this");
            powerUpSpawner.SpawnPowerUp(location);
            Destroy(gameObject);

        }
    }




    





}
