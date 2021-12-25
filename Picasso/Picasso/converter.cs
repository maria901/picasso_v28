
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *                                                                              *
 *        Licensa de Cópia (C) <2021>  <Corporação do Trabalho Binário>         *
 *                                                                              *
 *     Este  programa  é software livre: você pode redistribuir isto e/ou       *
 *     modificar  isto sobre os termos do  GNU Licensa Geral Pública como       8
 *     publicado  pela Fundação  de Software  Livre, tanto a versão 3  da       *
 *     Licensa, ou (dependendo da sua opção) qualquer versão posterior.         *
 *                                                                              *
 *     Este  programa é distribuído na  esperança que isto vai  ser útil,       *
 *     mas SEM  QUALQUER GARANTIA; sem  até mesmo a implicada garantia de       *
 *     COMERCIALIZAÇÃO ou CABIMENTO PARA UM FIM PARTICULAR.  Veja a             *
 *     Licensa Geral Pública para mais detalhes.                                *
 *                                                                              *
 *     Você deve ter recebido uma  cópia da LICENSA GERAL PUBLICA e a GNU       *
 *     Licensa Pública Menor junto com este programa                            *
 *     Se não, veja <http://www.gnu.org/licenses/>.                             *
 *                                                                              *
 *     Suporte: https://arsoftware.net.br/binarywork_____________________       *

 *              http: //nomade.sourceforge.net/binarywork_______________/       *
 *                                                                              *
 *     E-mails direto dos felizes programadores:                                *
 *     O Ricardinho :    arsoftware25@gmail.com    ricardo@arsoftware.net.br    *
 *     Little_Amanda:    arsoftware10@gmail.com    amanda.@arsoftware.net.br    *
 *                                                                              *
 *     contato imediato(para uma resposta muita rápida) WhatsApp                *
 *     (+55)41 9627 1708 - isto está sempre ligado (eu acho...)                 *
 *                                                                              *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **/

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.Text;

namespace Picasso
{
	public class Alladin_converter
	{

		public static string my_empty_string_i = "";
		public static string name = Alladin_converter.my_empty_string_i;

		/*
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 *
		 * */
		#if WIN64
		[DllImport("rsp_small_little_dll_64.dll")]
		public static extern void About();
		#else
		[DllImport("rsp_small_little_dll_32.dll")]
		public static extern void About();
		#endif
		/*
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 * 8888888888888888888888888888888888888888888888888888888888
		 *
		 * */
		[DllImport("cwebp_ar.dll")]
		public static extern int cwebp_main_call_ar(string quality_ar, string input_filename_ar, string output_filename_ar);
		
		[DllImport("cwebp_ar.dll")]
		public static extern int
			ControlName(StringBuilder data_i);
		
		[DllImport("dwebp_ar.dll")]
		public static extern int dwebp_main_call_ar(string input_filename_ar, string output_filename_ar);

