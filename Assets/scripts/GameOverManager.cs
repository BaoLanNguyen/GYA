using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverManager : MonoBehaviour
{   public GameObject gameOverUI;
    
    public void gameOver(){
        gameOverUI.SetActive(true);
    }
}