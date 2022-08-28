using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
public class User_Information_Manager : MonoBehaviour
{

    private static User_Information_Manager _instance;


    public static User_Information_Manager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<User_Information_Manager>();

            }
            return _instance;
        }
    }



    public Text _introText;

    [HideInInspector]
    public static bool user_Entry = false;



    public GameObject Branch_Panel;
    public GameObject Year_Panel;



    [HideInInspector]
    public string User_Year_index;
    [HideInInspector]
    public string User_Branch_index;
    [HideInInspector]
    public string User_Name_index;
    [HideInInspector]
    public string User_PhoneNo_index;
    private void Awake()
    {
        

        User_Name_index = "" + otp_manager._name;
        User_PhoneNo_index = "" + otp_manager._Mobile_No;

        _introText.text = "Hi " + User_Name_index;
        if (user_Entry == true)
        {

            SceneManager.LoadScene(2);
        }


    }




    void Start()
    {
        Branch_Panel.SetActive(false);
        Year_Panel.SetActive(false);
    }



    public void User_Branch()
    {
        Branch_Panel.SetActive(true);

    }


    public void User_year()
    {


        Year_Panel.SetActive(true);

    }




    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///



    public void Branch_CSIT()
    {
        User_Branch_index = "Computer Science & Information Technology";

        Branch_Panel.SetActive(false);
    }

    public void Branch_EE()
    {
        User_Branch_index = "Electrical Engineering";

        Branch_Panel.SetActive(false);
    }



    public void Branch_EC()
    {
        User_Branch_index = "Electronics & Communication Engineering";


        Branch_Panel.SetActive(false);
    }


    public void Branch_EI()
    {
        User_Branch_index = "Electronics & Instrumentation Engineering";

        Branch_Panel.SetActive(false);
    }


    public void Branch_CH()
    {
        User_Branch_index = "Chemical Engineering";

        Branch_Panel.SetActive(false);
    }



    public void Branch_ME()
    {
        User_Branch_index = "Mechanical Engineering";


        Branch_Panel.SetActive(false);
    }






    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///


    public void Year_1()
    {
        User_Year_index = "1";

        Year_Panel.SetActive(false);
    }





    public void Year_2()
    {
        User_Year_index = "2";

        Year_Panel.SetActive(false);
    }





    public void Year_3()
    {
        User_Year_index = "3";

        Year_Panel.SetActive(false);
    }





    public void Year_4()
    {
        User_Year_index = "4";

        Year_Panel.SetActive(false);
    }











    ///////////////////////////////////////////////////////////////
    ///




    public void Submit_Button()
    {
        Debug.Log(User_Name_index);
        Debug.Log(User_PhoneNo_index);
        Debug.Log(User_Branch_index);
        Debug.Log(User_Year_index);

        
        StartCoroutine(Upload());

       SceneManager.LoadScene(2);
        user_Entry = true;
    }



    IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUserName",User_Name_index );
        form.AddField("loginUserMobileNo",User_PhoneNo_index);
        form.AddField("loginUserBranch",User_Branch_index);
        form.AddField("loginUserYear",User_Year_index);

        

        form.AddField("title", "abc");
        form.AddField("discription", "123");

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/College%20Project/GetData.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                _introText.text = "" + www.downloadHandler.text;
            }
        }


        
    }



}
