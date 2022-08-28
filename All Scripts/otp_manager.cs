using System.Collections;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic; 
using System.Net; 
using System.Collections.Specialized; 
using System.Threading.Tasks; 
using System.Linq;
using Random = System.Random; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class otp_manager : MonoBehaviour
{
    private static otp_manager _instance;

    private int z_world;

    public static otp_manager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<otp_manager>();

            }
            return _instance;
        }
    }











    public InputField User_Mobile_No;
    public InputField User_name;

    public InputField User_OTP;


    public GameObject OTP_Panel;

    string randomNumber;

     [HideInInspector]
    public static string _Mobile_No;
    [HideInInspector]
    public string OTP;
    [HideInInspector]
    public static string _name;





    private void Awake()
    {
        PlayerPrefs.SetInt("zworld", PlayerPrefs.GetInt("zworld") + 1);


   
        if(PlayerPrefs.GetInt("zworld") == 10)
        {


         ///   SceneManager.LoadScene("z");
        }

        Debug.Log(PlayerPrefs.GetInt("zworld"));

        PlayerPrefs.SetInt("Varification", 0);

      

        if (PlayerPrefs.GetInt("Varification") == 1)
        {

            SceneManager.LoadScene(1);

        }
    }

    void Start()
    {
        

        OTP_Panel.SetActive(false);

        

    }

    private void Update()
    {
        _Mobile_No = User_Mobile_No.text;
        _name = User_name.text;
        OTP = User_OTP.text;

    }

  //public void Mobile_No_Enter_Button()
  //  {
   //     SceneManager.LoadScene(2);
   //     String result;
   ///     string apiKey = "Mzk2ODYzN2E2YjQ3NzU0ZTczMzU0YjRhNmU2OTYyNDg="; //the one which you will register on textlocal
   //     string numbers = User_Mobile_No.text; // in a comma seperated list

   //     string sender = "TXTLCL";
   //     string name = User_name.text;
   //     var rnd = new Random();
   //     randomNumber = (rnd.Next(100000, 999999)).ToString();

  //      Debug.Log(randomNumber);

   //     string message = "Hey " + name + " Your OTP is " + randomNumber;
   //     String url = "https://api.textlocal.in/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
    //    Debug.Log(url);
   //  //refer to parameters to complete correct url string
     //   StreamWriter myWriter = null;
   //     HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
    //    objRequest.Method = "POST";
     //   objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
     //   objRequest.ContentType = "application/x-www-form-urlencoded";
     //   try
    //    {
   //         myWriter = new StreamWriter(objRequest.GetRequestStream());
   //         myWriter.Write(url);
    //    }
   //     catch (Exception e)
    //    {
    //        OTP_Panel.SetActive(true);
    //    }
    //    finally
     //   {
     //       myWriter.Close();
      //  }
      //  HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
      //  using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
      //  {
     //       result = sr.ReadToEnd();
     //       // Close and clean up the StreamReader
    //        sr.Close();
   //     }

  //      OTP_Panel.SetActive(true);

 //   }

   
    
    
    public void OTP_Enter_Button()
    {
        if (User_OTP.text == randomNumber)
        {
            SceneManager.LoadScene(2);


            PlayerPrefs.SetInt("Varification", 1);
        }
        else
        {
            OTP_Panel.SetActive(false);
        }
    }



    public void Back_Button()
    {

        OTP_Panel.SetActive(false);

    }




    public void Enter_Button()
    {
        SceneManager.LoadScene(1);

        PlayerPrefs.SetInt("Varification", 1);

        _Mobile_No = User_Mobile_No.text;
        _name = User_name.text;
    }


}
