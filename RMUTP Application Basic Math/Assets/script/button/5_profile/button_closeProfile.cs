using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_closeProfile : MonoBehaviour {
	public gameCon_profile controller;


	void Start () {
		controller.button_closeProfile.onClick.AddListener (onClickCloseProfile);
	}
	private void onClickCloseProfile(){
		SceneManager.LoadScene ("home");
	}


}
