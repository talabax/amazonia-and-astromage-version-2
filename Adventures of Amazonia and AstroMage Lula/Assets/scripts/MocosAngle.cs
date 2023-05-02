using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MocosAngle : MonoBehaviour
{
    Rigidbody2D rB;




    private void Awake()
    {
        rB = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        rB.velocity = new Vector3(-5, 5, 0);

    }




}
