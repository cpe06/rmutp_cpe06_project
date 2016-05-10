using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class button_modeBack : MonoBehaviour {
    public gameCon_mode controller;
	void Start () {
        controller.button_modeBack.onClick.AddListener(onClickButtonBack);
	}

    private void onClickButtonBack()
    {
        SceneManager.LoadScene("multiplayer");
    }
}
