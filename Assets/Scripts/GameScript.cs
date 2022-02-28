using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour

{  
   [SerializeField] Text GuessText;
   int min;
   int max ;
   int guess;
    void Start()

    {  min=0;
       max=1501; 
       guess=(min+max)/2;
       GuessText.text=guess.ToString();
    }

    
    void Update()
    { 
       
            }
   public void GuessUp(){
    min=guess;
    guess=(max+min)/2;
    GuessText.text=guess.ToString();
    
    
   }
   public void GuessDown(){
    max=guess;
    guess=(max+min)/2;
    GuessText.text=guess.ToString();
    
    
   }
    
}
