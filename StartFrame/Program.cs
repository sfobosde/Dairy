using StartFrame.Presentors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartFrame
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			StartFramePresentor startFramePresentor;

			startFramePresentor = new StartFramePresentor();
		}
	}
}
