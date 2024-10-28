using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// PRINT MASSIGE
    /// </summary>
    
 int playerLives = 3;

    void Start()
    {
        while(playerLives>0){
            if(playerLives==3){
                Debug.Log("Many lives");
            }
            else if(playerLives==1){
                Debug.Log("The last life");}
                playerLives--;
        }
        Debug.Log("Game Over");
    }


}
