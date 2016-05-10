using UnityEngine;
using System.Collections;

public class GenerateQuestion_B : MonoBehaviour {
    public GameObject panel_Item_B;
    public GameObject quest_Item_B;
    public GameObject clone_Item_B;
    public int randomGenerator;
    public int quest_Number_B;
    public bool done;
    public int currentMode;

    void Start () {
        PlayerPrefs.GetInt("mode");
        currentMode = GameObject.Find("gameCon_mode").GetComponent<gameCon_mode>().mode;
        if (currentMode == 1)
        {
            randomGenerator = Random.Range(1, 5);
        }
        else
        {
            randomGenerator = Random.Range(1, 10);
        }
        
        done = false;
        while (randomGenerator != 0)
        {
            clone_Item_B = Instantiate(quest_Item_B);
            clone_Item_B.transform.parent = panel_Item_B.transform;
            randomGenerator--;
            quest_Number_B++;
        }
        done = true;
    }
}
