using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class login_Manager : MonoBehaviour
{
    private static login_Manager _instance;


    public static login_Manager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<login_Manager>();

            }
            return _instance;
        }
    }

    [HideInInspector]
    public static bool player_login = false;


    public GameObject Ask_Panel;
    public GameObject Login_Panel;
    public GameObject Sign_UP_Panel;



    public GameObject College_Year_Panel;
    public GameObject College_Branch_Panel;





    [HideInInspector]
    public int User_Year;
    [HideInInspector]
    public string User_Branch_Name;
    void Awake()
    {

        College_Year_Panel.SetActive(false);
        College_Branch_Panel.SetActive(false);


        Ask_Panel.SetActive(false);
        Login_Panel.SetActive(false);
        Sign_UP_Panel.SetActive(false);

        if(player_login == true)
        {
            SceneManager.LoadScene("Dashboard");

        }
        else
        {
            Ask_Panel.SetActive(true);

        }
    }

    
    // for ask panel

    public void Sign_Up_Button()
    {

        Sign_UP_Panel.SetActive(true);

    }


    public void Login_Button()
    {

        Login_Panel.SetActive(true);
    }




    // for sign up panel


    
    public void College_Year_Button()
    {

        College_Year_Panel.SetActive(true);

    }


    public void Year_1()
    {
        User_Year = 1;


    }


    public void Year_2()
    {

        User_Year = 2;

    }

    public void Year_3()
    {

        User_Year = 3;

    }


    public void Year_4()
    {

        User_Year = 4;

    }

    //

    public void College_Branch_year()
    {

        College_Branch_Panel.SetActive(true);

    }



    public void Branch_CSIT()
    {
        User_Branch_Name = "Computer Science & Information Technology";
    }

    public void Branch_EC()
    {
        User_Branch_Name = "Electronics & Communication Engineering";
    }


    public void Branch_EE()
    {
        User_Branch_Name = "Electrical Engineering";
    }


    public void Branch_EI()
    {
        User_Branch_Name = "Electronics & Instrumentation Engineering";
    }


    public void Branch_CH()
    {
        User_Branch_Name = "Chemical Engineering";
    }


    public void Branch_ME()
    {
        User_Branch_Name = "Mechanical Engineering";
    }



    public void SIgnUP_Submit_Button()
    {



    }

}
