using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class App_Manager : MonoBehaviour
{
    public GameObject Panel_1;
    public GameObject Panel_2;
    public GameObject Panel_3;
    public GameObject Panel_4;




    public Text Get_Title;
    public Text Get_Discription;
    public Text Get_phone_No;

    void Start()
    {
        //     Panel_1.SetActive(false);
        Panel_2.SetActive(false);
        Panel_3.SetActive(false);
        Panel_4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Panel_Button_1()
    {
        Panel_1.SetActive(true);

    }


    public void Panel_Button_2()
    {

        Panel_2.SetActive(true);
    }


    public void Panel_Button_3()
    {

        Panel_3.SetActive(true);
    }


    public void Panel_Button_4()
    {
        Panel_4.SetActive(true);

    }


    public void Back_Button()
    {
        Panel_1.SetActive(false);
        Panel_2.SetActive(false);
        Panel_3.SetActive(false);
        Panel_4.SetActive(false);


    }

    public void back_buton_for_panel()
    {


        SceneManager.LoadScene(2);

    }
}
