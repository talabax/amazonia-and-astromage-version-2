using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPower : MonoBehaviour
{

    PlayerStats thePlayer;

    // Start is called before the first frame update
    void Awake()
    {
        thePlayer = FindObjectOfType<PlayerStats>();

    }

    // Update is called once per frame
    void Update()
    {
        Bobble();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //damageEffects.DamageWarning();
            thePlayer.PlayerGainsMana(10);
            Destroy(gameObject);
        }


    }


    void Bobble()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.Sin(Time.time / .5f) * .00055f, 0f);



    }

}
