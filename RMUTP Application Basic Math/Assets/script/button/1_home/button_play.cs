using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class button_play : MonoBehaviour {
    public gameCon_home controller; 
	void Start () {
        controller.button_play.onClick.AddListener(onClickButtonPlay);
	}

    private void onClickButtonPlay()
    {
        SceneManager.LoadScene(2);
    }
}
