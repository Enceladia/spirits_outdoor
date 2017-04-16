using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectionManager : MonoBehaviour
{

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

    public GameObject uiBlockGo;

    Text usernameLoginText;
    Text passwordLoginText;

    Text usernameRegisterText;
    Text passwordRegisterText;
    Text emailRegisterText;

    Text responseLoginText;
    Text responseRegisterText;

    Button LoginTabButton;
    Button RegisterTabButton;

    private Userdata jsonUser;

    public void loginClick()
    {
        StartCoroutine(Login());

        resetInputStrings();
    }

    public void registerClick()
    {
        StartCoroutine(Register());

        resetInputStrings();

        Debug.Log("reg user: " + username);
        Debug.Log("pass user: " + password);
    }

    public void resetInputStrings()
    {
        username = "";
        password = "";
        email = "";

        responseLoginText = responseLoginGo.GetComponent<Text>();
        responseLoginText.text = "";

    }

    public void setLoginButtonActivity()
    {

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


    IEnumerator Login()
    {
        string loginURL = baseURL + "login";

        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);


        WWW request = new WWW(loginURL, form);

        uiBlockGo.SetActive(true);

        yield return request;

        uiBlockGo.SetActive(false);

        if (!string.IsNullOrEmpty(request.error))
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log("Server contacted!");
        }

        //Debug.Log(request.text);

        if (request.text.Equals("Failure_Password"))
        {

            responseLoginText = responseLoginGo.GetComponent<Text>();
            responseLoginText.text = "Wrong password!";

        }
        else if (request.text.Equals("Failure_User"))
        {
            responseLoginText = responseLoginGo.GetComponent<Text>();
            responseLoginText.text = "Wrong Username!";
        }
        else
        {
            jsonUser = JsonUtility.FromJson<Userdata>(request.text);
            responseLoginText.text = "Logged in";

            setupPlayerManagement();
            loadMainScene();
        }

        //ToDo: save jsonUser -> PlayerManager Object

        //Debug.Log(jsonUser.username);
        //Debug.Log(jsonUser.user_email);
        //Debug.Log(jsonUser.user_credit);
        //Debug.Log(jsonUser.user_level);
    }

    IEnumerator Register()
    {
        string registerURL = baseURL + "register";

        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        form.AddField("email", email);

        WWW request = new WWW(registerURL, form);

        Debug.Log(registerURL);

        uiBlockGo.SetActive(true);

        yield return request;

        uiBlockGo.SetActive(false);

        if (!string.IsNullOrEmpty(request.error))
        {
            Debug.Log(request.error);
        }
        else
        {
            Debug.Log("Server contacted!");
        }

        //toDo: check response text, if success -> automatic login


        responseRegisterText = responseRegisterGo.GetComponent<Text>();
        responseRegisterText.text = request.text;

        //if (request.text.Equals("Success"))
        //{
        //    setupPlayerManagement();
        //}
    }

    public void inputFormUserName(string usernameI)
    {
        username = usernameI;
    }

    public void inputFormPassWord(string passwordI)
    {
        password = passwordI;
    }

    public void inputFormEmail(string emailI)
    {
        email = emailI;
    }

    private void setupPlayerManagement()
    {
        BasePlayer bp = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>().bp;
        bp.Player_name = jsonUser.username;
        bp.Player_email = jsonUser.user_email;
        bp.Player_opt = jsonUser.user_opt;
        bp.Player_active = jsonUser.user_active;
        bp.Player_level = jsonUser.user_level;
        bp.Player_xp = jsonUser.user_xp;
        bp.Player_wonBattles = jsonUser.user_wonBattles;
        bp.Player_lostBattles = jsonUser.user_lostBattles;
        bp.Player_credit = jsonUser.user_credit;
        bp.Player_gold = jsonUser.user_gold;
        bp.Player_privilege = jsonUser.user_privilege;
        bp.Player_achievement = jsonUser.user_achievement;
        bp.Player_lexSeen = jsonUser.user_lexSeen;
        bp.Player_lexReg = jsonUser.user_lexReg;

        //toDo: konvert spiritString to Spirit List and Item String to Item List

        bp.Player_contacts = jsonUser.user_contacts;
    }

    private void loadMainScene()
    {
        SceneManager.LoadScene("main");
    }

}


//Dummy Class to save Json Data
[Serializable]
public class Userdata
{
    public string username = "";
    public string user_email = "";
    public bool user_opt = false;
    public bool user_active = false;
    public int user_level = 0;
    public double user_xp = 0.0f;
    public int user_wonBattles = 0;
    public int user_lostBattles = 0;
    public int user_credit = 0;
    public int user_gold = 0;
    public int[] user_privilege;
    public int[] user_achievement;
    public int[] user_lexSeen;
    public int[] user_lexReg;
    public string[] user_spirits;
    public int[] user_items;
    public int[] user_contacts;
}
