using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level_Manager : MonoBehaviour
{
    [SerializeField] Test_Script script;
    [SerializeField] GameObject list_levels;

    int count = 2;

    public void Home()
    {

        SceneManager.LoadScene("Home");
        
    }
    public void Walk()
    {


        if (PlayerPrefs.HasKey("Level")) {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));

        }

        else
        {
            SceneManager.LoadScene(1);
        }
        
            
        

        
    }

    public void Shop()
    {

        SceneManager.LoadScene("Shop");
    }


    public void Show_Levels()
    {


        if (count % 2 == 0)
        {
            list_levels.SetActive(true);
        }

        else
        {
            list_levels.SetActive(false);
        }

        count++;


    }

}
