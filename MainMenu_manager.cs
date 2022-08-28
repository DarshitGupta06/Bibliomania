using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class MainMenu_manager : MonoBehaviour
{

  //  public Image img;
    string imageString ="0";

    public GameObject Upload_Form;


    public InputField Form_Title;
    public InputField Form_Discription;


    [HideInInspector]
    public string Form_Title_Index;

    [HideInInspector]
    public string Form_Discription_Index;


    string path;

  //  public RawImage rawimage;

    public TextMeshProUGUI Welcome_message;
    void Start()
    {
        Welcome_message.text = "Welcome " + otp_manager._name;

        Upload_Form.SetActive(false);

    

    }

    private void Update()
    {
        Form_Title_Index = "" + Form_Title.text;

        Form_Discription_Index = "" + Form_Discription.text;
    }

    public void Form_Button()
    {
        Upload_Form.SetActive(true);

    }


    public void Image_from_File()
    {

   //   path = EditorUtility.OpenFilePanel("Show all images (.png)", "","png");

       

    }




    public void Submit_Button()
    {

        StartCoroutine(Upload());

    }



    IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
       form.AddField("image", imageString);

        form.AddField("title", Form_Title_Index);
        form.AddField("discription", Form_Discription_Index);



        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/College%20Project/Image_To_database.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

               
            }
        }



    }






    public void  CSIT()
    {

        SceneManager.LoadScene("CSIT");
    }


    public void EI()
    {
        SceneManager.LoadScene("EI");

    }


    public void EC()
    {
        SceneManager.LoadScene("EC");


    }


    public void Chemical()
    {

        SceneManager.LoadScene("CH");

    }



    public void EE()
    {
        SceneManager.LoadScene("EC");


    }



    public void ME()
    {

        SceneManager.LoadScene("ME");


    }



    public void Form_back_Button()
    {

        Upload_Form.SetActive(false);

    }

}
