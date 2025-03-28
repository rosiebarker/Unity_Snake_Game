using UnityEngine;

using UnityEngine.SceneManagement; //controls scenes 



public class ExitButton : MonoBehaviour //create the class

{

    public void LoadMainMenu() //define the function

    {

        SceneManager.LoadScene(0); //tells unity what scene to load 

    }

}