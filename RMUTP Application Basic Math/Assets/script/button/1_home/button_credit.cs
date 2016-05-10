using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_credit : MonoBehaviour {
    public gameCon_home controller;
	void Start () {
        controller.button_credit.onClick.AddListener(onClickCredit);
	}

    private void onClickCredit()
    {
        SceneManager.LoadScene(7);
    }
}
