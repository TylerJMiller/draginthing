using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace draginthing
{
	class CanvasBitmap : Canvas
	{
		public CanvasBitmap()
		{
			WriteableBitmap NewBitmap = new WriteableBitmap(new BitmapImage(new Uri("C:\\Users\\tyler.miller\\Desktop\\TESTFOLDER\\purple.bmp")));
			
		}

	}
}
