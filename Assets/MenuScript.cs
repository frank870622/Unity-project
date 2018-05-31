using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public GameObject Menu;
    public GameObject Tutorial;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene("Game"); 
    }

    public void ShowTutorial()
    {
        Menu.SetActive(false);
        Tutorial.SetActive(true);
    }

    public void BackToMenu()
    {
        Menu.SetActive(true);
        Tutorial.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
