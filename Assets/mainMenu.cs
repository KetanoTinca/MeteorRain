using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    private float fadeTime;
	public void PlayGame()
    {
        fadeTime = GameObject.Find("Canvas").GetComponent<Fade>().BeginFade(1);
        ChangeLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator ChangeLevel()
    {
        
        yield return new WaitForSeconds(fadeTime);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}


