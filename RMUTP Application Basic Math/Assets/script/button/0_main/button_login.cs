using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_login : MonoBehaviour {
    public gameCon_main controller;
	void Start () {
        controller.button_login.onClick.AddListener(onClickLogin);
	}

    private void onClickLogin()
    {
        SceneManager.LoadScene("login");
    }
}
