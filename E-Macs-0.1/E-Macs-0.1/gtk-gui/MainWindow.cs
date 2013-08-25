
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action saveAction;
	private global::Gtk.Action saveAsAction;
	private global::Gtk.Action openAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TextView textview1;
	private global::Gtk.HSeparator hseparator2;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
		w1.Add (this.saveAction, null);
		this.saveAsAction = new global::Gtk.Action ("saveAsAction", global::Mono.Unix.Catalog.GetString ("Save As"), null, "gtk-save-as");
		this.saveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save As");
		w1.Add (this.saveAsAction, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Open"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open");
		w1.Add (this.openAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='saveAction' action='saveAction'/><menuitem name='saveAsAction' action='saveAsAction'/><menuitem name='openAction' action='openAction'/><menuitem name='quitAction' action='quitAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add (this.textview1);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w4.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator ();
		this.hseparator2.Name = "hseparator2";
		this.vbox1.Add (this.hseparator2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator2]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.saveAction.Activated += new global::System.EventHandler (this.save);
		this.saveAsAction.Activated += new global::System.EventHandler (this.save_as);
		this.openAction.Activated += new global::System.EventHandler (this.open);
		this.quitAction.Activated += new global::System.EventHandler (this.exit);
	}
}
