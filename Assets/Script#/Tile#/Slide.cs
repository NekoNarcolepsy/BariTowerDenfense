using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Slide : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }
            Debug.Log("OnCollisionEnter2D");
            if (playerObj.GetComponent<PlayerController>().GetAcceleration() < 2000)
            {
                playerObj.GetComponent<PlayerController>().AddAcceleration(500.0f);
            }
            playerObj.GetComponent<PlayerState>().Change_State(PlayerState.State.WATER);
        }
    }
}