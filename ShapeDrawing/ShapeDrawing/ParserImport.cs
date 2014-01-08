using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ParserImport
{
    public abstract List<Shape> ParseFromFile(string file)
    {
        return new List<Shape>();
    }

}
