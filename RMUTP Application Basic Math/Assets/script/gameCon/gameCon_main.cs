using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameCon_main : MonoBehaviour{
    public Button button_login;
    public Button button_register;
    public GameObject game_updown;
    public GameObject Clone;
    public int count;

    void Start (){
        Clone = Instantiate(game_updown, new Vector2(26, 365), Quaternion.identity) as GameObject;
    }

    void Update () {
        count++;
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
        count = count % 100;
        if(count == 0){
            Clone = Instantiate(game_updown, new Vector2(26,365), Quaternion.identity) as GameObject;
        }
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene(1);
		}
    }
}