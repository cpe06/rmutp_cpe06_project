using UnityEngine;
using System.Collections;

public class modeSelect : MonoBehaviour {
    public int currentMode;
    public GameObject plus, minus, multi, div, clone, panel_symbol;
    void Start () {
        PlayerPrefs.GetInt("mode");
        currentMode = GameObject.Find("gameCon_mode").GetComponent<gameCon_mode>().mode;
        switch (currentMode)
        {
            case 0:
                clone = Instantiate(plus);
                clone.transform.parent = panel_symbol.transform;
                break;
            case 1:
                clone = Instantiate(minus);
                clone.transform.parent = panel_symbol.transform;
                break;
            default:
                clone = Instantiate(plus);
                clone.transform.parent = panel_symbol.transform;
                break;
        }
	}
}
