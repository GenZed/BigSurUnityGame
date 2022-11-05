using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HoverColor : MonoBehaviour
{
    public Color startColor;
    public Color mouseOverColor;
    bool mouseOver = false;
    // Start is called before the first frame update
 
    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("Color, White", mouseOverColor);
        
    }
    void OnMouseExit()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("Color", startColor);
    }
    }