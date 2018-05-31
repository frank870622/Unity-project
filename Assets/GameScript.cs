using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {

    public GameObject InGame;
    public GameObject PauseMenu;


    bool gameIsPause = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //press ESC for pause or unpause the game
        if (Input.GetKeyDown(KeyCode.Escape))   
        {
            if (!gameIsPause)   //if game is not pause, than pause
            {
                gameIsPause = true;
                GamePause();
            }
            else                //if game is pause, than unpause
            {
                gameIsPause = false;
                BacktoGame();
            }
        }
	}

    //for game pause
    public void GamePause() 
    {
        InGame.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    //for back to menu
    public void BacktoMenu()    
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    //for back to game
    public void BacktoGame()   
    {
        gameIsPause = false;
        InGame.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
