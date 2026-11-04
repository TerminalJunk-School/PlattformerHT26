using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float speed = 3f;//how fast le cuboid shall be going per frame or sum
    [SerializeField]
    KeyCode up = KeyCode.W;
    [SerializeField]
    KeyCode down = KeyCode.S;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GoalManager.gameOver == false)
        {
            if (Input.GetKey(up))//Starts by telling the code what will happen once the player presses the up key
            {
                transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;//Details the movement of le cuboid which will defensively keep the ball from reaching anything bro.
            }
            else if (Input.GetKey(down))//Says shit like "however, IF the player were to press on the down button,"
            {
                transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;//"Le cuboid will move down"
            }
            transform.position =
               new Vector3(transform.position.x,
               Mathf.Clamp(transform.position.y, -3.3f, 3.3f), 0);//I'm going to be honest with you I have completely forgotten what this does. Clown me frfr

        }

    }
}
 
//This line of script does absolutely nothing! Crazy work!!