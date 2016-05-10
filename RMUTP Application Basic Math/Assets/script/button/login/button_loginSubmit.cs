using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_loginSubmit : MonoBehaviour {
    public gameCon_login controller;
	void Start () {
        controller.button_loginSubmit.onClick.AddListener(onCliclickLoginSubmit);
	}

    private void onCliclickLoginSubmit()
    {
        SceneManager.LoadScene("home");
    }
}
