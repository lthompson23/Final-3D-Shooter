using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public void Quit()
    {
        //Quit the game
        Application.Quit();
        Debug.Log("Exit");
    }

    public void MainMenu(string Level1)
    {
        SceneManager.LoadScene(Level1);
    }

}
