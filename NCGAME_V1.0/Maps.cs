using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCGAME_V1._0
{

	public class Maps
	{
		private int _xSize;
		private int _ySize;

		public Maps()
		{
			_xSize = 10;
			_ySize = 10;
		}

		public int XSize
		{
			get { return _xSize; }
			set { _xSize = value; }
		}
		public int YSize
		{
			get { return _ySize; }
			set { _ySize = value; }
		}
	}
}
