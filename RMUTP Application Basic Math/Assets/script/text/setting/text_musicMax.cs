using UnityEngine;
using System.Collections;
using System;

public class text_musicMax : MonoBehaviour {
    public gameCon_setting controller;
	void Start () {
        controller.slider_music.onValueChanged.AddListener(onValueChangedMusic);
	}

    private void onValueChangedMusic(float arg0)
    {
        float val = controller.slider_music.value;
        int ans = Convert.ToInt32(val*100);
        controller.text_musicMax.text = ans.ToString() + "%" ;
    }

}
