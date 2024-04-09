using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{


    [SerializeField] GameObject info_panel;


    int count = 2;

    public void ShowInfo_Game()
    {
        if (count % 2 == 0)
        {
            info_panel.SetActive(true);
            
        }


        else
        {
            info_panel.SetActive(false);
        }

        count++;

    
    }
        
}
