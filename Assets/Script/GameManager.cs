using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Player player1 = new Player();
        player1.InitializePlayer("Player 1", 80);
        player1.Heal(20);
        player1.Heal(true);

        Player player2 = new Player();
        player2.InitializePlayer("Player 2", 50);
        player2.Heal(30);

        Player.ShowPlayerCount();
    }



}
