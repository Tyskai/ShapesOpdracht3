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
    private Color color;

    public Rectangle(int x, int y, int width, int height, Color color)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
        this.color = color;

        this.numerOfPoints = 4;
    }
    
    /// <summary>
    /// This method calls the methods needed to draw a Rectangle
    /// </summary>
	public override void Draw()
    {
        Point[] points = GetCornerPoints();

        //A for loop will draw each line of the rectangle
        for (int i = 0; i < numerOfPoints; i++)
        {
            visual.DrawLine(points[i], points[i+1], color);
        }

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

