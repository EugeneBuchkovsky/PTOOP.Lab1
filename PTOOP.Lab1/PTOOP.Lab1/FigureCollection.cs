using System;
using System.Collections;
using System.Collections.Generic;
using PTOOP.Lab1.BLL.Interfaces;

namespace PTOOP.Lab1
{
	public class FigureCollection : IEnumerable<IFigure>
	{
		private List<IFigure> figureList;

		public FigureCollection()
		{
			figureList = new List<IFigure>();
		}

		public void AddFigure(IFigure f)
		{
			if (f != null)
				figureList.Add(f);
		}

		public IEnumerator<IFigure> GetEnumerator()
		{
			return figureList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return figureList.GetEnumerator();
		}
	}
}
