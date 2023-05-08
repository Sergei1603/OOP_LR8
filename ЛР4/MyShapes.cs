﻿using System.Drawing;
using System.Security.Cryptography.X509Certificates;

	public class Ccircle : figure
	{
    public Ccircle(int x, int y, int size, Color color)
		{
			this.x = x;
			this.y = y;
			_check = true;
			this.size = size;
			_color = color;
		}
		public override void paint_shape(PaintEventArgs e)
		{
		e.Graphics.FillEllipse(new SolidBrush(_color), x - this.size / 2, y - this.size / 2, this.size, this.size);
		if (_check)
		{
			e.Graphics.DrawEllipse(new Pen(System.Drawing.Color.Red, 3), x - this.size / 2, y - this.size / 2, this.size, this.size);
		}
		}
		public bool Is_inside(int x, int y)
		{
			if ((x - this.x) * (x - this.x) + (y - this.y) * (y - this.y) <= this.size * this.size / 4)
			{
				return true;
			}
			return false;
		}
}

public class Square : poligon_shape
{
	public Square(int x, int y, int size, Color color)
	{
		this.x = x;
		this.y = y;
		_check = true;
		this.size = size;
		_color = color;
	}

	public override Point[] calculate_vertex()
	{
		Point p0 = new Point(x - size / 2,  y - size / 2);
		Point p1 = new Point(x - size / 2,  y + size / 2);
		Point p2 = new Point(x + size / 2,  y + size / 2);
		Point p3 = new Point(x + size / 2,  y - size / 2);
		Point[] points = { p0, p1, p2, p3 };
		return points;
    }
}
public class Triangle : poligon_shape
{
	public Triangle(int x, int y, int size, Color color)
	{
		this.x = x;
		this.y = y;
		_check = true;
		this.size = size;
		_color = color;
	}

	public override Point[] calculate_vertex()
	{
        Point point1 = new Point(x, (int)(y - size * Math.Sqrt(3) / 3));
        Point point2 = new Point(x - size / 2, (int)(y + (size * Math.Sqrt(3) / 6)));
        Point point3 = new Point(x + size / 2, (int)(y + (size * Math.Sqrt(3) / 6)));
        Point[] points = { point1, point2, point3 };
		return points;
    }

    public override bool Is_Outside(int width, int height)
    {
        if ((x < size / 2) || (y < (int)(size * Math.Sqrt(3) / 3)) || (x > width - 3 - size / 2) || (y > height - 3 - (int)(size * Math.Sqrt(3) / 6)))
            return true;
        return false;
    }

}

public class Hexagon : poligon_shape
{
	public Hexagon(int x, int y, int size, Color color)
    {
        this.x = x;
        this.y = y;
        _check = true;
        this.size = size;
        _color = color;
    }

	public override Point[] calculate_vertex()
	{
        Point point1 = new Point(x, y - size);
        Point point2 = new Point(x + (int)(Math.Sqrt(3) * size) / 2, y - size / 2);
        Point point3 = new Point(x + (int)(Math.Sqrt(3) * size) / 2, y + size / 2);
        Point point4 = new Point(x, y + size);
        Point point5 = new Point(x - (int)(Math.Sqrt(3) * size) / 2, y + size / 2);
        Point point6 = new Point(x - (int)(Math.Sqrt(3) * size) / 2, y - size / 2);
        Point[] points = { point1, point2, point3, point4, point5, point6 };
		return points;
    }

    public override bool Is_Outside(int width, int height)
    {
        if ((x < (int)(Math.Sqrt(3) * size) / 2) || (y < size) || (x > width - 3 - (int)(Math.Sqrt(3) * size) / 2) || (y > height - 3 - size))
            return true;
        return false;
    }
}
