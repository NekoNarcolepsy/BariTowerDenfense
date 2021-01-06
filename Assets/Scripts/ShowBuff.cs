using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense.Level;
using TowerDefense.Towers;

public class ShowBuff : MonoBehaviour
{
    int SelectedBuff;
    public GameObject BackImage;
    public GameObject buffImage1;
    public GameObject buffImage2;

   
    // Start is called before the first frame update
    void Start()
    {
        SelectedBuff = PlayerPrefs.GetInt("SelectedBuff");
        switch(SelectedBuff)
        {
            case 1:
                BackImage.SetActive(true);
                buffImage1.SetActive(true);
                break;
            case 2:
                BackImage.SetActive(true);
                buffImage2.SetActive(true);
                break;
            case 3:
                
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
