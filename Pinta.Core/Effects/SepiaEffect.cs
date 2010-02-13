﻿// 
// SepiaEffect.cs
//  
// Author:
//       Jonathan Pobst <monkey@jpobst.com>
// 
// Copyright (c) 2010 Jonathan Pobst
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Cairo;

namespace Pinta.Core
{
	public class SepiaEffect : BaseEffect
	{
		UnaryPixelOp desat = new UnaryPixelOps.Desaturate ();
		UnaryPixelOp level = new UnaryPixelOps.Desaturate ();

		public override string Icon {
			get { return "Menu.Adjustments.Sepia.png"; }
		}

		public override string Text {
			get { return Mono.Unix.Catalog.GetString ("Sepia"); }
		}
		
		public SepiaEffect ()
		{
			desat = new UnaryPixelOps.Desaturate ();
			level = new UnaryPixelOps.Level (
				ColorBgra.Black,
				ColorBgra.White,
				new float[] { 1.2f, 1.0f, 0.8f },
				ColorBgra.Black,
				ColorBgra.White);
		}
		
		public override void RenderEffect (ImageSurface src, ImageSurface dest, Rectangle[] rois)
		{
			desat.Apply (dest, src, rois);
			level.Apply (dest, dest, rois);
		}
	}
}