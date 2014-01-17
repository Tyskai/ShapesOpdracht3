using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{

	private int size;
    private Color color;

    public Circle(int x, int y, int size, Color color)
    {
		this.x = x;
		this.y = y;
		this.size = size;
        this.color = color;
    }

    public override string Draw()
    {
        return visual.DrawCircle(this.x, this.y, this.size, this.color);

    }

}
