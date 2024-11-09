using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character
{
    private String name;

    private int health;
    public String Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Health
    {
        get { return health; }
        set
        {
            health = value < 0 ? 0 : (value > 100 ? 100 : value);

        }
    }
    public Character(String name, int health)
    {
        this.name = name;
        this.health = health;
    }





}
