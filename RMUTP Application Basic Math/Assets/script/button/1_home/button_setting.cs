using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_setting : MonoBehaviour {
    public gameCon_home controller;
	void Start () {
        controller.button_setting.onClick.AddListener(onClickSetting);
	}

    private void onClickSetting()
    {
        SceneManager.LoadScene(8);
    }
}
