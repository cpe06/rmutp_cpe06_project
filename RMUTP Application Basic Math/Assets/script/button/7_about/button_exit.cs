using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_exit : MonoBehaviour {
    public gameCon_about controller;
	void Start () {
        controller.button_exit.onClick.AddListener(onClickAbout);
	}

    private void onClickAbout()
    {
        SceneManager.LoadScene("home");
    }
}