		/// <summary>
		/// To convert an input AVIF file (ansi for the moment)
		/// to png file, the extension of the output file need to be always
		/// png or it will not generate a png file but a 4ym file
		/// </summary>
		/// <param name="quality_ar">Since the output is always png if the exntension of the
		/// output file is png this value is irrelevant, need to be 100
		/// </param>
		/// <param name="input_filename_ar">the ansi based input AVIF file, cannot be releative as always with
		/// our software</param>
		/// <param name="output_filename_ar">the output png file if the output extension is png</param>
		/// <returns>
		/// 
		/// <br></br>
		/// 2   - JPEG support has not been compiled in ( but you can modify the sources if you want )<br></br>
		/// 3   - Unknown file type (if the output extension is not png it can occur, for the moment only
		/// extension png and y4m are allowed<br></br>
		/// 4   - Input file is not an HEIF/AVIF file (file input need to be always AVIF and for the
		/// moment an ansi path)<br></br>
		/// 5   - Input file is an unsupported HEIF/AVIF file type<br></br>
		/// 6   - Could not create context object<br></br>
		/// 7   - Could not read HEIF/AVIF file<br></br>
		/// 8   - File doesn't contain any images<br></br>
		/// 9   - Could not read HEIF/AVIF image<br></br>
		/// 10  - Input image has undefined bit-depth<br></br>
		/// 11  - Could not decode image<br></br>
		/// 12  - Could not write image<br></br>
		/// 13  - Could not read depth channel<br></br>
		/// 14  - Could not decode depth image<br></br>
		/// 15  - Could not write depth image<br></br>
		/// 16  - Universe will explode in 60 seconds<br></br>
		/// 17  - Could not read auxiliary image<br></br>
		/// 18  - Could not decode auxiliary image<br></br>
		/// 19  - Could not get type of auxiliary image<br></br>
		/// 20  - Could not write auxiliary image<br></br>
		/// 
		/// 101 - Internal error, cannot occur, only if you modify the sources in C++<br></br>
		/// 102 - Internal error, cannot occur, only if you modify the sources in C++<br></br>
		/// </returns>
		[DllImport("heif-convert_v.DLL")]
		public static extern int main_do_ric(string quality_ar, string input_filename_ar, string output_filename_ar);
		/// <summary>
		/// Function despite the name to encode a png file to AVIF
		/// </summary>
		/// <param name="quality_ar">0 to 100, but notice that 100 is not lossless, lossless will be added today (25/dec/2021)</param>
		/// <param name="input_filename_ar">the input file as png, only png allowed for the moment, and at this moment ansi path as you can see in the Pinvoke call</param>
		/// <param name="output_filename_ar">the output AVIF file to create, cannot be relative, and it is ansi for the moment (25/dec/2021)</param>
		/// <returns>
		/// 
		/// 1      - Could not create context object<br></br>
		/// 5      - Invalid quality factor. Must be between 0 and 100<br></br>
		/// 6      - Encoder error<br></br>
		/// 7      - No encoder available (cannot occur)<br></br>
		/// 8      - Internal error (cannot occur)<br></br>
		/// 9      - Input file doesnot have a png extension<br></br>
		/// 10     - Lossless encode requested but lossy enabled (Internal error)<br></br>
		/// 11     - Image only has a size of 1 pixel width or height. Cannot crop to even size<br></br>
		/// 12     - Could not crop image (image need to be cropped sometimes when the requested width or height is
		/// not a multiples of 2<br></br>
		/// 13     - Could not encode HEIF/AVIF file<br></br>
		/// 500    - Unknown encoder ID (internal error, cannot occur)<br></br>
		/// 
		/// </returns>
		[DllImport("heif-enc_v.DLL")]
		public static extern int main_do_ric_encode(string quality_ar, string input_filename_ar, string output_filename_ar);

		[DllImport("kernel32.dll")]
		static extern void OutputDebugString(string lpOutputString);

		public static void dprintf(string data)
		{
			data = data + " _amanda_debug_";

			OutputDebugString(data);
		}

		public static void save_thumbnail(string source_file, string thumb_file, int width, int height)
		{
			System.Drawing.Image pic_tmp;
			pic_tmp = System.Drawing.Image.FromFile(source_file);

			System.Drawing.Image thumb_pic;


			dprintf("**********************************\nwidth " + pic_tmp.Width + " height " + pic_tmp.Height);


			thumb_pic = pic_tmp.GetThumbnailImage(width, height, null, System.IntPtr.Zero);
			thumb_pic.Save(thumb_file);

			pic_tmp.Dispose();
			thumb_pic.Dispose();
		}
		public static int amanda_ricardo_load_webp_image_file(string amanda_infile, ref string png_file, ref string ar_png_file_to_delete__)
		{
			int ret_ar;
			
			string ricardo_outfile="";
			/*
			 * //for historical reasons...
			if(!File.Exists ("dwebp.exe"))
			{
				return 1;
			}
			 */
			//return 0;

			string amanda_filename = Application.StartupPath + "\\" + ".$$$_me_desculpe_mas_minha_esposa_eh_uma_gata_$$$";
			string ricardo_extension=".png";
			int ricardo_counter=0;

			File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);

