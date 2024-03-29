
// This file has been generated by the GUI designer. Do not modify.
namespace Pinta.Gui.Widgets
{
	public partial class AnglePickerWidget
	{
		private global::Gtk.VBox vbox;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label;
		private global::Gtk.HSeparator hseparator;
		private global::Gtk.HBox hbox2;
		private global::Pinta.Gui.Widgets.AnglePickerGraphic anglepickergraphic1;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.SpinButton spin;
		private global::Gtk.Alignment alignment2;
		private global::Gtk.Button button;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Pinta.Gui.Widgets.AnglePickerWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Pinta.Gui.Widgets.AnglePickerWidget";
			// Container child Pinta.Gui.Widgets.AnglePickerWidget.Gtk.Container+ContainerChild
			this.vbox = new global::Gtk.VBox ();
			this.vbox.Name = "vbox";
			this.vbox.Spacing = 6;
			// Container child vbox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label = new global::Gtk.Label ();
			this.label.Name = "label";
			this.label.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.hbox1.Add (this.label);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hseparator = new global::Gtk.HSeparator ();
			this.hseparator.Name = "hseparator";
			this.hbox1.Add (this.hseparator);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hseparator]));
			w2.Position = 1;
			this.vbox.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.anglepickergraphic1 = new AnglePickerGraphic ();
			this.hbox2.Add (this.anglepickergraphic1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.anglepickergraphic1]));
			w4.Position = 0;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0F, 1F, 0F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.spin = new global::Gtk.SpinButton (0, 360, 1);
			this.spin.CanFocus = true;
			this.spin.Name = "spin";
			this.spin.Adjustment.PageIncrement = 10;
			this.spin.ClimbRate = 1;
			this.spin.Numeric = true;
			this.alignment1.Add (this.spin);
			this.hbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment1]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0F, 1F, 0F);
			this.alignment2.Name = "alignment2";
			// Container child alignment2.Gtk.Container+ContainerChild
			this.button = new global::Gtk.Button ();
			this.button.WidthRequest = 28;
			this.button.HeightRequest = 24;
			this.button.CanFocus = true;
			this.button.Name = "button";
			this.button.UseUnderline = true;
			// Container child button.Gtk.Container+ContainerChild
			global::Gtk.Alignment w7 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w8 = new global::Gtk.HBox ();
			w8.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-back", global::Gtk.IconSize.Menu);
			w8.Add (w9);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w11 = new global::Gtk.Label ();
			w8.Add (w11);
			w7.Add (w8);
			this.button.Add (w7);
			this.alignment2.Add (this.button);
			this.hbox2.Add (this.alignment2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment2]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox.Add (this.hbox2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox [this.hbox2]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.Add (this.vbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
