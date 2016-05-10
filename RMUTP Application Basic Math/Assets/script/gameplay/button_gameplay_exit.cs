using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_gameplay_exit : MonoBehaviour {
    public gameCon_gameplay controller;

	// Use this for initialization
	void Start () {
        controller.button_gameplay_exit.onClick.AddListener(onClickGameplayExit);
	}

    private void onClickGameplayExit()
    {
        SceneManager.LoadScene("main");
    }
}
