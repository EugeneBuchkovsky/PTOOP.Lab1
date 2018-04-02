using System;
using System.Collections.Generic;
using PTOOP.Lab1.BLL.Interfaces;

namespace PTOOP.Lab1
{
	public class FigureDrawer
	{
		public FigureDrawer()
		{
		}

		public void DrawFigures(IEnumerable<IFigure> figures)
		{
			if (figures == null) return;

			foreach (var f in figures)
			{
				DrawFigure(f);
			}
		}

		private void DrawFigure(IFigure figure)
		{
			if (figure == null) return;

			Console.WriteLine("Figure: " + figure.GetType().Name + "( " + figure.X + " ," + figure.Y + " )");
			Console.WriteLine();
		}
	}
}
