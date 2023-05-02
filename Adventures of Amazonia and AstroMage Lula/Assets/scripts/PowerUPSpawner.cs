using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUPSpawner : MonoBehaviour
{
    int randomPowerUp;
    [SerializeField] GameObject[] powerUps;
    //[SerializeField] Transform spawnP;
    // Start is called before the first frame update

    private void Update()
    {
        //SpawnPowerUp();
    }

    public void SpawnPowerUp(Vector3 vector)
    {

        Debug.Log(vector);
        SpawnNow(vector);

    }

    public void SpawnNow(Vector3 vector)
    {
        randomPowerUp = Random.Range(0, 3);
        Debug.Log(randomPowerUp);
        Debug.Log(randomPowerUp);
        if (randomPowerUp < 2)
        {
            //Debug.Log(powerUps[randomPowerUp]);
            GameObject powerUp = Instantiate(powerUps[randomPowerUp], new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity);
        }
        else
        {
            
        }


    }







}
