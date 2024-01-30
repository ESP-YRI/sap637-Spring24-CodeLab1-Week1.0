using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ResetButton : MonoBehaviour
{
    private Rigidbody myRB;

    public TextMeshProUGUI screenText;
    
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if you roll off the edge of the world, text prompts you to press R and reset the scene
        //which gets you back to the playable level
        if (myRB.position.y < -1)
        {
            screenText.text = "Fell off the world huh. Hit R to restart lol";
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
