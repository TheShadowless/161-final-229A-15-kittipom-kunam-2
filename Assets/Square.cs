using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{   
    private int side = 2;
    public int I;
    public void Start()
    {
        init(" Square");
        Console.WriteLine($" Square is resized ");
        Resize();
        CalculateArea();

    }
    public override float CalculateArea()
    {
        I = side * side;
        Console.WriteLine($" Square squararea : {I} ");
        return I; 

    }
    public override void Resize()
    {
        Console.WriteLine($" Square size : {I} ");
    }
    
}
