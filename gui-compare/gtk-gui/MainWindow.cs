// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.Action File;
    
    private Gtk.Action quit;
    
    private Gtk.Action Compare;
    
    private Gtk.Action Custom;
    
    private Gtk.Action a;
    
    private Gtk.Action b;
    
    private Gtk.Action View;
    
    private Gtk.ToggleAction ShowMissing;
    
    private Gtk.ToggleAction ShowExtra;
    
    private Gtk.ToggleAction ShowPresent;
    
    private Gtk.ToggleAction ShowErrors;
    
    private Gtk.Action Refresh;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.Toolbar toolbar3;
    
    private Gtk.Notebook notebook1;
    
    private Gtk.ScrolledWindow GtkScrolledWindow;
    
    private Gtk.TreeView tree;
    
    private Gtk.Label label1;
    
    private Gtk.Label label3;
    
    private Gtk.Label label2;
    
    private Gtk.Statusbar statusbar1;
    
    private Gtk.ProgressBar progressbar1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        Gtk.UIManager w1 = new Gtk.UIManager();
        Gtk.ActionGroup w2 = new Gtk.ActionGroup("Default");
        this.File = new Gtk.Action("File", Mono.Unix.Catalog.GetString("_File"), null, null);
        this.File.ShortLabel = Mono.Unix.Catalog.GetString("File");
        w2.Add(this.File, null);
        this.quit = new Gtk.Action("quit", Mono.Unix.Catalog.GetString("_Quit"), null, "gtk-quit");
        this.quit.ShortLabel = Mono.Unix.Catalog.GetString("_Quit");
        w2.Add(this.quit, null);
        this.Compare = new Gtk.Action("Compare", Mono.Unix.Catalog.GetString("_Compare"), null, null);
        this.Compare.ShortLabel = Mono.Unix.Catalog.GetString("Compare");
        w2.Add(this.Compare, null);
        this.Custom = new Gtk.Action("Custom", Mono.Unix.Catalog.GetString("Custom..."), null, null);
        this.Custom.ShortLabel = Mono.Unix.Catalog.GetString("Custom...");
        w2.Add(this.Custom, null);
        this.a = new Gtk.Action("a", Mono.Unix.Catalog.GetString("a"), null, null);
        this.a.ShortLabel = Mono.Unix.Catalog.GetString("a");
        w2.Add(this.a, null);
        this.b = new Gtk.Action("b", Mono.Unix.Catalog.GetString("b"), null, null);
        this.b.ShortLabel = Mono.Unix.Catalog.GetString("b");
        w2.Add(this.b, null);
        this.View = new Gtk.Action("View", Mono.Unix.Catalog.GetString("_View"), null, null);
        this.View.ShortLabel = Mono.Unix.Catalog.GetString("View");
        w2.Add(this.View, null);
        this.ShowMissing = new Gtk.ToggleAction("ShowMissing", Mono.Unix.Catalog.GetString("Show missing"), null, null);
        this.ShowMissing.Active = true;
        this.ShowMissing.ShortLabel = Mono.Unix.Catalog.GetString("Show missing");
        w2.Add(this.ShowMissing, null);
        this.ShowExtra = new Gtk.ToggleAction("ShowExtra", Mono.Unix.Catalog.GetString("Show extra"), null, null);
        this.ShowExtra.Active = true;
        this.ShowExtra.ShortLabel = Mono.Unix.Catalog.GetString("Show extra");
        w2.Add(this.ShowExtra, null);
        this.ShowPresent = new Gtk.ToggleAction("ShowPresent", Mono.Unix.Catalog.GetString("Show present"), null, null);
        this.ShowPresent.Active = true;
        this.ShowPresent.ShortLabel = Mono.Unix.Catalog.GetString("Show present");
        w2.Add(this.ShowPresent, null);
        this.ShowErrors = new Gtk.ToggleAction("ShowErrors", Mono.Unix.Catalog.GetString("Show errors"), null, null);
        this.ShowErrors.Active = true;
        this.ShowErrors.ShortLabel = Mono.Unix.Catalog.GetString("Show errors");
        w2.Add(this.ShowErrors, null);
        this.Refresh = new Gtk.Action("Refresh", Mono.Unix.Catalog.GetString("Refresh"), null, "gtk-refresh");
        this.Refresh.ShortLabel = Mono.Unix.Catalog.GetString("Refresh");
        w2.Add(this.Refresh, "<Control>r");
        w1.InsertActionGroup(w2, 0);
        this.AddAccelGroup(w1.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        w1.AddUiFromString("<ui><menubar name='menubar1'><menu action='File'><menuitem action='quit'/></menu><menu action='Compare'><menuitem action='Custom'/><separator/></menu><menu action='View'><menuitem action='ShowErrors'/><menuitem action='ShowMissing'/><menuitem action='ShowExtra'/><menuitem action='ShowPresent'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(w1.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w3.Position = 0;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        w1.AddUiFromString("<ui><toolbar name='toolbar3'><toolitem action='Refresh'/></toolbar></ui>");
        this.toolbar3 = ((Gtk.Toolbar)(w1.GetWidget("/toolbar3")));
        this.toolbar3.Name = "toolbar3";
        this.toolbar3.ShowArrow = false;
        this.toolbar3.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
        this.vbox1.Add(this.toolbar3);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.toolbar3]));
        w4.Position = 1;
        w4.Expand = false;
        w4.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.notebook1 = new Gtk.Notebook();
        this.notebook1.CanFocus = true;
        this.notebook1.Name = "notebook1";
        this.notebook1.CurrentPage = 1;
        this.notebook1.ShowBorder = false;
        this.notebook1.ShowTabs = false;
        // Container child notebook1.Gtk.Notebook+NotebookChild
        this.GtkScrolledWindow = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow.Name = "GtkScrolledWindow";
        this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
        this.tree = new Gtk.TreeView();
        this.tree.CanFocus = true;
        this.tree.Name = "tree";
        this.tree.HeadersClickable = true;
        this.GtkScrolledWindow.Add(this.tree);
        this.notebook1.Add(this.GtkScrolledWindow);
        // Notebook tab
        this.label1 = new Gtk.Label();
        this.label1.Name = "label1";
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("page1");
        this.notebook1.SetTabLabel(this.GtkScrolledWindow, this.label1);
        this.label1.ShowAll();
        // Container child notebook1.Gtk.Notebook+NotebookChild
        this.label3 = new Gtk.Label();
        this.label3.Name = "label3";
        this.label3.Xpad = 20;
        this.label3.Ypad = 20;
        this.label3.LabelProp = Mono.Unix.Catalog.GetString("This tool allows you to compare the API of assemblies.\n\nTo initiate a comparison, use the \"Compare\" menu and use one of the presets based on the assemblies you  have installed on your system and some popular profiles, or use \"Custom\" to define your own comparison");
        this.label3.Wrap = true;
        this.notebook1.Add(this.label3);
        Gtk.Notebook.NotebookChild w7 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.label3]));
        w7.Position = 1;
        // Notebook tab
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("page2");
        this.notebook1.SetTabLabel(this.label3, this.label2);
        this.label2.ShowAll();
        this.vbox1.Add(this.notebook1);
        Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox1[this.notebook1]));
        w8.Position = 2;
        // Container child vbox1.Gtk.Box+BoxChild
        this.statusbar1 = new Gtk.Statusbar();
        this.statusbar1.Name = "statusbar1";
        this.statusbar1.Spacing = 6;
        // Container child statusbar1.Gtk.Box+BoxChild
        this.progressbar1 = new Gtk.ProgressBar();
        this.progressbar1.Name = "progressbar1";
        this.statusbar1.Add(this.progressbar1);
        Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.statusbar1[this.progressbar1]));
        w9.Position = 2;
        this.vbox1.Add(this.statusbar1);
        Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
        w10.Position = 3;
        w10.Expand = false;
        w10.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 648;
        this.DefaultHeight = 577;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.quit.Activated += new System.EventHandler(this.OnQuitActivated);
        this.ShowMissing.Toggled += new System.EventHandler(this.OnShowMissingToggled);
        this.ShowExtra.Toggled += new System.EventHandler(this.OnShowExtraToggled);
        this.ShowPresent.Toggled += new System.EventHandler(this.OnShowPresentToggled);
        this.ShowErrors.Toggled += new System.EventHandler(this.OnShowErrorsToggled);
        this.Refresh.Activated += new System.EventHandler(this.OnRefreshActivated);
    }
}
