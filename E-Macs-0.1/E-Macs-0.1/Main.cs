using System;
using Gtk;

namespace EMacs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Title = "E-Macs Quick-Note";
			win.Show ();
			Application.Run ();
		}
	}
}
