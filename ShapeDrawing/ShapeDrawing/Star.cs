using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Star : Shape
{

    private int numberOfPoints = 5;
	private int width;
	private int height;
    private Color color;

	public Star (int x, int y, int width, int height, Color color)
	{
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
        this.color = color;
	}

	public override string Draw ()
	{
        //Get all the corner points of the star
        Point[] pointList = GetCornerPoints();

        string star = "";

        //Draw all the lines of the star
        for (int i = 0; i < numberOfPoints; i++)
        {
            star = star + visual.DrawLine(pointList[i], pointList[i + 1], color ) + "/n";
        }

        
        return star;

	}


    /// <summary>
    /// This function give back the points of the Star
    /// </summary>
    /// <returns>A list containing the five points of a star</returns>
    public Point[] GetCornerPoints()
    {
        //Create empty list
        Point[] pts = new Point[numberOfPoints + 1];

        //Some awesome mathematical awesomness....
        double rx = width / 2;
        double ry = height / 2;
        double cx = x + rx;
        double cy = y + ry;
        double theta = -Math.PI / 2;
        double dtheta = 4 * Math.PI / numberOfPoints;
        
        //Create all the points for the star
        for (int i = 0; i < numberOfPoints; i++)
        {
            pts[i] = new Point(
                Convert.ToInt32(cx + rx * Math.Cos(theta)),
                Convert.ToInt32(cy + ry * Math.Sin(theta)));
            theta += dtheta;
        }

        pts[numberOfPoints] = pts[0];

        //Return all the points
        return pts;
    }
}


