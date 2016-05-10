using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_No : MonoBehaviour {
	public gameCon_profileEdit controller;

	void Start () {
		controller.button_No.onClick.AddListener (onClickNo);
	}
	private void onClickNo(){
		SceneManager.LoadScene ("profile");
	}

}
