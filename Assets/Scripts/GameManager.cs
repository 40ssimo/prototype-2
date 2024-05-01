using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int lives = 3;
    public int score = 0;
    void Start()
    {
        Debug.Log("Your lives = " + lives);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int point)
    {
        score += point;
        Debug.Log("Your score now is " + score);
    }

    public void AddLives(int point)
    {
        lives += point;

        if (lives == 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
        } else if (lives > 0) {
            Debug.Log("Your live = " + lives);
        }
    }
}
