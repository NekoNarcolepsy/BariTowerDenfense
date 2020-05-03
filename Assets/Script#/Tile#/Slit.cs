using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slit : MonoBehaviour
{
    private PlatformEffector2D effector;
    private CompositeCollider2D collider;
    private GameObject playerObj;
    private float goingthoughtime;
    private bool b_goingthough;
    public float WaitTime;

    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
        collider = GetComponent<CompositeCollider2D>();
        playerObj = GameObject.Find("Player");
        b_goingthough = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (goingthoughtime > 0)
        {
            goingthoughtime -= Time.deltaTime;
        }

        if(goingthoughtime <= 0 && b_goingthough == true)
        {
            b_goingthough = false;
            collider.isTrigger = false;
            playerObj.GetComponent<CapsuleCollider2D>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Jump") && (playerObj.GetComponent<PlayerState>().GetPlayerState() == PlayerState.State.WATER))
            {
                WaitTime = 0.0f;
                //collider.isTrigger = true;
                playerObj.GetComponent<CapsuleCollider2D>().enabled = false;
                goingthoughtime = 0.3f;
                b_goingthough = true;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }
            if (Input.GetButtonDown("Jump") && (playerObj.GetComponent<PlayerState>().GetPlayerState() == PlayerState.State.WATER))
            {
                WaitTime = 0.0f;
                //collider.isTrigger = true;
                playerObj.GetComponent<CapsuleCollider2D>().enabled = false;
                goingthoughtime = 0.2f;
                b_goingthough = true;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        foreach(ContactPoint2D contact in collision.contacts)
        {
            if (collision.gameObject.tag == "Player")
            {
                GameObject playerObj = null;
                if (playerObj == null)
                {
                    playerObj = GameObject.Find("Player");
                }
                if (Input.GetKeyDown(KeyCode.DownArrow) && (playerObj.GetComponent<PlayerState>().GetPlayerState() == PlayerState.State.WATER))
                {
                    WaitTime = 0.0f;
                    //collider.isTrigger = true;
                    playerObj.GetComponent<CapsuleCollider2D>().enabled = false;
                    goingthoughtime = 0.3f;
                    b_goingthough = true;
                }
            }
        }
    }

}
