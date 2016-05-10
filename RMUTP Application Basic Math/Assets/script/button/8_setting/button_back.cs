using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_back : MonoBehaviour {
    public gameCon_setting controller;
	void Start () {
        controller.button_back.onClick.AddListener(onClickBack);
	}

    private void onClickBack()
    {
        SceneManager.LoadScene("home");
    }

}
