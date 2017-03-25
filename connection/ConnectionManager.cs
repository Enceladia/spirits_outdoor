using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionManager : MonoBehaviour {

    private string baseURL = "https://enceladia.herokuapp.com/";
    //private string baseURL = "localhost:3000/";

    string username = "";
    string password = "";
    string email = "";

    public GameObject usernameLoginGo;
    public GameObject passwordLoginGo;

    public GameObject usernameRegistergo;
    public GameObject passwordRegisterGo;
    public GameObject emailRegisterGo;

    public GameObject responseLoginGo;
    public GameObject responseRegisterGo;

    public GameObject LoginTabGo;
    public GameObject RegisterTabGo;

    Text usernameLoginText;
    Text passwordLoginText;

    Text usernameRegisterText;
    Text passwordRegisterText;
    Text emailRegisterText;

    Text responseLoginText;
    Text responseRegisterText;

    Button LoginTabButton;
    Button RegisterTabButton;

    private userdata jsonUser;

    public void loginClick()
    {
        resetInputStrings();

        getLoginFromForm();

        StartCoroutine(Login());
    }

    public void registerClick()
    {
        resetInputStrings();

        getRegisterFromForm();

        StartCoroutine(Register());

        Debug.Log("reg user: " + username);
        Debug.Log("pass user: " + password);
    }

    public void resetInputStrings() {
        username = "";
        password = "";
        email = "";

        responseLoginText = responseLoginGo.GetComponent<Text>();
        responseLoginText.text = "";

    }
    /*
    public void resetAllInputFields() {
        
        usernameLoginText = usernameLoginGo.GetComponent<Text>();
        usernameLoginText.text = "";

        passwordLoginText = passwordLoginGo.GetComponent<Text>();
        passwordLoginText.text = "";

        usernameRegisterText = usernameRegistergo.GetComponent<Text>();
        usernameRegisterText.text = "";

        passwordRegisterText = passwordRegisterGo.GetComponent<Text>();
        passwordRegisterText.text = "";

        emailRegisterText = emailRegisterGo.GetComponent<Text>();
        emailRegisterText.text = "";
    }
    */

    public void setLoginButtonActivity()
    {
        //resetAllInputFields();

        LoginTabButton = LoginTabGo.GetComponent<Button>();
        RegisterTabButton = RegisterTabGo.GetComponent<Button>();


        if (LoginTabButton.interactable)
        {
            LoginTabButton.interactable = false;
        }
        else
        {
            LoginTabButton.interactable = true;
        }

        if (RegisterTabButton.interactable)
        {
            RegisterTabButton.interactable = false;
        }
        else
        {
            RegisterTabButton.interactable = true;
        }
    }

    public void setRegisterButtonActivity()
    {
        //resetAllInputFields();

        RegisterTabButton = RegisterTabGo.GetComponent<Button>();

        if (RegisterTabButton.interactable)
        {
            RegisterTabButton.interactable = false;
        }
        else
        {
            RegisterTabButton.interactable = true;
        }
    }


    private void getLoginFromForm() {
        usernameLoginText = usernameLoginGo.GetComponent<Text>();
        username = usernameLoginText.text;

        passwordLoginText = passwordLoginGo.GetComponent<Text>();
        password = passwordLoginText.text;
    }
    private void getRegisterFromForm()
    {
        usernameRegisterText = usernameRegistergo.GetComponent<Text>();
        username = usernameRegisterText.text;

        passwordRegisterText = passwordRegisterGo.GetComponent<Text>();
        password = passwordRegisterText.text;

        emailRegisterText = emailRegisterGo.GetComponent<Text>();
        email = emailRegisterText.text;
    }



    IEnumerator Login()
    {
        string loginURL = baseURL + "login";

        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);


        WWW request = new WWW(loginURL, form);

        yield return request;
        if (!string.IsNullOrEmpty(request.error))
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log("Server contacted!");
        }

        Debug.Log(request.text);

        if (request.text.Equals("Failure_Password"))
        {

            responseLoginText = responseLoginGo.GetComponent<Text>();
            responseLoginText.text = "Wrong password!";

        } else if (request.text.Equals("Failure_User")) {
            responseLoginText = responseLoginGo.GetComponent<Text>();
            responseLoginText.text = "Wrong Username!";
        }
        else {
            jsonUser = JsonUtility.FromJson<userdata>(request.text);
            responseLoginText.text = "Logged in";
        }


        //Debug.Log(jsonUser.username);
        //Debug.Log(jsonUser.user_email);
        //Debug.Log(jsonUser.user_credit);
        //Debug.Log(jsonUser.user_level);
    }

    IEnumerator Register() {
        string registerURL = baseURL + "register";

        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        form.AddField("email", email);

        WWW request = new WWW(registerURL, form);

        Debug.Log(registerURL);

        yield return request;
        if (!string.IsNullOrEmpty(request.error))
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log("Server contacted!");
        }


        responseRegisterText = responseRegisterGo.GetComponent<Text>();
        responseRegisterText.text = request.text;
    }

}

[Serializable]
public class userdata
{
    public string username = "";
    public string user_email = "";
    public bool user_opt = false;
    public bool user_active = false;
    public int user_level = 0;
    public double user_xp = 0.0f;
    public int user_credit = 0;
    public int user_gold = 0;
    public int[] user_privilege;
    public int[] user_achievement;
    public int[] user_lex;
    public string[] user_spirits;
    public int[] user_items;
}
