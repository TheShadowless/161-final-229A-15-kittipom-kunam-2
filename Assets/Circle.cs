using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Circle : Shape
{
    private float raidus = 3.16f;
    private float sider = 2;
    public float G;
    public void Start()
    {
        init("Circle");
        Console.WriteLine($"Circle is resized ");
        Resize();
        CalculateArea();    
    }
    public override float CalculateArea()
    {
        G = raidus * sider * sider;
        Console.WriteLine($"Circle squararea : {G} ");
        return G;

    }
    public override void Resize()
    {
        Console.WriteLine($"Circle size : {G} ");
    }

}
