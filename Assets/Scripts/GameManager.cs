using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject foodItem;
    [SerializeField] Transform spawnPoint;
    [SerializeField] TMP_Text scoreText;

    int score = 0;
    
    public void SpawnFood()
    {
        //Instantiante (what, in which position, in which rotation)
        Instantiate(foodItem, spawnPoint.position, spawnPoint.rotation);
    }
    public void AddPoint()
    {
        // Increment the score by 1
        score++;

        // Change the text value to the score
        scoreText.SetText("" + score);
    }
}
