using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public void UIOnPointEnter()
    {
        this.GetComponent<Image>().color = Color.green;
    }

    public void UIOnPointDown()
    {
        this.GetComponent<Image>().color = Color.red;
    }

    public void MeshOnPointEnter()
    {
        this.GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("HI");
    }

    public void MeshOnPointDown()
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }
}
