using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }

            Debug.Log("OnCollisionEnter2D");
            playerObj.GetComponent<PlayerController>().ResetAcceleration();
            playerObj.GetComponent<PlayerController>().Landed();
        }
    }
}
