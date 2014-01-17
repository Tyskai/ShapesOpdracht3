using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

class VisualSVG : Visual
{
    //Draw a SVG line
    public override string DrawLine(Point p1, Point p2, Color color)
    {
        string line = "<polyline points='" + p1.X + "," + p1.Y + "  " + p2.X + "," + p2.Y + " " + "' style='fill:none;stroke:" + getRGBstring(color) + ";stroke-width:1'/>";
        return line;
    }

    //Draw a Circle 
    public override string DrawCircle(int x, int y, int s, Color color)
    {
        int r = s / 2;

        string ellipse = "<circle cx='" + (x + r) + "' cy='" + (y + r) + "' r='" + r + "' stroke-width='1' fill='none' stroke='" + getRGBstring(color)  + "' />";
        return ellipse;
    }

    public string getRGBstring(Color color)
    {
        return "rgb(" + color.R + " ," + color.G + " ," + color.B+")";
    }

}