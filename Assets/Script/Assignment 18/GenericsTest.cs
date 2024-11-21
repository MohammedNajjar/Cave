using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> potionContainer = new GameContainer<string>();
        potionContainer.SetItem("Healing Potion");
        Debug.Log("Stored item: " + potionContainer.GetItem());
        string description = GameUtils.DescribeItem(potionContainer.GetItem());
        Debug.Log(description);
    }


}
