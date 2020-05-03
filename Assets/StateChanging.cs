using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChanging : MonoBehaviour
{
    public PlayerState.State ChangeInState;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }
            playerObj.GetComponent<PlayerState>().Change_State(ChangeInState);
        }
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
            playerObj.GetComponent<PlayerState>().Change_State(ChangeInState);
        }
    }
}
