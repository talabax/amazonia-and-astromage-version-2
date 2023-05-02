using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player1;
    Vector3 increment = new Vector3(5, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player1);
        if (player1 != null)
        {
            transform.position = player1.transform.position + increment ;
        }
    }
}
