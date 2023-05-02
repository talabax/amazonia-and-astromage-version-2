using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
       // transform.position = Vector3.MoveTowards(transform.position, target.position, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("contact made!");
            GameObject player = collision.gameObject;
            PlayerStats playerStats = player.GetComponent<PlayerStats>();
            playerStats.PlayerTakesDamage(20);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        


    }

}
