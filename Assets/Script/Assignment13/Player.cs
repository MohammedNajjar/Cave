using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Player
{
    public string playerName;
    public int health;

    private static int playerCount = 0;

    /*
     public Player()
        {
            playerCount++;
        }
    */
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(playerName + " fully restored to full health: " + health);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log(playerName + " did not receive full health restoration.");
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log($"Total number of Player objects: {playerCount}");
    }
}
