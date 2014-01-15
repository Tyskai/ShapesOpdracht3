using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

class VisualSVG : Visual
{
    //Draw a SVG line
    public override string DrawLine(Point p1, Point p2)
    {
        string line = "<polyline points='" + p1.X + "," + p1.Y + "  " + p2.X + "," + p2.Y + " " + "' style='fill:none;stroke:black;stroke-width:1'/>";
        return line;
    }

    //Draw a Circle 
    public override string DrawEllipse(int x, int y, int w, int h)
    {
        int r = w / 2;

        string ellipse = "<circle cx='" + (x+r) + "' cy='" + (y+r) + "' r='" + r + "' stroke-width='1' fill='none' stroke='black' />";
        return ellipse;
    }

}