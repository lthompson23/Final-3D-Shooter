using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Play(string Level1)
    {
        Debug.Log("Start");
        SceneManager.LoadScene(Level1);
    }

    public void Quit()
    {
        //Quit the game
        Application.Quit();
        Debug.Log("Exit");
    }

    
}
