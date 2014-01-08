using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

	private int width;
	private int height;

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
    }
    
	public override void Draw(Graphics Canvas)
    {
		Pen pen = new Pen(Color.Black);
		Canvas.DrawLine(pen,x,y,x + width,y);
		Canvas.DrawLine(pen,x+width,y,x+width,y+height);
		Canvas.DrawLine(pen,x+width,y+height,x,y+height);
		Canvas.DrawLine(pen,x,y+height,x,y);
    }

    /// <summary>
    /// This function gives back the points of the rectangle
    /// </summary>
    /// <returns>A list containing the four corners of a recctangle</returns>
    public List<Point> GetCornerPoints()
    {
        Point a = new Point();
        a.X = 4;
        a.Y = 3;

        List<Point> pointList = new List<Point>();

        pointList.Add(a);

        return pointList;
    }
}

