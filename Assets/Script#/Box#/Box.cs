using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Box : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.simulated = true;
        rigidbody.freezeRotation = true;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }

            if(playerObj.GetComponent<PlayerState>().GetPlayerState() == PlayerState.State.ICE)
            {
                rigidbody.mass = 3.0f;
            }
            else
            {
                rigidbody.mass = 50.0f;
            }
        }
    }
}
