using System;
using System.Drawing;

public abstract class Shape
{
    public int x;
    public int y;

    public Visual visual;


    public Shape();
    public abstract string Draw();
	
}