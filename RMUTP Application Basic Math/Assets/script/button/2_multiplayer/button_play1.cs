using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class button_play1 : MonoBehaviour {
	public gameCon_multiplayer controller;

	void Start () {
		controller.button_play1.onClick.AddListener (onClickPlay1);
	}
	private void onClickPlay1 ()
	{
		SceneManager.LoadScene(3);
	}
}

