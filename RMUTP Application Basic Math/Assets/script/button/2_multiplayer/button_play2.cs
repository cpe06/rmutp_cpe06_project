using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_play2 : MonoBehaviour {
	public gameCon_multiplayer controller;

	void Start () {
		controller.button_play2.onClick.AddListener (onClickPlay2);
	}
	private void onClickPlay2 ()
	{
		SceneManager.LoadScene(1);
	}

}
