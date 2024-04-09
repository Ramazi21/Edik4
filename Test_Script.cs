using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Test_Script : MonoBehaviour
{

     public int score = 0;
     public int  score_level = 10;
     public int  level = 1;
     public int  money = 0;

     public int score_x = 1;

    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI level_now_text;
    [SerializeField] TextMeshProUGUI level_next_text;
    [SerializeField] TextMeshProUGUI score_money_text;
    [SerializeField] AudioSource sound_money;
    [SerializeField] AudioSource sound_levelUp;




    private void Awake()
    {



        if (PlayerPrefs.HasKey("Score"))
        {
            score = PlayerPrefs.GetInt("Score", score);
        }

        if(PlayerPrefs.HasKey("Score_Level")){

            score_level = PlayerPrefs.GetInt("Score_Level");

        }

        if (PlayerPrefs.HasKey("Level"))
        {
            level = PlayerPrefs.GetInt("Level");

            level_now_text.text = PlayerPrefs.GetInt("Level").ToString();

            level_next_text.text = PlayerPrefs.GetInt(("Level")+1).ToString();

        }

        if (PlayerPrefs.HasKey("level_now_text"))
        {
            level_now_text.text = PlayerPrefs.GetString("level_now_text");
        }

        if (PlayerPrefs.HasKey("level_next_text"))
        {
            level_next_text.text = PlayerPrefs.GetString("level_next_text");
        }


        if (PlayerPrefs.HasKey("Score_x"))
        {
            score_x = PlayerPrefs.GetInt("Score_x");
        }

       if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money", money);

            score_money_text.text = PlayerPrefs.GetInt("Money").ToString();

        }

       
    }

    void Update()
    {

        if (PlayerPrefs.HasKey("Score") && PlayerPrefs.HasKey("Score_Level"))
        {

            slider.maxValue = PlayerPrefs.GetInt("Score_Level", score_level);
            slider.value = PlayerPrefs.GetInt("Score", score);

        }

        else
        {
            slider.maxValue = score_level;
            slider.value = score;
        }

       

    }



    public void eat()
    {

        score=score+score_x;



        PlayerPrefs.SetInt("Score", score);



        if (score >= score_level)
        {

            levelUp();
        }

}


    private void levelUp()
    {




        sound_levelUp.Play();


        level++;

      





        score_level = score_level + score_level;

        PlayerPrefs.SetInt("Score_Level", score_level);


     

        
      


        score = 0;

        
        money = money + 100;


        PlayerPrefs.SetInt("Money", money);

        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.Save();


        if (PlayerPrefs.HasKey("Level"))
        {
            level_now_text.text = PlayerPrefs.GetInt("Level").ToString();

            
            level_next_text.text = PlayerPrefs.GetInt(("Level") + 1).ToString();
        }




        if (PlayerPrefs.HasKey("Money"))
        {

            score_money_text.text = PlayerPrefs.GetInt("Money").ToString();

        }

        if (!PlayerPrefs.HasKey("Money"))
        {
            score_money_text.text = money.ToString();

        }



      



       

    }


    public void Reset()
    {

        PlayerPrefs.DeleteAll();

        score = 0;
        money = 0;
        level = 1;
        score_level = 10;
        score_x = 1;


        level_now_text.text = level.ToString();

        score_money_text.text = money.ToString();



    }

}
