using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class button_closeMulti : MonoBehaviour {
	public gameCon_multiplayer controller;

	void Start () {
		controller.button_closeMulti.onClick.AddListener (onClickCloseMulti);
	}
	private void onClickCloseMulti()
	{
		SceneManager.LoadScene (1);
	}

}

