using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_logout : MonoBehaviour {
    public gameCon_setting controller;
	void Start () {
        controller.button_logout.onClick.AddListener(onClickLogout);
	}

    private void onClickLogout()
    {
        SceneManager.LoadScene("main");
    }
}
