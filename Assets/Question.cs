using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    public bool isAnswer = false;
    static bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Yellow()
    {
        if (!isGameOver)
            this.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void White()
    {
        if (!isGameOver)
            this.GetComponent<Renderer>().material.color = Color.white;
    }

    public void Choose()
    {
        if (!isGameOver)
        {
            this.GetComponent<Renderer>().material.color = isAnswer ? Color.green : Color.red;
            isGameOver = true;
        }
    }

}
