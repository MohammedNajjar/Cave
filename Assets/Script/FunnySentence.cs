using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnySentence : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";
        int wordCount = 0;
       
       while(wordCount < 7)
       {
           sentence += words[Random.Range(0, words.Length)] + " ";
           wordCount++;
       }
       
       Debug.Log(sentence + ".");
    }
}