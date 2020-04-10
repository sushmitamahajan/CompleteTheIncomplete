﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class sign_cred : MonoBehaviour
{
    public InputField email; 
    public InputField s_password; 
    public InputField re_password;
    public Text error;
    public Text s_error;

     public void clickedCancel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void clickedContinue()
    {
        //validate everything
        if (email.text == "" || s_password.text == "" || re_password.text == "")
        {
            s_error.text = "Please Enter The Credentials";
        }
        else
        {
            if (Regex.IsMatch(email.text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
            {
                if (s_password.text ==  re_password.text)
                {
                    if (email.text == "a@b.co" && s_password.text == "1234" && re_password.text == "1234")
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                    }
                    else
                    {
                        s_error.text = "Email Address Already Exists.";
                    }
                }
                else
                {
                    s_error.text = "Password Does Not Match.";
                }
            }
            else
            {
                s_error.text = "Please Enter Valid Email Address.";
            }
        }
    }
}
