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

    //Draw an circle
    public override string DrawLine(Point p1, Point p2, Color color)
    {
        //Create a pen
        Pen pen = new Pen(color);

        Canvas.DrawLine(pen, p1, p2);

        return "";
    }

    //Draw an eppilse
    public override string DrawCircle(int x, int y, int s, Color color)
    {
        //Create a pen
        Pen pen = new Pen(color);

        Canvas.DrawEllipse(pen, x, y, s, s);

        return "";

    }

}