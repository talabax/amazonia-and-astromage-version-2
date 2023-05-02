using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    GameObject player;
    Transform playerTransform;
    float distance;
    [SerializeField] GameObject attackBox;

    // Start is called before the first frame update

    Animator animator;

    const string idleZombie = "_idleZombie";

    const string moveLeft = "zombieWalkLeft";

    const string zombieAttack = "zombieAttack";


    private void Awake()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }


    void MoveToPlayer()
    {

        // transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, 2 * Time.deltaTime);
        if (player != null)
        {
            distance = gameObject.transform.position.x - playerTransform.position.x;
            //Debug.Log(distance);
            Debug.Log(playerTransform.position.x);


            if (playerTransform.position.x - transform.position.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
                Debug.Log("facing right");
            }
            else if (playerTransform.position.x - transform.position.x > 0)
            {
                Debug.Log("facing Left");
                transform.localScale = new Vector3(-1, 1, 1);
            }


            if (Mathf.Abs(distance) <= 10 && Mathf.Abs(distance) >= 1.2)
            {
                //Debug.Log("in range");
                transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, 2 * Time.deltaTime);
                animator.Play(moveLeft);
            }


            else if (Mathf.Abs(distance) > 10 )
            {
                animator.Play(idleZombie);

            }
            else if (Mathf.Abs(distance) < 1.2)
            {
                animator.Play(zombieAttack);

            }
            //Debug.Log(Mathf.Abs(distance));


            //

        }

       



    }


    public void AttackBox()
    {
        attackBox.SetActive(true);


    }





}
