using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea; //creates variable that stores the area where the food will randomly appear

    private void Start()//on start place the food in a random position in the gridArea
    {
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds; //gets the boundaries of the grid position 

        //this picks a random x and y position on the grid
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        //this moves the food to it's new position and then rounds in up to keep it on a grid
        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if the food touches the snake(the player) move it to a random position 
        if (other.tag == "Player") {
        RandomizePosition();    
        }
        
    }
}