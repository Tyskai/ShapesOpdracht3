using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

	private int width;
	private int height;
    private int numerOfPoints;

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;

        this.numerOfPoints = 4;
    }
    
	public override string Draw()
    {
		Pen pen = new Pen(Color.Black);

        Point[] points = GetCornerPoints();

        string rectangle = "";

        //A for loop will draw each line of the rectangle
        for (int i = 0; i < numerOfPoints; i++)
        {
            rectangle = rectangle + visual.DrawLine(points[i], points[i+1]) +"/n";
        }

        return rectangle;

    }

    /// <summary>
    /// This function gives back the points of the rectangle
    /// </summary>
    /// <returns>A list containing the four corners of a recctangle</returns>
    public Point[] GetCornerPoints()
    {
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


        //THe list containing the corner points
        Point[] pointList = new Point[numerOfPoints + 1];

        //Add the points to the list
        pointList[0] = ul;
        pointList[1] = ur;
        pointList[2] = lr;
        pointList[3] = ll;
        pointList[4] = ul;

        return pointList;
    }
}

