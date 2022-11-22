using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLVSelect : MonoBehaviour
{
   public void LoadSelection(){
    SceneManager.LoadScene("LevelSelection");
}
}
