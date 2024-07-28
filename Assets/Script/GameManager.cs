using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public GameObject winner;
    public GameObject point;
    public TMP_Text time;
    public TMP_Text totalTime;
    

    private bool hasEatenPoint = false; 
    void Start() 
    { 
        Time.timeScale = 1;
    }

    void Update()
    {
        int displayTime = Mathf.FloorToInt(Time.time);
        // Cập nhật văn bản hiển thị thời gian
        time.text = "Time: " + displayTime;
    }

    public void WinWithPoint()
    {
        if (hasEatenPoint) // Check if player has eaten a point before winning
        {
            winner.SetActive(true);
            Time.timeScale = 0;
        }
    }

    // Add a method to update the hasEatenPoint flag when the player eats a point
    public void OnPointEaten()
    {
        hasEatenPoint = true;
    }

    
}
