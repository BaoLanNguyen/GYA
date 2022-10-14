using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreCounter : MonoBehaviour
{
       private int scoreValue;
    public TMP_Text score;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        score.text="Score: " + scoreValue;
    }
 
   private void OnTriggerEnter2D(Collider2D gem) {
    scoreValue +=10;
    Destroy(gem.gameObject);
   }
    void Update()
    {
        score.text ="score: " + scoreValue;
    }
}
