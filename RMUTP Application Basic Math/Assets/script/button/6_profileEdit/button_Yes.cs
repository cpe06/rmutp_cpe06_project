using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_Yes : MonoBehaviour {
	public gameCon_profileEdit Controller;

	void Start () {
		Controller.button_Yes.onClick.AddListener(onClickYes);

	}
	private void onClickYes(){
		SceneManager.LoadScene ("Profile");
	}

}
