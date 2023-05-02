using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bobble(); 
    }

    void Bobble()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.Sin(Time.time / .5f) * .00055f, 0f);



    }




}
