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
    public override string DrawLine(Point p1, Point p2)
    {
        //Create a pen
        Pen pen = new Pen(Color.Black);

        Canvas.DrawLine(pen, p1, p2);

        return "";
    }

    //Draw an eppilse
    public override string DrawEllipse(int x, int y, int w, int h)
    {
        //Create a pen
        Pen pen = new Pen(Color.Black);

        Canvas.DrawEllipse(pen, x, y, w, h);

        return "";

    }

}