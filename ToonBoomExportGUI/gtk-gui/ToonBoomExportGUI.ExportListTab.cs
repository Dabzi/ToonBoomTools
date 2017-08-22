
// This file has been generated by the GUI designer. Do not modify.
namespace ToonBoomExportGUI
{
	public partial class ExportListTab
	{
		private global::Gtk.VBox vbox6;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label NameLabel;

		private global::Gtk.Entry ExportListNameEntry;

		private global::Gtk.Button DeleteExportListButton;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label ExportLabel;

		private global::Gtk.Button SelectExportButton;

		private global::Gtk.Entry ExportLocationEntry;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView NodeFileList;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button RemoveButton;

		private global::Gtk.Button ExportSelectedButton;

		private global::Gtk.Label label6;

		private global::Gtk.Entry GlobalArgsTxt;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label8;

		private global::Gtk.Entry PrefixEntry;

		private global::Gtk.Label label9;

		private global::Gtk.Entry SuffixEntry;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBox FormatCombo;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry ResXEntry;

		private global::Gtk.Label label4;

		private global::Gtk.Entry ResYEntry;

		private global::Gtk.ComboBox CropModeCombo;

		private global::Gtk.Label label10;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label5;

		private global::Gtk.CheckButton AllArtButton;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.CheckButton LineArtButton;

		private global::Gtk.CheckButton ColorArtButton;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label12;

