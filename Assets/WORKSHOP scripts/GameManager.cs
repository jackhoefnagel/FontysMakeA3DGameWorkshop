using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    void Awake(){
        instance = this;
        Time.timeScale = 1.0f;
    }

    public int score = 0;
    public int minimumScoreToFinish = 1;

    public float enemyTouchRadius = 1.0f;

    public float timePlayed = 0.0f;
    public bool isPlayTimerRunning = false;

    void Start(){
        Time.timeScale = 0.0f;
        GUIManager.instance.ShowStartScreen();
    }

    void Update(){
        if(isPlayTimerRunning){
            RunPlayTimer();
        }
    }



    public void StartPlayTimer(){
        isPlayTimerRunning = true;
    }

    public void RunPlayTimer(){        
        timePlayed += Time.deltaTime;
    }

    public void StopPlayTimer(){
        isPlayTimerRunning = false;
    }

    public void ResetPlayTimer(){
        timePlayed = 0.0f;
    }

    public void AddScore(int scoreToAdd){
        score += scoreToAdd;
    }

    public void PlayerEntersEndObject(){
        if(score >= minimumScoreToFinish){
            EndLevel();
        }
    }

    public void PlayerEntersDieObject(){        
        GameOver();
    }

    public void StartLevel(){
        Time.timeScale = 1.0f;
        StartPlayTimer();
        GUIManager.instance.HideStartScreen();
    }

    public void GameOver(){
        Time.timeScale = 0.0f;
        GUIManager.instance.ShowGameOverScreen();
    }

    public void EndLevel(){
        Time.timeScale = 0.0f;
        GUIManager.instance.ShowLevelEndScreen();
    }

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
