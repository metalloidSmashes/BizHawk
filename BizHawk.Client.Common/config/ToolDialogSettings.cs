﻿using System.Drawing;

namespace BizHawk.Client.Common
{
	public class ToolDialogSettings
	{
		public ToolDialogSettings()
		{
			SaveWindowPosition = true;
		}

		public int? Wndx { get; set; }
		public int? Wndy { get; set; }
		public int? Width { get; set; }
		public int? Height { get; set; }

		public bool SaveWindowPosition { get; set; }
		public bool TopMost { get; set; }
		public bool FloatingWindow { get; set; }

		public bool UseWindowPosition
		{
			get
			{
				return SaveWindowPosition && Wndx.HasValue && Wndy.HasValue;
			}
		}

		public bool UseWindowSize
		{
			get
			{
				return SaveWindowPosition && Width.HasValue && Height.HasValue;
			}
		}

		public Point WindowPosition
		{
			get
			{
				return new Point(Wndx ?? 0, Wndy ?? 0);
			}
		}

		public Size WindowSize
		{
			get
			{
				return new Size(Width ?? 0, Height ?? 0);
			}
		}
	}
}