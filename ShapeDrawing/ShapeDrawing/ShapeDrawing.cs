﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

public class ShapeDrawingForm : Form
{
	private List<Shape> shapes;

	public ShapeDrawingForm()
	{
        MenuStrip menuStrip;
        menuStrip = new MenuStrip();

        ToolStripDropDownItem menu;
        menu = new ToolStripMenuItem("File");
		menu.DropDownItems.Add("Open...", null, this.openFileHandler);
		menu.DropDownItems.Add("Export...", null, this.exportHandler);
        menu.DropDownItems.Add("Exit", null, this.closeHandler);
        menuStrip.Items.Add(menu);

        this.Controls.Add(menuStrip);
		// Some basic settings
		Text = "Shape Drawing and Converter";
		Size = new Size(400, 400);
		CenterToScreen();
		SetStyle(ControlStyles.ResizeRedraw, true);
		
		// Initialize shapes
        shapes = new List<Shape>();
		
		// Listen to Paint event to draw shapes
		this.Paint += new PaintEventHandler(this.OnPaint); 
	}

    // What to do when the user closes the program
    private void closeHandler(object sender, EventArgs e)
    {
        this.Close();
    }

    // What to do when the user opens a file
    private void openFileHandler(object sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "";
        dialog.Title = "Open file...";
        ParserXML parser = new ParserXML();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            shapes = parser.ParseFromFile(dialog.FileName);
            this.Refresh();
        }

    }

    // What to do when the user wants to export a TeX file
	private void exportHandler (object sender, EventArgs e)
	{
		Stream stream;
		SaveFileDialog saveFileDialog = new SaveFileDialog();

		saveFileDialog.Filter = "SVG files|(*.svg";
		saveFileDialog.RestoreDirectory = true;


		if(saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			if((stream = saveFileDialog.OpenFile()) != null)
			{
				// Insert code here that generates the string of LaTeX
                //   commands to draw the shapes
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write("<?xml version='1.0' standalone='no'?> <!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN' 'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'> <svg xmlns='http://www.w3.org/2000/svg' version='1.1'> ");

                    Visual visual = new VisualSVG(writer);

                    //Draw all shapes
                    foreach (Shape shape in shapes)
                    {
                        shape.visual = visual;
                        
                        shape.Draw();
                    }

                    writer.Write("</svg>");
                }				
			}
		}
	}

    private void OnPaint(object sender, PaintEventArgs e)
	{
        Visual visual = new VisualGraphic(e.Graphics);

		// Draw all the shapes
        foreach (Shape shape in shapes)
        {
            shape.visual = visual;
            shape.Draw();
        }
	}
}