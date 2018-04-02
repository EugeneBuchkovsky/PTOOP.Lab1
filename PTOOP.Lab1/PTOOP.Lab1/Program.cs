using System;
using PTOOP.Lab1.BLL.Entities;

namespace PTOOP.Lab1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var drawer = new FigureDrawer();
			var collection = new FigureCollection();

			collection.AddFigure(new Line(10, 20));
			collection.AddFigure(new Circle(20, 20));
			collection.AddFigure(new Dot(30, 20));
			collection.AddFigure(new Ellispe(40, 20));
			collection.AddFigure(new Rectangle(50, 20));
			collection.AddFigure(new Triangle(60, 20));

			drawer.DrawFigures(collection);
		}
	}
}
