using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadResultMenu2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D flag) {
    SceneManager.LoadScene("ResultMenu2");
}
}
