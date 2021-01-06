using System.Collections;
using System.Collections.Generic;
using TowerDefense.Level;
using TowerDefense.Towers;
using UnityEngine;

public class ResetLibrary : MonoBehaviour
{
    public GameObject Level1WaveManager;
    public Tower Mage1;
    public Tower Mage2;
    // Start is called before the first frame update
    void Awake()
    {
        Level1WaveManager.GetComponent<LevelManager>().towerLibrary.configurations[3] = Mage1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTower()
    {
        if (PlayerPrefs.GetInt("SelectedBuff") == 3)
        {
            Level1WaveManager.GetComponent<LevelManager>().towerLibrary.configurations[3] = Mage2;
        }

    }
}
