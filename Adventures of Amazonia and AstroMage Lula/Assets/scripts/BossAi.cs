using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAi : MonoBehaviour
{
    [SerializeField] GameObject mucus;
    [SerializeField] GameObject mucusAngle;
    [SerializeField] Transform spawnPoint;
    int time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MucosSpit()
    {
        GameObject spitA = Instantiate(mucus, spawnPoint.position, Quaternion.identity) as GameObject;
        Destroy(spitA, 5);

    }




    public void MucosSpitAngle ()
    {
        GameObject spit = Instantiate(mucusAngle, spawnPoint.position, Quaternion.Euler(0,0,-45)) as GameObject;
        Destroy(spit, 3);

    }








}
