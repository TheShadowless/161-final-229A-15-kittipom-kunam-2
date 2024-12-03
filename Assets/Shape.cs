using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;
    public string ShapeName
    {
        get { return shapeName; }
        set { shapeName = value; }
    }
    public void init(string newShapName)
    { 
        ShapeName = newShapName;
    }
    public abstract float CalculateArea();
    public virtual void Resize()
    {
        Console.WriteLine($" resized ");
    }
    public void Draw() 
    {
        Console.WriteLine($"draw {this.shapeName} shape   ");
    }
    private void Start()
    {
         
    }
}

