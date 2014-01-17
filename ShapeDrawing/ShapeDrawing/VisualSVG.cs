using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

class VisualSVG : Visual
{
    public StreamWriter writer;

    public VisualSVG(StreamWriter w)
    {
        writer = w;
    }

    //Draw a SVG line
    public override void DrawLine(Point p1, Point p2, Color color)
    {
        string line = "<polyline points='" + p1.X + "," + p1.Y + "  " + p2.X + "," + p2.Y + " " + "' style='fill:none;stroke:" + getRGBstring(color) + ";stroke-width:1'/>";

        writer.Write(line);
    }

    //Draw a Circle 
    public override void DrawCircle(int x, int y, int s, Color color)
    {
        int r = s / 2;

        string circle = "<circle cx='" + (x + r) + "' cy='" + (y + r) + "' r='" + r + "' stroke-width='1' fill='none' stroke='" + getRGBstring(color)  + "' />";

        writer.Write(circle);
    }

    /// <summary>
    /// Creates a RGB string needed to export a Color to something the SVG code understand
    /// </summary>
    /// <param name="color">The color needed to be exported</param>
    /// <returns>The created String containing the SVG color code</returns>
    public string getRGBstring(Color color)
    {
        return "rgb(" + color.R + " ," + color.G + " ," + color.B+")";
    }

}