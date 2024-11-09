using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Player2 player = new Player2("Subhi", 80);
        Enemy enemy = new Enemy("Zarifeh", 100);
        Debug.Log("Initial Stats:");
        Debug.Log("Player: " + player.Name + " - Health: " + player.Health);
        Debug.Log("Enemy: " + enemy.Name + " - Health: " + enemy.Health);

        Debug.Log("Testing Heal Method:");
        player.Heal(30);

        Debug.Log("Testing Attack Method:");
        enemy.Attack(player, 25);
    }
}

 

