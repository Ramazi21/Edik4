using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edik_Sound : MonoBehaviour
{

    [SerializeField] AudioSource Edik_Vlad;
    [SerializeField] AudioSource Edik_Ramazi;
    [SerializeField] AudioSource Edik_Sanya;
    


    public void Edik_Sound_Play() 
    {

        int value = Random.Range(0, 3);


        switch (value)
        {
            case 0:
                Edik_Vlad.Play();

                break;

            case 1:
                Edik_Ramazi.Play();
                break;

            case 2:
                Edik_Sanya.Play();
                break;
        
        }


        value = -1;

    
    
    }

}
