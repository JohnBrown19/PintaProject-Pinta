//
// PlaceholderWindow.cs
//
// Author:
//   Lluis Sanchez Gual
//

//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using Gdk;
using Gtk;

namespace MonoDevelop.Components.Docking
{
	internal class PlaceholderWindow: Gtk.Window
	{
		Cairo.Context redgc;
		uint anim;
		int rx, ry, rw, rh;
		bool allowDocking;
		
		public bool AllowDocking {
			get {
				return allowDocking;
			}
			set {
				allowDocking = value;
			}
		}
		
		public PlaceholderWindow (DockFrame frame): base (Gtk.WindowType.Popup)
		{
			SkipTaskbarHint = true;
			Decorated = false;
			TransientFor = (Gtk.Window) frame.Toplevel;
			TypeHint = WindowTypeHint.Utility;
			
			// Create the mask for the arrow
			
			Realize ();
//			redgc = new Gdk.GC (GdkWindow);
//	   		redgc.RgbFgColor = frame.Style.Background (StateType.Selected);

			redgc =  new Cairo.Context (this.GdkWindow.CreateSimilarSurface (0, GdkWindow.Width, GdkWindow.Height));
			Gdk.Color col = frame.Style.Background (StateType.Selected);
			redgc.SetSourceRGB (col.Red, col.Green, col.Blue);

		}
		
		void CreateShape (int width, int height)
		{
			Gdk.Color black, white;
			black = new Gdk.Color (0, 0, 0);
			black.Pixel = 1;
			white = new Gdk.Color (255, 255, 255);
			white.Pixel = 0;

			Cairo.Context cr = new Cairo.Context (this.GdkWindow.CreateSimilarSurface (0, width, height));
			cr.SetSourceRGB (255, 255, 255);
			cr.Rectangle (0, 0, width, height);
			cr.SetSourceRGB ( 0, 0, 0);
			cr.Rectangle (0, 0, width - 1, height - 1);
			cr.Rectangle (1, 1, width - 3, height - 3);

//			Gdk.Pixmap pm = new Pixmap (this.GdkWindow, width, height, 1);
//			Gdk.GC gc = new Gdk.GC (pm);
//			gc.Background = white;
//			gc.Foreground = white;
//			pm.DrawRectangle (gc, true, 0, 0, width, height);
//			
//			gc.Foreground = black;
//			pm.DrawRectangle (gc, false, 0, 0, width - 1, height - 1);
//			pm.DrawRectangle (gc, false, 1, 1, width - 3, height - 3);
			
//			this.ShapeCombineMask (pm, 0, 0);
		}
		
		protected override void OnSizeAllocated (Rectangle allocation)
		{
			base.OnSizeAllocated (allocation);
			CreateShape (allocation.Width, allocation.Height);
		}

		protected override bool OnDrawn (Cairo.Context cr)
		{
			base.OnDrawn (cr);
			int w, h;
			this.GetSize (out w, out h);
//			this.Window.DrawRectangle (redgc, false, 0, 0, w-1, h-1);
			cr.Rectangle (0, 0, w-1, h-1);
//			this.Window.DrawRectangle (redgc, false, 1, 1, w-3, h-3);
			cr.Rectangle (1, 1, w-3, h-3);
	  		return true;
		}
		
		public void Relocate (int x, int y, int w, int h, bool animate)
		{
			if (x != rx || y != ry || w != rw || h != rh) {
				Move (x, y);
				Resize (w, h);
				
				rx = x; ry = y; rw = w; rh = h;
				
				if (anim != 0) {
					GLib.Source.Remove (anim);
					anim = 0;
				}
				if (animate && w < 150 && h < 150) {
					int sa = 7;
					Move (rx-sa, ry-sa);
					Resize (rw+sa*2, rh+sa*2);
					anim = GLib.Timeout.Add (10, RunAnimation);
				}
			}
		}
		
		bool RunAnimation ()
		{
			int cx, cy, ch, cw;
			GetSize (out cw, out ch);
			GetPosition	(out cx, out cy);
			
			if (cx != rx) {
				cx++; cy++;
				ch-=2; cw-=2;
				Move (cx, cy);
				Resize (cw, ch);
				return true;
			}
			anim = 0;
			return false;
		}
	}
}
