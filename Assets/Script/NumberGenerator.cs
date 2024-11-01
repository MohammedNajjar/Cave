using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    // Start is called before the first frame update
   public int number = 0;

    void Start()
    {
        
        while(number<20){
            Debug.Log(Random.Range(1,21));
            number++;
            if(number==5){
                continue;
            }
            else if( number==15 ){
                break;
            }

        }
    }
}
