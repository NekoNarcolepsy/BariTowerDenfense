using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class UpAIr : MonoBehaviour
{
    public float UpFloatingForce = 15.0f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }
            
            if(playerObj.GetComponent<PlayerState>().GetPlayerState() == PlayerState.State.AIR)
            {
                playerObj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, UpFloatingForce));
            }
        }
    }
}
