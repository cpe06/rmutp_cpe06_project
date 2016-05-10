using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_editProfile: MonoBehaviour{
	public gameCon_profile controller;


	void Start () {
		controller.button_editProfile.onClick.AddListener (onClickEditProfile);
	}
	private void onClickEditProfile(){
		SceneManager.LoadScene ("profileEdit");		
	}

}
