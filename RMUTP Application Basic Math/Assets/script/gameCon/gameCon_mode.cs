using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameCon_mode : MonoBehaviour {
    public Button button_modeBack;
    public Button button_plus;
    public Button button_minus;
    public Button button_multi;
    public Button button_div;
    public int mode;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
