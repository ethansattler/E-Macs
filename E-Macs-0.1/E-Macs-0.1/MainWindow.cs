using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public static string the_file;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected virtual void Save_as(object sender, System.EventArgs e)
	{
		Gtk.FileChooserDialog fc=
		new Gtk.FileChooserDialog("Choose the file to save",
		                            this,
		                            FileChooserAction.Open,
		                            "Cancel",ResponseType.Cancel,
		                            "Save",ResponseType.Accept);

		if (fc.Run() == (int)ResponseType.Accept) 
		{

		}			Gtk.TextBuffer buf;
			buf = textview1.Buffer;
			String text = buf.Text.ToString();
			System.IO.File.WriteAllText(fc.Filename, text);
			Console.WriteLine(fc.Filename);
			the_file = @fc.Filename;

		fc.Destroy();
	}

	protected virtual void Open(object sender, System.EventArgs e)
	{
		if (string.IsNullOrEmpty (the_file) || string.IsNullOrWhiteSpace (the_file)) {
			//Save_as(sender, e);
		} else {
			Gtk.TextBuffer buf;
			buf = textview1.Buffer;
			String text = buf.Text.ToString ();
			System.IO.File.WriteAllText (the_file, text);
			Console.WriteLine (the_file);
		}
		Gtk.FileChooserDialog fc=
		new Gtk.FileChooserDialog("Choose the file to open",
		                            this,
		                            FileChooserAction.Open,
		                            "Cancel",ResponseType.Cancel,
		                            "Open",ResponseType.Accept);

		if (fc.Run() == (int)ResponseType.Accept) 
		{
			string[] lines = System.IO.File.ReadAllLines(@fc.Filename);
			string file = "";
			foreach (string line in lines)
        	{

            if (string.IsNullOrEmpty(file)) {
					file = line;
				} else {
					file = file + "\n" + line;
				}
        	}
			textview1.Buffer.Text = file;
		}

		this.Title = "E-Macs Quick-Note - (" + System.IO.Path.GetFileName(@fc.Filename) + ")";
		the_file = @fc.Filename;
		fc.Destroy();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void save (object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty (the_file) || string.IsNullOrWhiteSpace (the_file)) {
			Save_as(sender, e);
		} else {
			Gtk.TextBuffer buf;
			buf = textview1.Buffer;
			String text = buf.Text.ToString ();
			System.IO.File.WriteAllText (the_file, text);
			Console.WriteLine (the_file);
		}
	}
	protected void save_as (object sender, EventArgs e)
	{
		Console.WriteLine("Save as Handler");
		Save_as(sender, e);
	}

	protected void open (object sender, EventArgs e)
	{
		Console.WriteLine("Open Handler");
		Open(sender, e);
	}

	protected void exit (object sender, EventArgs e)
	{
		Application.Quit();
	}	

	}