			while(File.Exists (amanda_filename+ricardo_counter.ToString ()+ricardo_extension))
			{
				File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
				ricardo_counter++;
				File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
				if(10==ricardo_counter)
				{

					return 2;

				}
			}

			ricardo_outfile=amanda_filename+ricardo_counter.ToString ()+ricardo_extension;
			png_file = ricardo_outfile;

			ar_png_file_to_delete__ = ricardo_outfile;
			/*
			process.StartInfo.FileName = @"dwebp.exe";
			process.StartInfo.Arguments = "\"" + amanda_infile  + "\" -o \"" + ricardo_outfile + "\" ";

			Alladin_converter.dprintf("Argumentos: " + process.StartInfo.FileName + " " + process.StartInfo.Arguments);

			//Usage: dwebp in_file [options] [-o out_file]

			//ava_util.ar_dprintf(process.StartInfo.Arguments);

			process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			process.Start();
			process.WaitForExit();
			 */
			Alladin_converter.dprintf("veja " + amanda_infile + " outfile: " + ricardo_outfile);
			ret_ar = dwebp_main_call_ar(amanda_infile,   ricardo_outfile);
			
			if(0 != ret_ar)
			{
				
				
				try
				{
					Alladin_converter.microsoft_convert_to_png(amanda_infile, ricardo_outfile);
					goto continua_ar;
				}
				catch
				{
					MessageBox.Show("Impossible to convert file input file to internal png file");
					return 4;
				}
				
				//return 4;
			}
			continua_ar:;
			return 0;

		}
		
		public static int amanda_ricardo_load_AVIF_image_file(string amanda_infile, ref string png_file, ref string ar_png_file_to_delete__)
		{
			int ret_ar;
			
			string ricardo_outfile="";
			/*
			 * //for historical reasons...
			if(!File.Exists ("dwebp.exe"))
			{
				return 1;
			}
			 */
			//return 0;

			string amanda_filename = Application.StartupPath + "\\" + ".$$$_me_desculpe_mas_minha_esposa_eh_uma_gata_$$$";
			string ricardo_extension=".png";
			int ricardo_counter=0;

			File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);

			while(File.Exists (amanda_filename+ricardo_counter.ToString ()+ricardo_extension))
			{
				File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
				ricardo_counter++;
				File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
				if(10==ricardo_counter)
				{

					return 2;

				}
			}

			ricardo_outfile=amanda_filename+ricardo_counter.ToString ()+ricardo_extension;
			png_file = ricardo_outfile;

			ar_png_file_to_delete__ = ricardo_outfile;
			/*
			process.StartInfo.FileName = @"dwebp.exe";
			process.StartInfo.Arguments = "\"" + amanda_infile  + "\" -o \"" + ricardo_outfile + "\" ";

			Alladin_converter.dprintf("Argumentos: " + process.StartInfo.FileName + " " + process.StartInfo.Arguments);

			//Usage: dwebp in_file [options] [-o out_file]

			//ava_util.ar_dprintf(process.StartInfo.Arguments);

			process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
			process.Start();
			process.WaitForExit();
			 */
			Alladin_converter.dprintf("veja " + amanda_infile + " outfile: " + ricardo_outfile);
			ret_ar = main_do_ric("100", amanda_infile,   ricardo_outfile);
			
