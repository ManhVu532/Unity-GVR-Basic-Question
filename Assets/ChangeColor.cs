using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void Red()
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }
    public void Blue()
    {
        this.GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Black()
    {
        this.GetComponent<Renderer>().material.color = Color.black;
    }
}
