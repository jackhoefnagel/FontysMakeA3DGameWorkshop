using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIManager : MonoBehaviour {

    public static GUIManager instance;

    void Awake(){
        instance = this;
    }

    public Text scoreDisplay;
    public GameObject levelEndScreen;
    public GameObject gameOverScreen;
    public GameObject startScreen;


    void Update(){
        ShowScore();
    }

    private void ShowScore(){
        scoreDisplay.text = "Score: " + GameManager.instance.score + " / "+ GameManager.instance.minimumScoreToFinish + "  Time: "+GameManager.instance.timePlayed.ToString("F2");
    }

    public void ShowLevelEndScreen(){
        levelEndScreen.SetActive(true);
    }

    public void ShowGameOverScreen(){
        gameOverScreen.SetActive(true);
    }

    public void ShowStartScreen(){
        startScreen.SetActive(true);
    }

    public void HideStartScreen(){
        startScreen.SetActive(false);
    }
}
