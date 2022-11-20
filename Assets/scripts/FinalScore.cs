using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class FinalScore : MonoBehaviour
{
    public TMP_Text points;
    void Start()
    {
        points.text = "Your score: " + ScoreCounter.scoreValue;
    }
     
    
}
