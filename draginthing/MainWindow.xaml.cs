using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace draginthing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
	/// 



    public partial class MainWindow : Window
    {
		int getnum(char ac)
		{
			switch((int)ac)
			{
				case 48:
					return 0;
				case 49:
					return 1;
				case 50:
					return 2;
				case 51:
					return 3;
				case 52:
					return 4;
				case 53:
					return 5;
				case 54:
					return 6;
				case 55:
					return 7;
				case 56:
					return 8;
				case 57:
					return 9;
				case 88:
					return 10;
				case 120:
					return 10;
				default:
					return 0;
			}
		}
		bool testnum(char ac)
		{
			switch ((int)ac)
			{
				case 48:
					return true;
				case 49:
					return true;
				case 50:
					return true;
				case 51:
					return true;
				case 52:
					return true;
				case 53:
					return true;
				case 54:
					return true;
				case 55:
					return true;
				case 56:
					return true;
				case 57:
					return true;
				case 88:
					return true;
				case 120:
					return true;
				default:
					return false;
			}
		}

		bool teststring(string astring)
		{
			if (astring.Length == 0)
				return false;
			int temp = 0;
			for (int i = 0; i < astring.Length; i++)
			{
				switch ((int)astring[i])
				{
					case 48:
						temp++;
						break;
					case 49:
						temp++;
						break;
					case 50:
						temp++;
						break;
					case 51:
						temp++;
						break;
					case 52:
						temp++;
						break;
					case 53:
						temp++;
						break;
					case 54:
						temp++;
						break;
					case 55:
						temp++;
						break;
					case 56:
						temp++;
						break;
					case 57:
						temp++;
						break;
				}
			}
			if (temp == astring.Length)
				return true;
			return false;
		}

		void fizzbuzz(int a)
		{
			string fibu = "";
			if (a % 3 == 0)
				fibu += "Fizz";
			if (a % 5 == 0)
				fibu += "Buzz";
			if (fibu != "")
				Console.WriteLine(fibu);
		}

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			char[] nustring = texbox.Text.ToCharArray();
			texblok.Text = "clicked";
			float tcount = 10;
			float tf = 0;
			for (int i = 0; i < nustring.Length; i++ )
			{
				if (!testnum(nustring[i]))
				{
					i = nustring.Length;
					texblok.Text = "ERROR: INVALID CHARACTERS";
					tcount = -2;
					continue;
				}
				tcount--;
				if (tcount < -1)
				{
					texblok.Text = "ERROR: TOO MANY NUMBERS";
				}
			}
			if (tcount > 0)
				texblok.Text = "ERROR: NOT ENOUGH NUMBERS";
			if (tcount == 0)
			{
				tcount = 10;
				for (int i = 0; i < nustring.Length; i++ )
				{
					tf += tcount * getnum(nustring[i]);
					tcount--;
				}

				/*
				float a = tf / 11;
				float b = (int)(tf / 11);
				float c = a - b;
				c = c;
				*/

				if (((tf/11) - (int)(tf/11)) > 0)
				{
					texblok.Text = "invalid salid";
				}
				else
				{
					texblok.Text = "VALID SALAD";
				}
			}
        }

		private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			texblok.Text = "oh no";
		}

		private void loadbutt_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.InitialDirectory = "C:\\Users\\tyler.miller\\Desktop" + "\\TESTFOLDER";
			opf.Filter = "ALL FILES (*.*)|*.*|BITMAP IMAGES (*.bmp)|*.bmp|COMPUSERVE GIF (*.gif)|*.gif";
			//opf.Filter = "ALL FILES (*.*)"
			opf.FilterIndex = 1;
			//opf.Multiselect = true;
			opf.RestoreDirectory = true;
			bool? userClickedOK = opf.ShowDialog();

			if (userClickedOK == true)
			{
				
				setbox.Text = opf.FileName;
				testimg.Source = new WriteableBitmap(new BitmapImage(new Uri(opf.FileName)));
				
				//opf.OpenFile();
			}
		}

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			texblok.Text = testslider.Value.ToString();
			Console.WriteLine(testslider.Value.ToString());
		}

		private void FIZZBUZZ_Click(object sender, RoutedEventArgs e)
		{
			
			for (int i = 0; i < 100; i++)
				fizzbuzz(i);
		}

		private void belowonek_Click(object sender, RoutedEventArgs e)
		{
			if (!teststring(numfor.Text))
				return;
			int a;
			try
			{
				a = Int32.Parse(numfor.Text);
			}
			catch(System.OverflowException numforException)
			{
				Console.WriteLine("OVERFLOW ERROR; ", numforException.Message);
			}
			finally
			{
				a = 0;
			}

			double b = 0;
			for(int i = 0; i < a; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					b += i;
			}
			Console.WriteLine(b);
		}

		private void numfor_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (!teststring(shapebox.Text))
				return;
			int a;
			try
			{
				a = Int32.Parse(shapebox.Text);
			}
			catch (System.OverflowException numforException)
			{
				Console.WriteLine("OVERFLOW ERROR; ", numforException.Message);
			}
			finally
			{
				a = 0;
			}
			if (a == 0)
				return;


		}
	}
}

//AppDomin.CurrentDowmain.BaseDirectory