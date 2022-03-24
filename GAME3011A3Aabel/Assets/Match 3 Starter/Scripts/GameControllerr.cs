using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerr : MonoBehaviour
{
    public GameControllerr() { }

    public static GameControllerr Instance;

    private int TimeText = 800;

    private bool GameOver = false;

   

    public int Time
    {
        get { return TimeText; }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Count", 0.0f, 1.0f);
        Instance = this;
    }

    void Count()
    {
        if (TimeText <= 0)
        {
            GameOver = true;
            CancelInvoke("Count");
            Debug.Log("Game Over");
            
        }
        else
        {
            TimeText--;
        }
    }

    public bool IsGameOver
    {
        get { return GameOver; }
    }
        
    // Update is called once per frame
    void Update()
    {
       
    }
}

