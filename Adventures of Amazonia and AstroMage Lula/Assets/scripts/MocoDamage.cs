using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MocoDamage : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update

    PlayerStats thePlayer;
    DamageEffects damageEffects;
    private void Awake()
    {
        damageEffects = FindObjectOfType<DamageEffects>();
        thePlayer = FindObjectOfType<PlayerStats>();
    }




    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //damageEffects.DamageWarning();
            thePlayer.PlayerTakesDamage(20);
            Destroy(gameObject);
        }


    }




}