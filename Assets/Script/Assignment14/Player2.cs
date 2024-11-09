using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Character
{
   public Player2(string name, int health) : base(name, health)
    {
    }

    public void Heal(int amount)
    {
        int oldHealth = Health;
        Health += amount;
Debug.Log(Name + " healed for " + amount + " points. Health increased from " + oldHealth + " to " + Health);    }

}
