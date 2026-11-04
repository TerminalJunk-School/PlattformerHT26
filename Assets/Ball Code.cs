using System.Collections;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    float speed = 3f;

    Vector3 dir = new Vector3(1, 0, 0);

    GoalManager goal;
    [SerializeField]
    Paddle paddle1;
    [SerializeField]
    Paddle paddle2;

    bool shouldMove = true;

    void Start()
    {
        goal = FindFirstObjectByType<GoalManager>();//Letar efter ett objekt med GoalManager koden. Skapar sedan en referens dit.

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove && GoalManager.gameOver == false)
        {
            transform.position += dir * speed * Time.deltaTime;
        }

    }
        IEnumerator GoalPause()
    {

        shouldMove = false;
        yield return new WaitForSeconds(2);
        shouldMove = true;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "paddle")
        {
            dir.x *= -1;
            dir.y = Random.Range(-1f, 1f);
        }
        else if (collision.tag == "roof")
        {
            dir.y *= -1;
        }else if (collision.tag == "Goal")
       

        {
            print("Goal");
            
            if (transform.position.x > 0)
            {
                goal.player1Score += 1;
            }
            else
            {
                goal.player2Score += 1;
            }
            transform.position = new Vector3(0, 0, 0);//pante du är buns
            paddle1.transform.position = new Vector3(paddle1.transform.position.x, 0, 0);//sätter paddel 1 I mitten
            paddle2.transform.position = new Vector3(paddle2.transform.position.x, 0, 0);//sätter paddel 2 I mitten
            StartCoroutine(GoalPause());
        }
    }
}
