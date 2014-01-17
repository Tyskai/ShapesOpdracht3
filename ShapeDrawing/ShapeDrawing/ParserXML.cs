using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

public class ParserXML: ParserImport
{
	public override List<Shape> ParseFromFile(string Filename)
	{
		// Load xml documents
		XmlDocument doc = new XmlDocument();
		doc.Load(Filename);
		
		// Parse all shapes
		List<Shape> shapes = new List<Shape>();
		foreach(XmlNode shape in doc.SelectNodes("/shapes/*"))
		{
			string type = shape.Name;
            int x; int y; int width; int height; Color color;
			switch(type)
            {

                case "rectangle":
					x = int.Parse(shape.Attributes["x"].Value);
					y = int.Parse(shape.Attributes["y"].Value);
					width = int.Parse(shape.Attributes["width"].Value);
					height = int.Parse(shape.Attributes["height"].Value);
                    //WERKT NIET
                    color = Color.FromName((shape.Attributes["color"].Value));
                    //color = Color.Red;
                    shapes.Add(new Rectangle(x, y, width, height, color));
                    break;
                case "circle":
					x = int.Parse(shape.Attributes["x"].Value);
					y = int.Parse(shape.Attributes["y"].Value);
                    //LATER AANPASSEN -nu hardcoded
                    color = Color.Green;
					int size = int.Parse(shape.Attributes["size"].Value);
                    shapes.Add(new Circle(x, y, size, color));
                    break;
				case "star":
					x = int.Parse(shape.Attributes["x"].Value);
					y = int.Parse(shape.Attributes["y"].Value);
					width = int.Parse(shape.Attributes["width"].Value);
					height = int.Parse(shape.Attributes["height"].Value);
                    //LATER AANPASSEN - nu hardcoded
                    color = Color.Blue;
					shapes.Add (new Star(x,y,width,height, color));
					break;
            }
		}
		
		return shapes;
	}
}