/*   * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * 
001  *                                                                                *
002  *                                                                                *
003  *                                                                                *
004  *      Licensa de Cópia (C) <202*>  <Corporação do Trabalho Binário>             *
005  *                                                                                *
006  *   Este programa é software livre: você pode redistribuir isto e/ou modificar   *
007  *   isto sobre os termos do GNU Licensa Geral Pública como publicado pela        *
008  *   Fundação de Software Livre, tanto a versão 3 da Licensa, ou                  *
009  *   (dependendo da sua opção) qualquer versão posterior.                         *
010  *                                                                                *
011  *   Este programa é distribuído na esperança que isto vai ser útil,              *
012  *   mas SEM QUALQUER GARANTIA; sem até mesmo a implicada garantia de             *
013  *   COMERCIALIZAÇÃO ou CABIMENTO PARA UM FIM PARTICULAR.  Veja a                 *
014  *   Licensa Geral Pública para mais detalhes.                                    *
015  *                                                                                *
016  *   Você deve ter recebido uma cópia da LICENSA GERAL PUBLICA                    *
017  *       e a GNU Licensa Pública Menor junto com este programa                    *
018  *       Se não, veja <http://www.gnu.org/licenses/>.                             *
019  *                                                                                *
020  *   Suporte: https://arsoftware.net.br/binarywork _____________                  *
021  *                                                                                *
022  *       e-mails direto dos felizes programadores:                                *
023  *       MathMan: arsoftware25@gmail.com  ricardo@arsoftware.net.br               *
024  *        Amanda: arsoftware10@gmail.com  amanda@arsoftware.net.br                *
025  *                                                                                *
026  *       contato imediato(para uma resposta muita rápida) WhatsApp                *
027  *       (+55)41 9627 1708 - isto está sempre ligado                              *
028  *                                                                                *
029  *                                                                                 *
030  *                                                                                *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * **/

