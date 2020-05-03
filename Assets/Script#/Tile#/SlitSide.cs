using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlitSide : MonoBehaviour
{
    private CompositeCollider2D CompositeCollider;
    private BoxCollider2D BoxCollider;

    private void Start()
    {
        CompositeCollider = GetComponent<CompositeCollider2D>();
        BoxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }
            if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) && (playerObj.GetComponent<PlayerState>().GetPlayerState() == PlayerState.State.WATER))
            {
                CompositeCollider.isTrigger = true;
            }

            if (playerObj.GetComponent<PlayerState>().GetPlayerState() != PlayerState.State.WATER)
            {
                CompositeCollider.isTrigger = false;
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
            if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) && (playerObj.GetComponent<PlayerState>().GetPlayerState() == PlayerState.State.WATER))
            {
                CompositeCollider.isTrigger = true;
            }

            if(playerObj.GetComponent<PlayerState>().GetPlayerState() != PlayerState.State.WATER)
            {
                CompositeCollider.isTrigger = false;
            }
        }
    }
}
