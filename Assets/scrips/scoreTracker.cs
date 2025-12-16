using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreTracker : MonoBehaviour
{
    private int score = 0; // stores the score in a variable
    public void addScore() //this function is called in the enemy script when a coliosion with a cannonball occurs
    {
        score += 500; // add 500 to the score 
        Debug.Log("Score is: " + score); // debug message to show the score

        if (score >= 1500) //the player can only rech a score of 1500 as thier is only three enemys once this happens the scene must restet
        {
            score = 0; // resets the score 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //this resets the scene by using the sceneManager to load the current scene 
        }
    }
}
