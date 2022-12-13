using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreCounter : MonoBehaviour
{
       public static int scoreValue;
    public TMP_Text score;
    public bool IsGemDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        score.text="Score: " + scoreValue;
    }
 
   private void OnTriggerEnter2D(Collider2D gem) {
    if( gem.tag =="gem"){
    Destroy (gem.gameObject);
    if (IsGemDestroyed == false)
    {
        scoreValue+=20;
        IsGemDestroyed=true;
    }
}
   }
    void Update()
    { if(IsGemDestroyed==true)
    {
        IsGemDestroyed=false;
    }
        score.text ="score: " + scoreValue;
    }
}
