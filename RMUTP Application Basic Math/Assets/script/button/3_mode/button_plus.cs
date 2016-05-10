using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class button_plus : MonoBehaviour
{
    public gameCon_mode controller;
    void Start()
    {
        controller.button_plus.onClick.AddListener(onClickButtonPlus);
    }

    private void onClickButtonPlus()
    {
        SceneManager.LoadScene(4);
        controller.mode = 0;
    }
}
