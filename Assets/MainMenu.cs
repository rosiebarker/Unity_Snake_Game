using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //starts the game when pressed
    {
        SceneManager.LoadSceneAsync(1); //loads scene 1 (the game scene)
    }

    public void QuitGame() //this closes the game 
    {
        Application.Quit(); //exits the game 
    }
}
