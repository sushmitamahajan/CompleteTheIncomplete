using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class log_sign : MonoBehaviour
{
    
   public void logtosign()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   
   void Update()
   {
       if (Input.GetKeyDown(KeyCode.Escape))
       {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
       }
   }
    
}
