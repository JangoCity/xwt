// 
// ImageCellView.cs
//  
// Author:
//       Lluis Sanchez <lluis@xamarin.com>
// 
// Copyright (c) 2011 Xamarin Inc
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
using Xwt.Drawing;
using System.ComponentModel;
using Xwt.Backends;

namespace Xwt
{
	public sealed class ImageCellView: CellView, IImageCellViewFrontend
	{
		Image image;

		public ImageCellView ()
		{
		}

		public ImageCellView (bool expand) : base (expand)
		{
		}

		public ImageCellView(IDataField<Image> imageField) : this (imageField, false)
		{
		}
		
		public ImageCellView (IDataField<Image> imageField, bool expand) : base (expand)
		{
			ImageField = imageField;
		}

		public ImageCellView (Image image) : this (image, false)
		{
		}
		
		public ImageCellView (Image image, bool expand) : base (expand)
		{
			this.image = image;
		}
		
		public IDataField<Image> ImageField { get; set; }

		[DefaultValue (null)]
		public Image Image {
			get { return GetValue (ImageField, image); }
			set { image = value; }
		}
	}
}

