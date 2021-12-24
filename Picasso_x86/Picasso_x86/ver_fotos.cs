//nós te amamos...
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
namespace Picasso
{
	public class ver_fotos : Form
	{
		//private IContainer components;

		private string morcego_smart_foto_load = "";

		public PictureBox p;

		
		protected int  disable_picture_resize_event        =     0;
		protected bool show_caption                        = true ;
		protected bool is_adjusting                        = false;
		protected static bool disable_event_while_running  = false;
		protected bool is_starting                         = true ;
		private System.Windows.Forms.Timer time_3_32;
		private System.ComponentModel.IContainer components;
		
		public ver_fotos(string morcego_smart_foto_load_in)
		{
			this.morcego_smart_foto_load = morcego_smart_foto_load_in;
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.p = new System.Windows.Forms.PictureBox();
			this.time_3_32 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
			this.SuspendLayout();
			// 
			// p
			// 
			this.p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p.Location = new System.Drawing.Point(31, 22);
			this.p.Name = "p";
			this.p.Size = new System.Drawing.Size(768, 542);
			this.p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.p.TabIndex = 0;
			this.p.TabStop = false;
			this.p.Click += new System.EventHandler(this.PClick);
			this.p.Resize += new System.EventHandler(this.pictureBox1_Resize);
			// 
			// time_3_32
			// 
			this.time_3_32.Tick += new System.EventHandler(this.Time_3_32Tick);
			// 
			// ver_fotos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.p);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "ver_fotos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Click to hide";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ver_fotosFormClosing);
			this.Load += new System.EventHandler(this.morcego_show_fotos);
			this.Resize += new System.EventHandler(this.Ver_fotosResize);
			((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		protected Bitmap image_convert_k_p(string filename_k_p)
		{
			int num_k_p;
			int width_k_p;
			int height_k_p;
			Screen myScreen = Screen.FromPoint(Cursor.Position);
			System.Drawing.Rectangle area = myScreen.WorkingArea;
						
			width_k_p  = area.Width  - 16;
			height_k_p = area.Height - 40;
			
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
			
			//eh aqui...
			
			//if(
			
			if(disable_event_while_running)
			{
				width_k_p  = this.Width;
				num_k_p = Convert.ToInt32((double)width_k_p / (double)image_k_p.Width * (double)image_k_p.Height);
				height_k_p = num_k_p;
				
				if(show_caption)
				{
					this.Height = height_k_p + 40;
				}
				else
				{
					this.Height = height_k_p;
				}
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
					image.Dispose();
				}
				//graphics.Dispose();
			}

			return destImage;
		}
		private void pictureBox1_Resize(object sender, EventArgs e)
		{
			//Environment.Exit(25);
			Rectangle rect_k_p = Screen.PrimaryScreen.WorkingArea;
			
			if(1 < disable_picture_resize_event)
			{
				return;
			}
			
			disable_picture_resize_event++;
			
			try
			{
				
				base.Width = this.p.Width + 3 + 2 + 1 + 10;
				base.Height = this.p.Height + 26 + 2 + 11;
				
			}
			catch
			{
			}
			
			//Divide the screen in half, and find the center of the form to center it
			this.Top = (rect_k_p.Height / 2) - (this.Height / 2);
			this.Left = (rect_k_p.Width / 2) - (this.Width / 2);
			
		}
		void Ver_fotosFormClosing(object sender, FormClosingEventArgs e)
		{
			p.Dispose();
		}
		
		void Esposa_gata_wTextChanged(object sender, EventArgs e)
		{
			is_adjusting = true;
			
			is_adjusting = false;
		}
		void Ver_fotosResize(object sender, EventArgs e)
		{
			if(is_starting)
			{
				return;
			}
			
			if(disable_event_while_running)
			{
				return;
			}
			
			disable_event_while_running = true;
						
			this.p.Top = 0;
			this.p.Left = 0;
			//base.Width = this.p.Width;
			//base.Height = this.p.Height;
						
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
			
			disable_event_while_running = false;
			
		}
		void PClick(object sender, EventArgs e)
		{
			if(show_caption)
			{
				show_caption = false;
				this.FormBorderStyle = FormBorderStyle.None;				
			}
			else
			{
				show_caption = true;
				this.FormBorderStyle = FormBorderStyle.Sizable;
			}
		}
		void Time_3_32Tick(object sender, EventArgs e)
		{
			is_starting = false;
		}
	}
}