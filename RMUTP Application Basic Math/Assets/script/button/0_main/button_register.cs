using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_register : MonoBehaviour {
    public gameCon_main controller;
	void Start () {
        controller.button_register.onClick.AddListener(onClickRegister);
	}

    private void onClickRegister()
    {
        SceneManager.LoadScene("register");
    }
}
