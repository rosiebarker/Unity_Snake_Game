using UnityEngine;
using UnityEngine.UI; //this is needed when working with ui elements 

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    //ui elements that display the score and highscore
    public Text scoreText;  
    public Text highscoreText;

    //variables to store the score and the high score
    private int score = 0; 
    private int highscore = 0;
    
    //public to get the score and the highscore 
    public int Score => score;  
    public int Highscore => highscore; 

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {   
        //this loads the saved high score from PlayerPrefs
        highscore = PlayerPrefs.GetInt("highscore", 0);

        //this updates the score and  highscore on the ui
        scoreText.text = "POINTS: " + score;
        highscoreText.text = "HIGHSCORE: " + highscore;
    }

    public void AddPoint()
    {
        //increases the score by 1 point
        score += 1;
        scoreText.text = "POINTS: " + score;
        //if the new score is higher than the last saved highscore update the new score
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);//save the high score 
            PlayerPrefs.Save();//store it
            highscoreText.text = "HIGHSCORE: " + highscore;//update the ui
        }
    }

    public void ResetScore()
    {
        //reset the score to 0 and update ui
        score = 0;
        scoreText.text = "POINTS: " + score;
    }
}
