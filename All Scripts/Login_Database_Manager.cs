using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Login_Database_Manager : MonoBehaviour
{
    public InputField User_Name;




    private void Start()
    {
        StartCoroutine(Login("9140773784", "123abc"));
    }


    IEnumerator Login(string user_phone_no,string user_passward)
    {

        WWWForm form = new WWWForm();
        form.AddField("loginUser",user_phone_no);
        form.AddField("loginPass", user_passward);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/College%20Project/GetData.php", form) )
        {
            yield return www.SendWebRequest();
            if(www.isNetworkError || www.isHttpError)
            {

                Debug.Log(www.error);
            }
            else
            {

                Debug.Log(www.downloadHandler.text);
            }






        }


    }
}
