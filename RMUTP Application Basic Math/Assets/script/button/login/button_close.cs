using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_close : MonoBehaviour {
    public gameCon_login controller;
	void Start () {
        controller.button_close.onClick.AddListener(onClickClose);
	}

    private void onClickClose()
    {
        SceneManager.LoadScene("main");
    }
}
