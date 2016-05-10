using UnityEngine;
using System.Collections;
using System;

public class text_time_countdown : MonoBehaviour {
    public gameCon_gameplay game_controller;

    public float count = 60;
    public int count_int;


	void Start () {
        count_int = Convert.ToInt32(count);
        game_controller.text_time_countdown.GetComponent<TextMesh>().text = count_int.ToString();
	}
	
	void Update () {
        if(count > 0)
        {
            count -= Time.deltaTime;
        }
        else
        {
            count = 0;
        }
        count_int = Convert.ToInt32(count);
        game_controller.text_time_countdown.GetComponent<TextMesh>().text = count_int.ToString();
    }
}
