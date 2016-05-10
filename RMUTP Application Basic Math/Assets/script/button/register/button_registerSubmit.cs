using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_registerSubmit : MonoBehaviour {
    public gameCon_register Controller;
	void Start () {
        Controller.button_registerSubmit.onClick.AddListener(onClickRegisterSubmit);
	}

    private void onClickRegisterSubmit()
    {
        SceneManager.LoadScene("login");
    }
}
