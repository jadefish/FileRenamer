using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileRenamer
{
	public class FlatStatusStripRenderer : ToolStripRenderer
	{
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			// Prevent any borders from being drawn:
			// base.OnRenderToolStripBorder(e);
		}
	}
}
