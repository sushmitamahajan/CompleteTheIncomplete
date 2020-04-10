using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class login_cred : MonoBehaviour
{
    public InputField username; 
    public InputField l_password; 
    public Text error;
    public Text s_error;

 public void clickedLogin()
    {   Debug.Log("Hii");
        //validate everything
        if(username.text == "" || l_password.text == "")
        {
            error.text = "Please Enter The Credentials";
        }
        else
        {
            if(Regex.IsMatch(username.text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                if(username.text == "a@b.co" && l_password.text == "1234")
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                }
                else
                {
                    error.text = "Invalids Details.";
                }
            }
            else
            {
                error.text = "Please Enter Valid Email Address.";
            }
        }
    }

    public void clickedSignUp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   
}
