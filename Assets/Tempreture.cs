using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tempreture : MonoBehaviour
{
    public float Temp = 0.0f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject playerObj = null;
            if (playerObj == null)
            {
                playerObj = GameObject.Find("Player");
            }
            playerObj.GetComponent<PlayerMovement>().ChangingTempreture(Temp);
        }
    }
}
