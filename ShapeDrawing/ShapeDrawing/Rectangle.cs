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

        Point[] points = GetCornerPoints();

        Canvas.DrawLine(pen, points[0], points[1]);
        Canvas.DrawLine(pen, points[1], points[2]);
        Canvas.DrawLine(pen, points[2], points[3]);
        Canvas.DrawLine(pen, points[3], points[0]);
    }

    /// <summary>
    /// This function gives back the points of the rectangle
    /// </summary>
    /// <returns>A list containing the four corners of a recctangle</returns>
    public Point[] GetCornerPoints()
    {

        int numerOfPoints = 4;

        //THe list containing the corner points
        Point[] pointList = new Point[numerOfPoints];

        //upper left point
        Point ul = new Point();
        ul.X = x;
        ul.Y = y;

        //upper right point
        Point ur = new Point();
        ur.X = x + width;
        ur.Y = y;


        //lower right point
        Point lr = new Point();
        lr.X = x + width;
        lr.Y = y + height;


        //lower left point
        Point ll = new Point();
        ll.X = x;
        ll.Y = y + height;


        //Add the points to the list
        pointList[0] = ul;
        pointList[1] = ur;
        pointList[2] = lr;
        pointList[3] = ll;

        return pointList;
    }
}

