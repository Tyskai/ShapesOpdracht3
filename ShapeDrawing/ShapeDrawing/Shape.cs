using System;
using System.Drawing;

public abstract class Shape
{

    public int x;
    public int y;


	public Shape()
	{
	}

    public abstract void Draw(Graphics Canvas);
	
}