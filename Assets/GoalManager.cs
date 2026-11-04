using UnityEngine;
using TMPro;

public class GoalManager : MonoBehaviour
{
   public int player1Score = 0;
    public int player2Score = 0;

    [SerializeField] int scoreTarget = 10;
    public static bool gameOver = false;

    TMP_Text goalText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goalText = GetComponent<TMP_Text>();//hämtar en referens till texten på samma objekt som denna kod sitter på.
    }

    // Update is called once per frame
    void Update()
    {
        if (player1Score >= scoreTarget)
        {
            gameOver = true;
        } else if(player2Score >= scoreTarget)
        {
            gameOver = true;
        }
            //uppdaterar texten på skärmen
        goalText.text = player1Score + "-" + player2Score;//Nämen, nu är det lite salsa
    }
}
