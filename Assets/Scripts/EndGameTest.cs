using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense.UI;

public class EndGameTest : MonoBehaviour
{
    public GameObject EndGame;
    // Start is called before the first frame update
    void Start()
    {
        EndGame.GetComponent<EndGameScreen>().Victory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
