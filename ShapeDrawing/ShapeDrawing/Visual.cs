using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

/// <summary>
/// PROBLEM
/// We have the Draw method in SHape && the DrawLine and DrawEllipse method return STRING
/// we wont want that
/// how to fix it?
/// 
/// 
/// </summary>

public abstract class Visual
{
    public abstract string DrawLine(Point p1, Point p2, Color color);
    public abstract string DrawCircle(int x, int y, int s, Color color);
}
