using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Got_Money : MonoBehaviour
{
    int money;

    int money_score = 10;

    int time = 10;

    [SerializeField] Test_Script script;

    [SerializeField] AudioSource sound_got_money;

    [SerializeField] Animator anim;

    [SerializeField] GameObject money_spin;

    [SerializeField] TextMeshProUGUI money_spin_text;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
        }

        else
        {
            money = script.money;
        }
    
    }

    private void Start()
    {
        Invoke("GotMoney", time);

    }



    private void GotMoney()
    {
       

        time = Random.Range(10, 35);

        money_score = Random.Range(5, 50);

        money = money_score + money;

        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();


        sound_got_money.Play();


        //money_spin.SetActive(true);

        //money_spin_text.text ="+ "+ money_score.ToString();

        //anim.enabled = true;

        Invoke("GotMoney", time);



        //money_spin.SetActive(false);
        //anim.enabled = false;
    }



   



}
