using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class log_dash : MonoBehaviour
{
   
    
    public void logtodash()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }
   
   void Update()
   {
       if (Input.GetKeyDown(KeyCode.Escape))
       {    if (SceneManager.GetActiveScene().buildIndex==0)
                Application.Quit();
            else    
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
       }
   }
   
}
