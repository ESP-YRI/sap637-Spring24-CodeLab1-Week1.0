using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using Random = System.Random;

public class GetEaten : MonoBehaviour
{
    private float randomX;
    private float randomZ;
    public TextMeshProUGUI score;
    private int myScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //when collided with, the object will move to a random position on the gamefield
    //the score variable is also increased by 1 and printed on the screen
    private void OnTriggerEnter(Collider other)
    {
        randomX = UnityEngine.Random.Range(-20, 20);
        randomZ = UnityEngine.Random.Range(-10, 10);
        transform.position = new Vector3(randomX, .03f, randomZ);
        myScore++;
        score.text = "Score: " + myScore;
    }
}
