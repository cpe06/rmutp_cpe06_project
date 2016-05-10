using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class button_showProfile : MonoBehaviour {
    public gameCon_home controller;
	void Start () {
        controller.button_showProfile.onClick.AddListener(onClickShowProfile);
	}

    private void onClickShowProfile()
    {
        SceneManager.LoadScene(5);
    }
}
