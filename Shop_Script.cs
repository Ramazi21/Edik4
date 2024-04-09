using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Script : MonoBehaviour
{

    [SerializeField] Test_Script script;

    [SerializeField] GameObject select;

    [SerializeField] GameObject select_button_corn;
    [SerializeField] GameObject select_button_pcheno;
    [SerializeField] GameObject select_button_apple;


    [SerializeField] GameObject corn_button;
    [SerializeField] GameObject pcheno_button;
    [SerializeField] GameObject apple_button;



    int price_corn = 5;

    int price_pcheno = 6;

    int price_apple = 7;

    int money = -1;

    int score_x = -1;



    bool corn = false;
    bool pcheno = false;
    bool apple = false;

    int select_button_corn_bool = 0;

    int select_button_pcheno_bool = 0;

    int select_button_apple_bool = 0;

    private void Awake()
    {

      


        if (PlayerPrefs.HasKey("Select_Position_X") && PlayerPrefs.HasKey("Select_Position_Y"))
        {
            select.transform.position = new Vector2(PlayerPrefs.GetFloat("Select_Position_X"), PlayerPrefs.GetFloat("Select_Position_Y"));

        }

        //else if (PlayerPrefs.HasKey("Select_Button_X") && PlayerPrefs.HasKey("Select_Button_Y"))
        //{

        //    select_button.transform.position = new Vector2(PlayerPrefs.GetFloat("Select_Button_X"), PlayerPrefs.GetFloat("Select_Button_Y"));


        //    Debug.Log("Select_Button_Ext");
        //}


        if (PlayerPrefs.HasKey("Money"))
        {


            money = PlayerPrefs.GetInt("Money");
        }


    else if (PlayerPrefs.HasKey("Score_x"))
        {

            score_x = PlayerPrefs.GetInt("Score_x");
        }

        else if (PlayerPrefs.HasKey("Pcheno"))
        {
            if (PlayerPrefs.GetInt("Pcheno") == 1)
            {
                pcheno = true;

            }
            else
            {
                pcheno = false;

            }
        }

        else if (PlayerPrefs.HasKey("Apple"))
        {
            if (PlayerPrefs.GetInt("Apple") == 1)
            {
                apple = true;

            }
            else
            {
                apple = false;

            }
        }
        else if (PlayerPrefs.HasKey("Corn"))
        {
            if (PlayerPrefs.GetInt("Corn") == 1)
            {
                corn = true;

            }
            else
            {
                corn = false;

            }
        }


        else if (PlayerPrefs.HasKey("select_button_corn_bool"))
        {
            if (PlayerPrefs.GetInt("select_button_corn_bool")==1)
            {
                select_button_corn_bool = 1;
            }

            else
            {
                select_button_corn_bool = 0;

            }

        }

        else if (PlayerPrefs.HasKey("select_button_pcheno_bool"))
        {
            if (PlayerPrefs.GetInt("select_button_pcheno_bool") == 1)
            {
                select_button_pcheno_bool = 1;

            }
            else
            {
                select_button_pcheno_bool = 0;
            }
        }

        else if (PlayerPrefs.HasKey("select_button_apple_bool"))
        {
            if (PlayerPrefs.GetInt("select_button_apple_bool") == 1)
            {
                select_button_apple_bool = 1;

            }

            else
            {
                select_button_apple_bool = 0;
            }
        }





        else
        {
            money = 1;

            score_x = 1;





        }
    
    }




    public void buy_Corn()
    {



        if (corn)
        {
            Select(corn_button);

            score_x = 10;


            PlayerPrefs.SetInt("Score_x", score_x);


        }


        if (!corn) 

        if (money >= price_corn)
        {


            money = money - price_corn;


         if (money < 0)
            {
                money = money * -1;

            }

                PlayerPrefs.SetInt("Money", money);

                select_button_corn.transform.position = corn_button.transform.position;

                select_button_corn.SetActive(true);

                select_button_corn_bool = 1;

                PlayerPrefs.SetFloat("Select_Button_X", select_button_corn.transform.position.x);
                PlayerPrefs.SetFloat("Select_Button_Y", select_button_corn.transform.position.y);
                PlayerPrefs.SetInt("select_button_corn", select_button_apple_bool);
                PlayerPrefs.Save();



                corn = true;

                PlayerPrefs.SetInt("Corn", 1);


        }
    }

    public void buy_Pcheno()
    {

        if (pcheno)
        {
            Select(pcheno_button);


            score_x = 25;


            PlayerPrefs.SetInt("Score_x", score_x);



        }

        if (!pcheno)
        {


            if (money >= price_pcheno)
            {
                money = money - price_pcheno;


                if (money < 0)
                {
                    money = money * -1;
                }



                PlayerPrefs.SetInt("Money", money);



                select_button_pcheno.transform.position = pcheno_button.transform.position;


                select_button_pcheno.SetActive(true);

                select_button_pcheno_bool = 1;

                PlayerPrefs.SetFloat("Select_Button_X", select_button_pcheno.transform.position.x);
                PlayerPrefs.SetFloat("Select_Button_Y", select_button_pcheno.transform.position.y);
                PlayerPrefs.SetInt("select_button_pcheno", select_button_pcheno_bool);
                PlayerPrefs.Save();

                


                pcheno = true;

                PlayerPrefs.SetInt("Pcheno", 1);


            }
        }


    }


    public void buy_Apple()
    {
        if (apple)
        {
            Select(apple_button);



            score_x = 50;



            PlayerPrefs.SetInt("Score_x", score_x);


            



           


        }

        if (!apple)
        {


            if (money >= price_apple)
            {
                money = money - price_apple;



                if (money < 0)
                {
                    money = money * -1;

                }



                PlayerPrefs.SetInt("Money", money);


                select_button_apple.transform.position = apple_button.transform.position;

                select_button_apple.SetActive(true);

                select_button_apple_bool = 1;

                PlayerPrefs.SetFloat("Select_Button_X", select_button_apple.transform.position.x);
                PlayerPrefs.SetFloat("Select_Button_Y", select_button_apple.transform.position.y);
                PlayerPrefs.SetInt("select_button_apple_bool", select_button_apple_bool);
                PlayerPrefs.Save();



                apple = true;

                PlayerPrefs.SetInt("Apple", 1);


            }
        }
    }

    private void Select(GameObject value)
    {
        select.transform.position = value.transform.position;

        PlayerPrefs.SetFloat("Select_Position_X", select.transform.position.x);


        PlayerPrefs.SetFloat("Select_Position_Y", select.transform.position.y);


        select.SetActive(true);


    }


}