		private global::Gtk.Entry PostCommand;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ToonBoomExportGUI.ExportListTab
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ToonBoomExportGUI.ExportListTab";
			// Container child ToonBoomExportGUI.ExportListTab.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.NameLabel = new global::Gtk.Label();
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Name");
			this.hbox5.Add(this.NameLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.NameLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.ExportListNameEntry = new global::Gtk.Entry();
			global::Gtk.Tooltips w2 = new Gtk.Tooltips();
			w2.SetTip(this.ExportListNameEntry, "Rename this Export List.", "Rename this Export List.");
			this.ExportListNameEntry.CanFocus = true;
			this.ExportListNameEntry.Name = "ExportListNameEntry";
			this.ExportListNameEntry.IsEditable = true;
			this.ExportListNameEntry.InvisibleChar = '●';
			this.hbox5.Add(this.ExportListNameEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.ExportListNameEntry]));
			w3.Position = 1;
			// Container child hbox5.Gtk.Box+BoxChild
			this.DeleteExportListButton = new global::Gtk.Button();
			w2.SetTip(this.DeleteExportListButton, "Delete this Export List.", "Delete this Export List.");
			this.DeleteExportListButton.CanFocus = true;
			this.DeleteExportListButton.Name = "DeleteExportListButton";
			this.DeleteExportListButton.UseUnderline = true;
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.DeleteExportListButton.Image = w4;
			this.hbox5.Add(this.DeleteExportListButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.DeleteExportListButton]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox6.Add(this.hbox5);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox5]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ExportLabel = new global::Gtk.Label();
			this.ExportLabel.Name = "ExportLabel";
			this.ExportLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Export to: ");
			this.hbox2.Add(this.ExportLabel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ExportLabel]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.SelectExportButton = new global::Gtk.Button();
			w2.SetTip(this.SelectExportButton, "Select destination folder for output files.", "Select destination folder for output files.");
			this.SelectExportButton.CanFocus = true;
			this.SelectExportButton.Name = "SelectExportButton";
			this.SelectExportButton.UseUnderline = true;
			this.SelectExportButton.Label = global::Mono.Unix.Catalog.GetString("Select Folder...");
			global::Gtk.Image w8 = new global::Gtk.Image();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-open", global::Gtk.IconSize.Menu);
			this.SelectExportButton.Image = w8;
			this.hbox2.Add(this.SelectExportButton);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.SelectExportButton]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ExportLocationEntry = new global::Gtk.Entry();
			this.ExportLocationEntry.CanFocus = true;
			this.ExportLocationEntry.Name = "ExportLocationEntry";
			this.ExportLocationEntry.IsEditable = false;
			this.ExportLocationEntry.InvisibleChar = '●';
			this.hbox2.Add(this.ExportLocationEntry);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ExportLocationEntry]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 2;
			this.vbox6.Add(this.hbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox2]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.NodeFileList = new global::Gtk.NodeView();
			this.NodeFileList.CanFocus = true;
			this.NodeFileList.Name = "NodeFileList";
			this.GtkScrolledWindow.Add(this.NodeFileList);
			this.vbox6.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GtkScrolledWindow]));
			w13.Position = 2;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.RemoveButton = new global::Gtk.Button();
			w2.SetTip(this.RemoveButton, "Remove Selected Files.", "Remove Selected Files.");
			this.RemoveButton.CanFocus = true;
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.UseUnderline = true;
			global::Gtk.Image w14 = new global::Gtk.Image();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.RemoveButton.Image = w14;
			this.hbuttonbox6.Add(this.RemoveButton);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.RemoveButton]));
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.ExportSelectedButton = new global::Gtk.Button();
			w2.SetTip(this.ExportSelectedButton, "Export Selected Files Only.", "Export Selected Files Only.");
			this.ExportSelectedButton.CanFocus = true;
			this.ExportSelectedButton.Name = "ExportSelectedButton";
			this.ExportSelectedButton.UseUnderline = true;
			global::Gtk.Image w16 = new global::Gtk.Image();
			w16.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-execute", global::Gtk.IconSize.Menu);
			this.ExportSelectedButton.Image = w16;
			this.hbuttonbox6.Add(this.ExportSelectedButton);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.ExportSelectedButton]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox6.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbuttonbox6]));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Global Arguments");
			this.vbox6.Add(this.label6);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label6]));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GlobalArgsTxt = new global::Gtk.Entry();
			w2.SetTip(this.GlobalArgsTxt, "Global command line arguments.", "Global command line arguments.");
			this.GlobalArgsTxt.CanFocus = true;
			this.GlobalArgsTxt.Name = "GlobalArgsTxt";
			this.GlobalArgsTxt.IsEditable = true;
			this.GlobalArgsTxt.InvisibleChar = '●';
			this.vbox6.Add(this.GlobalArgsTxt);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GlobalArgsTxt]));
			w20.Position = 5;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Prefix");
			this.hbox3.Add(this.label8);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label8]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.PrefixEntry = new global::Gtk.Entry();
			w2.SetTip(this.PrefixEntry, "Prefix will be attached to all output filenames.", "Prefix will be attached to all output filenames.");
			this.PrefixEntry.CanFocus = true;
			this.PrefixEntry.Name = "PrefixEntry";
			this.PrefixEntry.IsEditable = true;
			this.PrefixEntry.InvisibleChar = '●';
			this.hbox3.Add(this.PrefixEntry);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.PrefixEntry]));
			w22.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Suffix");
			this.hbox3.Add(this.label9);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label9]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.SuffixEntry = new global::Gtk.Entry();
			w2.SetTip(this.SuffixEntry, "Suffix will be attached to all output filenames.", "Suffix will be attached to all output filenames.");
			this.SuffixEntry.CanFocus = true;
			this.SuffixEntry.Name = "SuffixEntry";
			this.SuffixEntry.IsEditable = true;
			this.SuffixEntry.InvisibleChar = '●';
			this.hbox3.Add(this.SuffixEntry);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.SuffixEntry]));
			w24.Position = 3;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Format");
			this.hbox3.Add(this.label1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label1]));
			w25.Position = 4;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.FormatCombo = global::Gtk.ComboBox.NewText();
			this.FormatCombo.AppendText(global::Mono.Unix.Catalog.GetString("PLACEHOLDER"));
			this.FormatCombo.Name = "FormatCombo";
			this.hbox3.Add(this.FormatCombo);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.FormatCombo]));
			w26.Position = 5;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox6.Add(this.hbox3);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox3]));
			w27.Position = 6;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Resolution");
			this.hbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("x");
			this.hbox4.Add(this.label3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label3]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.ResXEntry = new global::Gtk.Entry();
			this.ResXEntry.CanFocus = true;
			this.ResXEntry.Name = "ResXEntry";
			this.ResXEntry.IsEditable = true;
			this.ResXEntry.InvisibleChar = '●';
			this.hbox4.Add(this.ResXEntry);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.ResXEntry]));
			w30.Position = 2;
			w30.Expand = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("y");
			this.hbox4.Add(this.label4);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label4]));
			w31.Position = 3;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.ResYEntry = new global::Gtk.Entry();
			this.ResYEntry.CanFocus = true;
			this.ResYEntry.Name = "ResYEntry";
			this.ResYEntry.IsEditable = true;
			this.ResYEntry.InvisibleChar = '●';
			this.hbox4.Add(this.ResYEntry);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.ResYEntry]));
			w32.Position = 4;
			w32.Expand = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.CropModeCombo = global::Gtk.ComboBox.NewText();
			w2.SetTip(this.CropModeCombo, "Cropping method to be used when file is set to default cropping mode.", "Cropping method to be used when file is set to default cropping mode.");
			this.CropModeCombo.Name = "CropModeCombo";
			this.hbox4.Add(this.CropModeCombo);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.CropModeCombo]));
			w33.PackType = ((global::Gtk.PackType)(1));
			w33.Position = 5;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Default Crop Mode");
			this.hbox4.Add(this.label10);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label10]));
			w34.PackType = ((global::Gtk.PackType)(1));
			w34.Position = 6;
			w34.Expand = false;
			w34.Fill = false;
			this.vbox6.Add(this.hbox4);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox4]));
			w35.Position = 7;
			w35.Expand = false;
			w35.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Export Art Layers");
			this.hbox1.Add(this.label5);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label5]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.AllArtButton = new global::Gtk.CheckButton();
			this.AllArtButton.CanFocus = true;
			this.AllArtButton.Name = "AllArtButton";
			this.AllArtButton.Label = global::Mono.Unix.Catalog.GetString("All");
			this.AllArtButton.Active = true;
			this.AllArtButton.DrawIndicator = true;
			this.AllArtButton.UseUnderline = true;
			this.hbox1.Add(this.AllArtButton);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.AllArtButton]));
			w37.Position = 1;
			w37.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator2]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.LineArtButton = new global::Gtk.CheckButton();
			this.LineArtButton.CanFocus = true;
			this.LineArtButton.Name = "LineArtButton";
			this.LineArtButton.Label = global::Mono.Unix.Catalog.GetString("Line");
			this.LineArtButton.Active = true;
			this.LineArtButton.DrawIndicator = true;
			this.LineArtButton.UseUnderline = true;
			this.hbox1.Add(this.LineArtButton);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.LineArtButton]));
			w39.Position = 3;
			w39.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ColorArtButton = new global::Gtk.CheckButton();
			this.ColorArtButton.CanFocus = true;
			this.ColorArtButton.Name = "ColorArtButton";
			this.ColorArtButton.Label = global::Mono.Unix.Catalog.GetString("Color");
			this.ColorArtButton.Active = true;
			this.ColorArtButton.DrawIndicator = true;
			this.ColorArtButton.UseUnderline = true;
			this.hbox1.Add(this.ColorArtButton);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ColorArtButton]));
			w40.Position = 4;
			w40.Expand = false;
			this.vbox6.Add(this.hbox1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox1]));
			w41.Position = 8;
			w41.Expand = false;
			w41.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Post Command");
			this.hbox6.Add(this.label12);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label12]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.PostCommand = new global::Gtk.Entry();
			w2.SetTip(this.PostCommand, "Command to be run after a build.", "Command to be run after a build.");
			this.PostCommand.CanFocus = true;
			this.PostCommand.Name = "PostCommand";
			this.PostCommand.IsEditable = true;
			this.PostCommand.InvisibleChar = '●';
			this.hbox6.Add(this.PostCommand);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.PostCommand]));
			w43.Position = 1;
			this.vbox6.Add(this.hbox6);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox6]));
			w44.Position = 9;
			w44.Expand = false;
			w44.Fill = false;
			this.Add(this.vbox6);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
