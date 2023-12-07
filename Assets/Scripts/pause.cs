using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{

    //The name of the input button that will pause the game
    public string pauseInputName;
    //A static variable to keep track of whether the game is paused
    public static bool isPaused = false;
    //The object with the pause menu
    public GameObject pauseMenuObject;

    // Start is called before the first frame update
    void Start()
    {
        UnPause();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
                Pause();
            else
                UnPause();
        }
    }

    public void MainMenu(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }

    //The function that will pause the game
    public void Pause()
    {
        //The pause menu is shown
        pauseMenuObject.SetActive(true);

        //Set timescale to 0, freezing time
        Time.timeScale = 0f;
        //isPaused is set to true
        isPaused = true;

        
    }

    //The function that will unpause the game
    public void UnPause()
    {
        //The pause menu is hidden
        pauseMenuObject.SetActive(false);

        //Set time to normal
        Time.timeScale = 1f;
        //isPaused is set to false
        isPaused = false;
    }

    public void Quit()
    {
        //Quit the game
        Application.Quit();
        Debug.Log("Exit");
    }

    public void Instructions(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }
}
