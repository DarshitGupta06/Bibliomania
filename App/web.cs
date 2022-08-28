using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class web : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Gettext());
      
    }

    private void Update()
    {
        StartCoroutine(Gettext());
    }

    [System.Obsolete]
    IEnumerator Gettext()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/College%20Project/GetData.php"))
        {
            yield return www.Send();



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
