using UnityEngine;
using System.Collections;

public class GenerateQuestion_A : MonoBehaviour {
    public GameObject panel_Item_A;
    public GameObject quest_Item_A;
    public GameObject clone_Item_A;
    public int randomGenerator;
    public int quest_Number_A;
    public bool done;
    public int currentMode;

    void Start () {
        PlayerPrefs.GetInt("mode");
        currentMode = GameObject.Find("gameCon_mode").GetComponent<gameCon_mode>().mode;
        if (currentMode == 1)
        {
            randomGenerator = Random.Range(5, 10);
        }
        else
        {
            randomGenerator = Random.Range(1, 10);
        }
        done = false;
        while (randomGenerator != 0)
        {
            clone_Item_A = Instantiate(quest_Item_A);
            clone_Item_A.transform.parent = panel_Item_A.transform;
            randomGenerator--;
            quest_Number_A++;
        }
        done = true;
    }
}
