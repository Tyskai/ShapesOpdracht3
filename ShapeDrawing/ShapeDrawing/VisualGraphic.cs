using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

class VisualGraphic : Visual
{
    public Graphics Canvas;
  
    public VisualGraphic(Graphics can)
    {
        Canvas = can;
    }

    
    /// <summary>
    /// Draws a rectangle
    /// </summary>
    /// <param name="p1">The starting point of the line</param>
    /// <param name="p2">The end point of the line</param>
    /// <param name="color">The color of the line</param>
    public override void DrawLine(Point p1, Point p2, Color color)
    {
        //Create a pen
        Pen pen = new Pen(color);

        Canvas.DrawLine(pen, p1, p2);
    }

    /// <summary>
    /// Draws a circle
    /// </summary>
    /// <param name="x">The x coordinate of the square containing this circle</param>
    /// <param name="y">The y coordinate of the square containing this circle</param>
    /// <param name="s">The size (or weight/height) of the circle</param>
    /// <param name="color">The color of the circle border</param>
    public override void DrawCircle(int x, int y, int s, Color color)
    {
        //Create a pen
        Pen pen = new Pen(color);

        Canvas.DrawEllipse(pen, x, y, s, s);
    }

}