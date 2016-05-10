using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_minus : MonoBehaviour {
    public gameCon_mode controller;
    void Start()
    {
        controller.button_minus.onClick.AddListener(onClickButtonMinus);
    }

    private void onClickButtonMinus()
    {
        SceneManager.LoadScene(4);
        controller.mode = 1;
    }
}
