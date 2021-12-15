//using LocaçãodeTemporada.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
namespace Photo_Viewer
{
	public class ver_fotos : Form
	{
		//private IContainer components;

		private string morcego_smart_foto_load = "";

		public PictureBox p;

		public ver_fotos(string morcego_smart_foto_load_in)
		{
			this.morcego_smart_foto_load = morcego_smart_foto_load_in;
			this.InitializeComponent();
		}

		public static void pedro_dprintf(int sempre_valido, string data_)
		{
			Console.Write(data_ + "\n");
			return;
		}
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ver_fotos));
			this.p = new PictureBox();
			((ISupportInitialize)this.p).BeginInit();
			base.SuspendLayout();
			this.p.BorderStyle = BorderStyle.Fixed3D;
			this.p.Location = new Point(31, 22);
			this.p.Name = "p";
			this.p.Size = new System.Drawing.Size(768, 542);
			this.p.SizeMode = PictureBoxSizeMode.AutoSize;
			this.p.TabIndex = 0;
			this.p.TabStop = false;
			this.p.Resize += new EventHandler(this.pictureBox1_Resize);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			//this.BackgroundImage = Resources.nvv_0013;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(792, 566);
			base.Controls.Add(this.p);
			this.DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "ver_fotos";
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += new EventHandler(this.morcego_show_fotos);
			((ISupportInitialize)this.p).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		protected static Bitmap image_convert_k_p(string filename_k_p)
		{
			int num_k_p;
			int width_k_p;
			int height_k_p;
			Screen myScreen = Screen.FromPoint(Cursor.Position);
			System.Drawing.Rectangle area = myScreen.WorkingArea;
						
			pedro_dprintf(-1, "w h " + area.Width +
			                   " " + area.Height
			                  );
			width_k_p = area.Width - 16;
			height_k_p = area.Height - 30;
			Image image_k_p = Image.FromFile(filename_k_p);
			
			if (image_k_p.Width > width_k_p || image_k_p.Height > height_k_p)
			{
				while (true)
				{
					num_k_p = Convert.ToInt32((double)width_k_p / (double)image_k_p.Width * (double)image_k_p.Height);
					if (num_k_p <= height_k_p)
					{
						break;
					}
					width_k_p--;
				}
				height_k_p = num_k_p;
			}
			else
			{
				width_k_p = image_k_p.Width;
				height_k_p = image_k_p.Height;
			}
			return ResizeImage_k_p
				(
					image_k_p,
					width_k_p,
					height_k_p
				);
		}
		internal void morcego_show_fotos(object sender, EventArgs e)
		{
			//this.Icon = LocaçãodeTemporada.util.pedro_get_icon();
			this.p.Top = 0;
			this.p.Left = 0;
			base.Width = this.p.Width;
			base.Height = this.p.Height;
			if ("" != this.morcego_smart_foto_load)
			{
				try
				{
					this.p.Image = image_convert_k_p(this.morcego_smart_foto_load);
				}
				catch
				{
				}
			}
		}
		public static Bitmap ResizeImage_k_p(Image image, int width, int height)
		{
			var destRect = new Rectangle(0, 0, width, height);
			var destImage = new Bitmap(width, height);

			destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

			using (var graphics = Graphics.FromImage(destImage))
			{				
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

				using (var wrapMode = new ImageAttributes())
				{
					wrapMode.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width,image.Height, GraphicsUnit.Pixel, wrapMode);
				}
			}

			return destImage;
		}
		private void pictureBox1_Resize(object sender, EventArgs e)
		{
			Rectangle rect_k_p = Screen.PrimaryScreen.WorkingArea;
			
			try
			{
				base.Width = this.p.Width + 3 + 2 + 1 + 10;
				base.Height = this.p.Height + 26 + 2;
			}
			catch
			{
			}
			
			//Divide the screen in half, and find the center of the form to center it
			this.Top = (rect_k_p.Height / 2) - (this.Height / 2);
			this.Left = (rect_k_p.Width / 2) - (this.Width / 2);
			
		}
	}
}