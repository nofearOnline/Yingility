using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource start;
    public AudioSource quit;

    // Start is called before the first frame update
    public void PlayGame()
    {
        start.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        quit.Play();
        Debug.Log("Closing the game");
        Application.Quit();
    }
}
