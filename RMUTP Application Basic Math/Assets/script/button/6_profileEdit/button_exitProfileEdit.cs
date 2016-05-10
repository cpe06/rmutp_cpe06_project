using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_exitProfileEdit : MonoBehaviour {
	public gameCon_profileEdit controller;


	void Start () {
		controller.button_exitProfileEdit.onClick.AddListener (onClickexitProfileEdit);
	}
	private void onClickexitProfileEdit(){
		SceneManager.LoadScene ("home");
	}

}