/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *                                                                          *
 *                Copyright (C) <202*>  <BinaryWork Corp.>                  *
 *                                                                          *
 *   This program is free software: you can redistribute it and/or modify   *
 *   it under the terms of the GNU General Public License as published by   *
 *   the  Free  Software  Foundation, either version 3 of the License, or   *
 *   (at your option) any later version.                                    *
 *                                                                          *
 *   This  program  is  distributed  in the hope that it will be useful,    *
 *   but  WITHOUT  ANY WARRANTY;  without  even  the  implied warranty of   *
 *   MERCHANTABILITY  or  FITNESS  FOR  A  PARTICULAR  PURPOSE.   See the   *
 *   GNU General Public License for more details.                           *
 *                                                                          *
 *   You should have received a copy of the GNU GENERAL PUBLIC LICENSE      *
 *       and GNU LESSER GENERAL PUBLIC LICENSE along with this program.     *
 *       If not, see <http://www.gnu.org/licenses/>.                        *
 *                                                                          *
 *   support: https://arsoftware.net.br/binarywork _____________            *
 *                                                                          *
 *       direct programmers e-mails:                                        *
 *       MathMan: arsoftware25@gmail.com  ricardo@arsoftware.net.br         *
 *        Amanda: arsoftware10@gmail.com  amanda@arsoftware.net.br          *
 *                                                                          *
 *       immediate contact(for a very fast answer) WhatsApp                 *
 *       (+55)41 9627 1708 - it is always on                                *
 *                                                                          *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Picasso
{
	public partial class converter2 : Form
	{
		internal string input_file_k;
		public converter2(string input_file_k_)
		{
			input_file_k = input_file_k_;
			InitializeComponent();
		}
		bool already_AVA = false;
		private void converter2_Load(object sender, EventArgs e)
		{
			
			
			FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location);
			
			if(false == already_AVA)
			{
				
				already_AVA = true;
				int old_value_Andreia = this.Width;
				int adjust_Rasera;
				int w_AVA;
				int h_AVA;
				
				w_AVA = Screen.PrimaryScreen.Bounds.Width;
				
				w_AVA -= 115; // basta ajustar pra ficar bom, e a pressa é tua
				
				this.Width = w_AVA;
				
				adjust_Rasera = old_value_Andreia - w_AVA;
				
				//aqui ric
				
				input.Width      -= adjust_Rasera;
				output.Width     -= adjust_Rasera;
				label3.Left      -= adjust_Rasera;
				quality.Left     -= adjust_Rasera;
				executor.Left    -= adjust_Rasera;
				visit_BW.Left    -= adjust_Rasera;
				about.Left       -= adjust_Rasera;
				
				this.Left = (Screen.PrimaryScreen.Bounds.Width - w_AVA) / 2;
				
			}
			
			this.Text = Alladin_converter.name + ", Sample Version: " + myFileVersionInfo.ProductVersion;
			if(0 != input_file_k.Length)//sim ta certo...yes, it is ok
			{
				ar_png_file="";
				
				{
					input.Text = input_file_k;

					int ricardo_returnvalue=Alladin_converter.amanda_ricardo_load_webp_image_file(input.Text, ref ar_png_file, ref ar_png_file_to_delete);
					if(1==ricardo_returnvalue)
					{
						
						return ;

					}
					if(2==ricardo_returnvalue)
					{

						MessageBox.Show ("Unable to create a temporary file in the same path of Picasso.exe");
						return;

					}
					if(4==ricardo_returnvalue)
					{
						ar_png_file=input.Text;//file is not a webp file
					}
					Alladin_converter.dprintf ("Arquivo " + ar_png_file);

					output.Text = input_file_k + ".jpg";
					if (CheckState.Checked == PNG.CheckState)
					{
						output.Text = input_file_k + ".png";
					}
					if (CheckState.Checked == WebP.CheckState)
					{
						output.Text = input_file_k + ".webp";
					}

					of.FileName = input_file_k;
					
					int width1  =0;
					int height1 =0;
					disable    = 1;
					try
					{
						WindowState = FormWindowState.Minimized;
						ver_fotos variavel = new ver_fotos(ar_png_file);
						variavel.ShowDialog();
						WindowState = FormWindowState.Normal;
						
						Alladin_converter.get_image_data(ar_png_file, ref width1, ref height1);
						width.Text = width1.ToString();
						height.Text = height1.ToString();

						a = width1;
						b = height1;
						a = a / b;

						label5.Text =  "Adjust value: " + a.ToString();
					}
					catch (Exception ee)
					{
						MessageBox.Show(ee.Message);
						width.Text = "800";
						height.Text = "600";
					}
					disable = 0;
				}
				
			}
		}
		double a=1.0;
		double b=1.0;
		int disable = 0;

		string ar_png_file="";
		string ar_png_file_to_delete="";
		private void button1_Click(object sender, EventArgs e)
		{
			ar_png_file="";
			DialogResult eu = of.ShowDialog();

			if (eu == DialogResult.OK)
			{
				input.Text = of.FileName;

				int ricardo_returnvalue=Alladin_converter.amanda_ricardo_load_webp_image_file(input.Text, ref ar_png_file, ref ar_png_file_to_delete);
				if(1==ricardo_returnvalue)
				{
					
					return ;

				}
				if(2==ricardo_returnvalue)
				{

					MessageBox.Show ("Unable to create a temporary file in the same path of Picasso.exe");
					return;

				}
				if(4==ricardo_returnvalue)
				{
					ar_png_file=input.Text;//file is not a webp file
				}
				Alladin_converter.dprintf ("Arquivo " + ar_png_file);

				output.Text = of.FileName + ".jpg";
				if (CheckState.Checked == PNG.CheckState)
				{
					output.Text = of.FileName + ".png";
				}
				if (CheckState.Checked == WebP.CheckState)
				{
					output.Text = of.FileName + ".webp";
				}

				int width1  =0;
				int height1 =0;
				disable    = 1;
				try
				{
					WindowState = FormWindowState.Minimized;
					ver_fotos variavel = new ver_fotos(ar_png_file);
					variavel.ShowDialog();
					WindowState = FormWindowState.Normal;
					Alladin_converter.get_image_data(ar_png_file, ref width1, ref height1);
					width.Text = width1.ToString();
					height.Text = height1.ToString();

					a = width1;
					b = height1;
					a = a / b;

					label5.Text =  "Adjust value: " + a.ToString();
				}
				catch (Exception ee)
				{
					MessageBox.Show(ee.Message);
					width.Text = "800";
					height.Text = "600";
				}
				disable = 0;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult eu = sf.ShowDialog();

			if (eu == DialogResult.OK)
			{
				//input.Text = of.FileName;
				output.Text = of.FileName;// +".jpg";
			}
		}

		private void quality_Scroll(object sender, EventArgs e)
		{
			label3.Text = "Conversion quality " + quality.Value + "%";
		}

		private void executor_Click(object sender, EventArgs e)
		{
			int amanda_returnvalue=0;
			executor.Text = "Working...";
			executor.Refresh();
			this.Refresh();
			try
			{
				bool is_ong_alladin=false;
				bool is_webp_amanda=false;
				if(CheckState.Checked ==PNG.CheckState )
				{
					is_ong_alladin=true;
				}
				if(CheckState.Checked ==WebP.CheckState )
				{
					is_webp_amanda=true;
				}

				amanda_returnvalue=Alladin_converter.microsoft_convert2(ar_png_file, output.Text, int.Parse(width.Text), int.Parse(height.Text), quality.Value, is_ong_alladin, is_webp_amanda);
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
			executor.Text = "Convert";
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if (CheckState.Unchecked == ratio.CheckState)
			{
				return;
			}
			if (1 == disable)
			{
				return;
			}
			if ("" == height.Text)
			{
				return;
			}
			double c;
			double d;
			int saida;
			c = double.Parse(height.Text);
			d = c * a;
			saida = Convert.ToInt32(d);
			disable = 1;
			width.Text = saida.ToString();
			disable = 0;
		}

		private void width_TextChanged(object sender, EventArgs e)
		{

			if(CheckState .Unchecked ==ratio.CheckState )
			{
				return;
			}
			if (1 == disable)
			{
				return;
			}
			if ("" == width.Text)
			{
				return;
			}
			double c;
			double d;
			int saida;
			c = double.Parse(width.Text);
			d = c / a;
			saida = Convert.ToInt32(d);
			disable = 1;
			height.Text = saida.ToString();
			disable = 0;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Alladin_converter.About();
		}
		void WebPMouseUp(object sender, MouseEventArgs e)
		{
			if(WebP.Checked == true)
			{

				PNG.Checked = false;
				output.Text = of.FileName + ".webp";

			}
		}
		void PNGMouseUp(object sender, MouseEventArgs e)
		{
			if(PNG.Checked == true)
			{

				WebP.Checked = false;
				output.Text = of.FileName + ".png";

			}
		}
		void Converter2FormClosing(object sender, FormClosingEventArgs e)
		{
			if(""!=ar_png_file_to_delete)
			{

				File.Delete (ar_png_file_to_delete);
				ar_png_file_to_delete="";

			}
		}
		void Visit_BWClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://ARsoftware.net.br/bw");
		}
		
	}
}