			if(0 != ret_ar)
			{
				
				/*
				try
				{
					Alladin_converter.microsoft_convert_to_png(amanda_infile, ricardo_outfile);
					goto continua_ar;
				}
				catch
				{
					MessageBox.Show("Impossible to convert file input file to internal png file");
					return 4;
				}
				 */
				//return 4;
			}
			continua_ar:;
			return ret_ar;

		}
		/// <summary>
		/// minha funcao para pegar tamanho de arquivo
		/// </summary>
		/// <param name="file"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public static void get_image_data(string file, ref int width, ref int height)
		{
			Image mg = Image.FromFile(file);
			width = mg.Width;
			height = mg.Height;
			mg.Dispose();
			mg = null;
		}

		/// <summary>
		/// Função conversora de imagem pronta, a9_7_6
		/// </summary>
		/// <param name="input"></param>
		/// <param name="output"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="quality"></param>
		public static void microsoft_convert(string input, string output, int width, int height, int quality)
		{
			int heightb;
			ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
			ImageCodecInfo codec = null;

			for (int i = 0; i < codecs.Length; i++)
			{
				//Picasso.d
				dprintf ("mime " + codecs[i].MimeType);
				if ("image/jpeg" == codecs[i].MimeType)
				{
					codec = codecs[i];
				}
			}

			Image mg = Image.FromFile(input);

			if ((mg.Width > width) || (mg.Height > height))
			{

			volta:

				heightb = Convert.ToInt32((((double)width) / ((double)mg.Width)) * ((double)mg.Height));

				if ((heightb > height))
				{
					width--;
					goto volta;
				}

				height = heightb;
			}
			else
			{
				width = mg.Width;
				height = mg.Height;
			}

			//dprintf("width " + width + " " + height);

			Size newSize = new Size(width, height);
			//dprintf("width 2 " + width + " " + height);
			Bitmap bp = new Bitmap(newSize.Width, newSize.Height);
			//dprintf("width 3 " + width + " " + height);
			Graphics e = Graphics.FromImage(bp);

			//dprintf("width 4 " + width + " " + height);
			e.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			// e.SmoothingMode = SmoothingMode.HighQuality;
			//e.InterpolationMode = InterpolationMode.HighQualityBicubic;
			e.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

			//dprintf("width 5 " + width + " " + height);
			Rectangle rect = new Rectangle(0, 0, newSize.Width, newSize.Height);
			//Draw the old image on to the new image using the graphics object:
			e.DrawImage(mg, rect, 0, 0, mg.Width, mg.Height, GraphicsUnit.Pixel);

			//dprintf("width 6 " + width + " " + height);

			if (codec != null)
			{

				//string[] test = new string[2];

				System.Drawing.Imaging.Encoder myEncoder =
					System.Drawing.Imaging.Encoder.Quality;

				// Create an EncoderParameters object.
				// An EncoderParameters object has an array of EncoderParameter
				// objects. In this case, there is only one
				// EncoderParameter object in the array.
				EncoderParameters myEncoderParameters = new EncoderParameters(1);

				EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);
				myEncoderParameters.Param[0] = myEncoderParameter;
				//dprintf("width 7 " + width + " " + height);
				bp.Save(output, codec, myEncoderParameters);

				bp.Dispose();
				mg.Dispose();
				/*
            encoderInstance = System.Drawing.Imaging.Encoder.ColorDepth;
            encoderParameterInstance[1] = new EncoderParameter(encoderInstance, 24L);
            encoderParametersInstance.Param[1] = encoderParameterInstance;
				 */
			}

			else
			{
				//dprintf("width 7 b " + width + " " + height);
				bp.Save(output);
				bp.Dispose();
				mg.Dispose();

			}

			/*
			 *
        g.Dispose();
        ms.Close();

			 * */
			//GC.Collect();//to be used

		}
		public static void microsoft_convert_to_png(string input, string output)
		{
			Image mg = Image.FromFile(input);
			mg.Save(output, ImageFormat.Png);
			mg.Dispose();
		}

		public static int microsoft_convert2(string input, string output, int width, int height, int quality, bool alladin_is_png, bool amanda_is_webp, bool is_avif_ric)
		{
			int ret_ar;
			//int heightb;
			ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
			ImageCodecInfo codec = null;
			for (int i = 0; i < codecs.Length; i++)
			{
				if ("image/jpeg" == codecs[i].MimeType)
				{
					codec = codecs[i];
				}
			}

			Image mg = Image.FromFile(input);
			/*
        if ((mg.Width > width) || (mg.Height > height))
        {

        volta:

            heightb = Convert.ToInt32((((double)width) / ((double)mg.Width)) * ((double)mg.Height));

            if ((heightb > height))
            {
                width--;
                goto volta;
            }

            height = heightb;
        }
        else
        {
            width = mg.Width;
            height = mg.Height;
        }
			 */

			dprintf("width " + width + " " + height);

			Size newSize = new Size(width, height);
			//dprintf("width 2 " + width + " " + height);
			Bitmap bp = new Bitmap(newSize.Width, newSize.Height);
			//dprintf("width 3 " + width + " " + height);
			Graphics e = Graphics.FromImage(bp);

			//dprintf("width 4 " + width + " " + height);
			e.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			// e.SmoothingMode = SmoothingMode.HighQuality;
			//e.InterpolationMode = InterpolationMode.HighQualityBicubic;
			e.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

			//dprintf("width 5 " + width + " " + height);
			Rectangle rect = new Rectangle(0, 0, newSize.Width, newSize.Height);
			//Draw the old image on to the new image using the graphics object:
			e.DrawImage(mg, rect, 0, 0, mg.Width, mg.Height, GraphicsUnit.Pixel);

			//dprintf("width 6 " + width + " " + height);

			if (codec != null)
			{

				//string[] test = new string[2];

				System.Drawing.Imaging.Encoder myEncoder =
					System.Drawing.Imaging.Encoder.Quality;

				// Create an EncoderParameters object.
				// An EncoderParameters object has an array of EncoderParameter
				// objects. In this case, there is only one
				// EncoderParameter object in the array.
				EncoderParameters myEncoderParameters = new EncoderParameters(1);

				EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);
				myEncoderParameters.Param[0] = myEncoderParameter;
				//dprintf("width 7 " + width + " " + height);

				if (alladin_is_png)
				{
					bp.Save(output, ImageFormat.Png);
					bp.Dispose();
					mg.Dispose();
				}
				else if (is_avif_ric)
				{
					
					//Process process = new Process();
					mg.Dispose();
					string ricardo_outfile="";
					/*
					if(!File.Exists ("cwebp.exe"))
					{
						return 1;
					}
					 */
					//return 0;

					string amanda_filename = Application.StartupPath + "\\" + ".$$$_2_me_desculpe_mas_minha_esposa_eh_uma_gata_$$$";
					string ricardo_extension=".png";
					int ricardo_counter=0;

					File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);

					while(File.Exists (amanda_filename+ricardo_counter.ToString ()+ricardo_extension))
					{
						File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
						ricardo_counter++;
						File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
						if(10==ricardo_counter)
						{

							return 2;

						}
					}

					ricardo_outfile=amanda_filename+ricardo_counter.ToString ()+ricardo_extension;

					bp.Save(ricardo_outfile, ImageFormat.Png);
					bp.Dispose();
					
					/*
					process.StartInfo.FileName = @"cwebp.exe";
					process.StartInfo.Arguments = "-q "+quality.ToString()+" \"" + ricardo_outfile  + "\" -o \"" + output + "\" ";
					//  cwebp [options] -q quality input.png -o output.webp
					Alladin_converter.dprintf("Argumentos: " + process.StartInfo.FileName + " " + process.StartInfo.Arguments);

					process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
					process.Start();
					process.WaitForExit();
					 */
					ret_ar = main_do_ric_encode(quality.ToString(), ricardo_outfile, output);
					
					File.Delete (ricardo_outfile);

					if(0 != ret_ar)
					{
						MessageBox.Show("Return error from AVIF DLL: " + ret_ar);
						return 4;
					}
				}
				else if (amanda_is_webp)
				{
					//Process process = new Process();
					mg.Dispose();
					string ricardo_outfile="";
					/*
					if(!File.Exists ("cwebp.exe"))
					{
						return 1;
					}
					 */
					//return 0;

					string amanda_filename = Application.StartupPath + "\\" + ".$$$_2_me_desculpe_mas_minha_esposa_eh_uma_gata_$$$";
					string ricardo_extension=".png";
					int ricardo_counter=0;

					File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);

					while(File.Exists (amanda_filename+ricardo_counter.ToString ()+ricardo_extension))
					{
						File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
						ricardo_counter++;
						File.Delete (amanda_filename+ricardo_counter.ToString ()+ricardo_extension);
						if(10==ricardo_counter)
						{

							return 2;

						}
					}

					ricardo_outfile=amanda_filename+ricardo_counter.ToString ()+ricardo_extension;

					bp.Save(ricardo_outfile, ImageFormat.Png);
					bp.Dispose();
					
					/*
					process.StartInfo.FileName = @"cwebp.exe";
					process.StartInfo.Arguments = "-q "+quality.ToString()+" \"" + ricardo_outfile  + "\" -o \"" + output + "\" ";
					//  cwebp [options] -q quality input.png -o output.webp
					Alladin_converter.dprintf("Argumentos: " + process.StartInfo.FileName + " " + process.StartInfo.Arguments);

					process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
					process.Start();
					process.WaitForExit();
					 */
					ret_ar = cwebp_main_call_ar(quality.ToString(), ricardo_outfile, output);
					
					File.Delete (ricardo_outfile);

					if(0 != ret_ar)
					{
						MessageBox.Show("Return error from cwebp DLL: " + ret_ar);
						return 4;
					}

				}
				else
				{
					bp.Save(output, codec, myEncoderParameters);
					bp.Dispose();
					mg.Dispose();
				}




				/*
            encoderInstance = System.Drawing.Imaging.Encoder.ColorDepth;
            encoderParameterInstance[1] = new EncoderParameter(encoderInstance, 24L);
            encoderParametersInstance.Param[1] = encoderParameterInstance;
				 */
			}

			else
			{
				//dprintf("width 7 b " + width + " " + height);
				bp.Save(output);
				bp.Dispose();
				mg.Dispose();

			}

			/*
			 *
        g.Dispose();
        ms.Close();

			 * */
			//GC.Collect();//to be used
			return 0;
		}


		// _input = System.Drawing .Image ();

		private void convert_image(string input_image, string output_image, int mode, int width, int height, System.Drawing.Imaging.ImageFormat formaT)
		{

			/*
			 * Dim MyImage As ImageMyImage = MyImage.FromFile(Path)Dim img As Bitmap = New Bitmap(MyImage, New Size(272, 136))Me.PictureBox1.Image = DirectCast(img, Image)
			 *

         possivel conserto
			 * "The dark side clouds everything. Impossible to see the future is."


			 *
			 * Private Function SizeImage(ByVal img As Bitmap, ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim newBit As New Bitmap(width, Height) 'new blank bitmap
        Dim g As Graphics = Graphics.FromImage(newBit)
        'change interpolation for reduction quality
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(img, 0, 0, width, Height)
        Return newBit
        End Function




			 */
			using (Image img = Image.FromFile(input_image))
			{
				try
				{
					Image newk;
					Size eu;
					eu = img.Size;
					/*
                eu.Width;
                eu.Height;
					 */
					MessageBox.Show("size " + eu.Width + " " + eu.Height);

					// img.Save(output_image, formaT);

					newk = img.GetThumbnailImage(width, (width / eu.Width) * eu.Height, null, IntPtr.Zero);


					if (1 == mode)
					{
						newk.Save(output_image, formaT);
					}
					newk.Dispose();
					return;
				}
				catch (Exception eee)
				{
					MessageBox.Show(eee.Message);
					return;
				}
			}
		}
	}
}
