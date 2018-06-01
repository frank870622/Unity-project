using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialBtn : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Tutorial;
    public AudioSource btnFX;
    public AudioClip hoverOnFX;
    public AudioClip clickFX;


    //click tutorial button to show tutorial
    public void ShowTutorial()
    {
        StartCoroutine(AfterFXEnd());
        AfterFXEnd();
    }
    IEnumerator AfterFXEnd()
    {
        yield return new WaitUntil(() => !btnFX.isPlaying);
        Menu.SetActive(false);
        Tutorial.SetActive(true);       
    }

    //mouse hover on sound
    public void HoverOnSound()
    {
        btnFX.PlayOneShot(hoverOnFX);
    }

    //mouse click on sound
    public void ClickSound()
    {
        btnFX.PlayOneShot(clickFX);
    }
}
