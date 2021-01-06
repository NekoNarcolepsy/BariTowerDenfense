using System.Collections;
using System.Collections.Generic;
using TowerDefense.Level;
using TowerDefense.Towers;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BuffSelect : MonoBehaviour
{

  
    // Start is called before the first frame update



    public void SaveSelectedBuff(int i)
    {
        PlayerPrefs.SetInt("SelectedBuff", i);
    }

    
}
