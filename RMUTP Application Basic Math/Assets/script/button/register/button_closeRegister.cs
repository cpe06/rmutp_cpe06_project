using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_closeRegister : MonoBehaviour {
    public gameCon_register controller;
	void Start () {
        controller.button_closeRegister.onClick.AddListener(onClickCloseRegister);
	}

    private void onClickCloseRegister()
    {
        SceneManager.LoadScene("main");
    }
}
