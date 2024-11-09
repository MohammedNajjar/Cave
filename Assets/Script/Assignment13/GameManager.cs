using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
       public GameManager()
    {
    }

    void Start()
    {
        Player1 player1 = new Player1();
        player1.InitializePlayer("Player 1", 80);
        player1.Heal(20);
        player1.Heal(true);

        Player1 player2 = new Player1();
        player2.InitializePlayer("Player 2", 50);
        player2.Heal(30);

        Player1.ShowPlayerCount();
    }
}
