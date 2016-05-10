using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class button_lobbyBack : MonoBehaviour {
    public gameCon_lobby controller;
	void Start () {
        controller.button_lobbyBack.onClick.AddListener(onClickButtonLobbyBack);
	}

    private void onClickButtonLobbyBack()
    {
        SceneManager.LoadScene("multiplayer");
    }
}
