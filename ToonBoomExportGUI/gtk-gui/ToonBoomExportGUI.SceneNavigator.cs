
// This file has been generated by the GUI designer. Do not modify.
namespace ToonBoomExportGUI
{
	public partial class SceneNavigator
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView nodeview2;

		private global::Gtk.HButtonBox hbuttonbox2;

		private global::Gtk.Button button70;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ToonBoomExportGUI.SceneNavigator
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ToonBoomExportGUI.SceneNavigator";
			// Container child ToonBoomExportGUI.SceneNavigator.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview2 = new global::Gtk.NodeView();
			this.nodeview2.CanFocus = true;
			this.nodeview2.Name = "nodeview2";
			this.GtkScrolledWindow.Add(this.nodeview2);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button70 = new global::Gtk.Button();
			this.button70.CanFocus = true;
			this.button70.Name = "button70";
			this.button70.UseUnderline = true;
			this.button70.BorderWidth = ((uint)(3));
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.button70.Image = w3;
			this.hbuttonbox2.Add(this.button70);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.button70]));
			w4.Expand = false;
			w4.Fill = false;
			this.vbox2.Add(this.hbuttonbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbuttonbox2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
