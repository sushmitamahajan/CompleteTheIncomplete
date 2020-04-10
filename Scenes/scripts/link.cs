using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class link : MonoBehaviour
{
   public void Google(){
       Application.OpenURL("https://accounts.google.com/servicelogin/signinchooser?flowName=GlifWebSignIn&flowEntry=ServiceLogin");
   }
   public void Facebook(){
       Application.OpenURL("https://en-gb.facebook.com/login/");
   }
}
