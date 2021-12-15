using LocaçãodeTemporada.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LocaçãodeTemporada
{
	public class fotos : Form
	{
		protected int width_k_p;
		
		protected int height_k_p;
		
		private int arab_counter;

		private string arab_vistoria_a = "";

		private string arab_vistoria_b = "";

		private string arab_vistoria_banheiros = "";

		private string arab_vistoria_cozinhaedespensa = "";

		private string arab_vistoria_garagem = "";

		private string arab_vistoria_lavabo = "";

		private string arab_vistoria_outros = "";

		private string arab_vistoria_quartos = "";

		private string arab_vistoria_sacadas = "";

		private string arab_vistoria_salas = "";

		private OpenFileDialog cd;

		private StringBuilder coluna = new StringBuilder(3000);

		private IContainer components;

		private string controle;

		private StringBuilder data = new StringBuilder(5000000);

		private PictureBox foto1;

		private PictureBox foto10;

		private PictureBox foto2;

		private PictureBox foto3;

		private PictureBox foto4;

		private PictureBox foto5;

		private PictureBox foto6;

		private PictureBox foto7;

		private PictureBox foto8;

		private PictureBox foto9;

		private PictureBox h1;

		private PictureBox h10;

		private PictureBox h2;

		private PictureBox h3;

		private PictureBox h4;

		private PictureBox h5;

		private PictureBox h6;

		private PictureBox h7;

		private PictureBox h8;

		private PictureBox h9;

		private string morcego_and_ok12 = "";

		private PictureBox morcego_anterior_b;

		private PictureBox morcego_finaliza_b;

		private string morcego_foto_1 = "";

		private string morcego_foto_10 = "";

		private string morcego_foto_2 = "";

		private string morcego_foto_3 = "";

		private string morcego_foto_4 = "";

		private string morcego_foto_5 = "";

		private string morcego_foto_6 = "";

		private string morcego_foto_7 = "";

		private string morcego_foto_8 = "";

		private string morcego_foto_9 = "";

		private morcego_ver_ou_editar_fotos morcego_fotos_modo;

		private string morcego_imovel_controle = "";

		private Label morcego_informa_l;

		private StringBuilder sql_message = new StringBuilder(10000);

		private int sqlerror;

		private bool samara_modo_tem_volta_ou_nao;

		public fotos(string morcego_and_ok12_in, string vistoria_quartos, string vistoria_a, string vistoria_b, string vistoria_salas, string vistoria_cozinhaedespensa, string vistoria_banheiros, string vistoria_lavabo, string vistoria_garagem, string vistoria_sacadas, string vistoria_outros, morcego_ver_ou_editar_fotos morcego_fotos_modo_in, string morcego_imovel_controle_in, string controle_, bool samara_modo_tem_volta_ou_nao_in)
		{
			this.controle = controle_;
			this.morcego_imovel_controle = morcego_imovel_controle_in;
			this.morcego_fotos_modo = morcego_fotos_modo_in;
			this.morcego_and_ok12 = morcego_and_ok12_in;
			this.arab_vistoria_quartos = vistoria_quartos;
			this.arab_vistoria_a = vistoria_a;
			this.arab_vistoria_b = vistoria_b;
			this.arab_vistoria_salas = vistoria_salas;
			this.arab_vistoria_cozinhaedespensa = vistoria_cozinhaedespensa;
			this.arab_vistoria_banheiros = vistoria_banheiros;
			this.arab_vistoria_lavabo = vistoria_lavabo;
			this.arab_vistoria_garagem = vistoria_garagem;
			this.arab_vistoria_sacadas = vistoria_sacadas;
			this.arab_vistoria_outros = vistoria_outros;
			this.samara_modo_tem_volta_ou_nao = samara_modo_tem_volta_ou_nao_in;
			this.InitializeComponent();
		}

		private void anterior_arab()
		{
			(new outros(this.morcego_and_ok12, this.arab_vistoria_quartos, this.arab_vistoria_a, this.arab_vistoria_b, this.arab_vistoria_salas, this.arab_vistoria_cozinhaedespensa, this.arab_vistoria_banheiros, this.arab_vistoria_lavabo, this.arab_vistoria_garagem, this.arab_vistoria_sacadas, this.arab_vistoria_outros, this.controle)).Show();
			base.Close();
		}

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int arab_base_64_decode(string data, string output_file);

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int arab_base_64_encode(string input_data, StringBuilder data);

		[DllImport("bucaneiro_mysql.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int arab_getdata(StringBuilder coluna, StringBuilder data);

		[DllImport("bucaneiro_mysql.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int arab_mysql(string ip, string user, string pass, string database, int port, string query, int localizador, int chaveador, fotos.CallBackMysql callback, StringBuilder message, ref int sqlerror);

		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
			try
			{
				util.theform1.WindowState = FormWindowState.Normal;
			}
			catch
			{
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			(new outros(this.morcego_and_ok12, this.arab_vistoria_quartos, this.arab_vistoria_a, this.arab_vistoria_b, this.arab_vistoria_salas, this.arab_vistoria_cozinhaedespensa, this.arab_vistoria_banheiros, this.arab_vistoria_lavabo, this.arab_vistoria_garagem, this.arab_vistoria_sacadas, this.arab_vistoria_outros, this.controle)).Show();
			base.Close();
		}

		public int callback(int val, int registro)
		{
			return 0;
		}

		private int callback2(int value)
		{
			return 0;
		}
		internal string the_controle_k_p;
		private int callback3(int value)
		{
			if (1 == value)
			{
				fotos.arab_getdata(this.coluna, this.data);
				
				if (this.coluna.ToString() == "controle")
				{
					the_controle_k_p = this.data.ToString();
					return 0;
				}
				
				if (this.coluna.ToString() == "foto1")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto1.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto2")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto2.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto3")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto3.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto4")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto4.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto5")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto5.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto6")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto6.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto7")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto7.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto8")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto8.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto9")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto9.jpg"));
					return 0;
				}
				if (this.coluna.ToString() == "foto10")
				{
					fotos.arab_base_64_decode(this.data.ToString(), string.Concat(util.pictures, "foto10.jpg"));
					return 0;
				}
			}
			return 0;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		public void dprintf(string data)
		{
		}

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int e_makedir(string path);

		private void finalizar_arab()
		{
			base.Close();
			try
			{
				util.theform1.WindowState = FormWindowState.Normal;
			}
			catch
			{
			}
		}

		private void foto1_Click(object sender, EventArgs e)
		{
			this.pictureBox1_DoubleClick(null, null);
		}

		private void foto1_Resize(object sender, EventArgs e)
		{
			this.foto1.Left = this.h1.Left;
			PictureBox left = this.foto1;
			left.Left = left.Left + (80 - this.foto1.Width) / 2;
		}

		private void foto10_Click(object sender, EventArgs e)
		{
			this.pictureBox10_DoubleClick(null, null);
		}

		private void foto10_Resize(object sender, EventArgs e)
		{
			this.foto10.Left = this.h10.Left;
			PictureBox left = this.foto10;
			left.Left = left.Left + (80 - this.foto10.Width) / 2;
		}

		private void foto2_Click(object sender, EventArgs e)
		{
			this.pictureBox2_DoubleClick(null, null);
		}

		private void foto2_Resize(object sender, EventArgs e)
		{
			this.foto2.Left = this.h2.Left;
			PictureBox left = this.foto2;
			left.Left = left.Left + (80 - this.foto2.Width) / 2;
		}

		private void foto3_Click(object sender, EventArgs e)
		{
			this.pictureBox3_DoubleClick(null, null);
		}

		private void foto4_Click(object sender, EventArgs e)
		{
			this.pictureBox4_DoubleClick(null, null);
		}

		private void foto4_Resize(object sender, EventArgs e)
		{
			this.foto4.Left = this.h4.Left;
			PictureBox left = this.foto4;
			left.Left = left.Left + (80 - this.foto4.Width) / 2;
		}

		private void foto5_Click(object sender, EventArgs e)
		{
			this.pictureBox5_DoubleClick(null, null);
		}

		private void foto6_Click(object sender, EventArgs e)
		{
			this.pictureBox6_DoubleClick(null, null);
		}

		private void foto6_Resize(object sender, EventArgs e)
		{
			this.foto6.Left = this.h6.Left;
			PictureBox left = this.foto6;
			left.Left = left.Left + (80 - this.foto6.Width) / 2;
		}

		private void foto7_Click(object sender, EventArgs e)
		{
			this.pictureBox7_DoubleClick(null, null);
		}

		private void foto7_Resize(object sender, EventArgs e)
		{
			this.foto7.Left = this.h7.Left;
			PictureBox left = this.foto7;
			left.Left = left.Left + (80 - this.foto7.Width) / 2;
		}

		private void foto8_Click(object sender, EventArgs e)
		{
			this.pictureBox8_DoubleClick(null, null);
		}

		private void foto8_Resize(object sender, EventArgs e)
		{
			this.foto8.Left = this.h8.Left;
			PictureBox left = this.foto8;
			left.Left = left.Left + (80 - this.foto8.Width) / 2;
		}

		private void foto9_Click(object sender, EventArgs e)
		{
			this.pictureBox9_DoubleClick(null, null);
		}

		private void foto9_Resize(object sender, EventArgs e)
		{
			this.foto9.Left = this.h9.Left;
			PictureBox left = this.foto9;
			left.Left = left.Left + (80 - this.foto9.Width) / 2;
		}

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int get_md5_file(string file, StringBuilder md5);

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int get_soc_time();

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fotos));
			this.cd = new OpenFileDialog();
			this.foto10 = new PictureBox();
			this.foto9 = new PictureBox();
			this.foto8 = new PictureBox();
			this.foto7 = new PictureBox();
			this.foto6 = new PictureBox();
			this.foto5 = new PictureBox();
			this.foto4 = new PictureBox();
			this.foto3 = new PictureBox();
			this.foto2 = new PictureBox();
			this.foto1 = new PictureBox();
			this.morcego_informa_l = new Label();
			this.morcego_finaliza_b = new PictureBox();
			this.morcego_anterior_b = new PictureBox();
			this.h1 = new PictureBox();
			this.h2 = new PictureBox();
			this.h3 = new PictureBox();
			this.h4 = new PictureBox();
			this.h5 = new PictureBox();
			this.h6 = new PictureBox();
			this.h7 = new PictureBox();
			this.h8 = new PictureBox();
			this.h9 = new PictureBox();
			this.h10 = new PictureBox();
			((ISupportInitialize)this.foto10).BeginInit();
			((ISupportInitialize)this.foto9).BeginInit();
			((ISupportInitialize)this.foto8).BeginInit();
			((ISupportInitialize)this.foto7).BeginInit();
			((ISupportInitialize)this.foto6).BeginInit();
			((ISupportInitialize)this.foto5).BeginInit();
			((ISupportInitialize)this.foto4).BeginInit();
			((ISupportInitialize)this.foto3).BeginInit();
			((ISupportInitialize)this.foto2).BeginInit();
			((ISupportInitialize)this.foto1).BeginInit();
			((ISupportInitialize)this.morcego_finaliza_b).BeginInit();
			((ISupportInitialize)this.morcego_anterior_b).BeginInit();
			((ISupportInitialize)this.h1).BeginInit();
			((ISupportInitialize)this.h2).BeginInit();
			((ISupportInitialize)this.h3).BeginInit();
			((ISupportInitialize)this.h4).BeginInit();
			((ISupportInitialize)this.h5).BeginInit();
			((ISupportInitialize)this.h6).BeginInit();
			((ISupportInitialize)this.h7).BeginInit();
			((ISupportInitialize)this.h8).BeginInit();
			((ISupportInitialize)this.h9).BeginInit();
			((ISupportInitialize)this.h10).BeginInit();
			base.SuspendLayout();
			this.cd.Filter = "Arquivos de imagem|*.jpg; *.png; *.gif; *.bmp; *.jpeg|Todos os arquivos |*.*";
			this.foto10.BackColor = Color.White;
			this.foto10.BorderStyle = BorderStyle.Fixed3D;
			this.foto10.Cursor = Cursors.Hand;
			this.foto10.Location = new Point(426, 96);
			this.foto10.Name = "foto10";
			this.foto10.Size = new System.Drawing.Size(80, 60);
			this.foto10.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto10.TabIndex = 12;
			this.foto10.TabStop = false;
			this.foto10.DoubleClick += new EventHandler(this.pictureBox10_DoubleClick);
			this.foto10.Click += new EventHandler(this.foto10_Click);
			this.foto10.Resize += new EventHandler(this.foto10_Resize);
			this.foto9.BackColor = Color.White;
			this.foto9.BorderStyle = BorderStyle.Fixed3D;
			this.foto9.Cursor = Cursors.Hand;
			this.foto9.Location = new Point(324, 96);
			this.foto9.Name = "foto9";
			this.foto9.Size = new System.Drawing.Size(80, 60);
			this.foto9.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto9.TabIndex = 11;
			this.foto9.TabStop = false;
			this.foto9.DoubleClick += new EventHandler(this.pictureBox9_DoubleClick);
			this.foto9.Click += new EventHandler(this.foto9_Click);
			this.foto9.Resize += new EventHandler(this.foto9_Resize);
			this.foto8.BackColor = Color.White;
			this.foto8.BorderStyle = BorderStyle.Fixed3D;
			this.foto8.Cursor = Cursors.Hand;
			this.foto8.Location = new Point(222, 96);
			this.foto8.Name = "foto8";
			this.foto8.Size = new System.Drawing.Size(80, 60);
			this.foto8.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto8.TabIndex = 10;
			this.foto8.TabStop = false;
			this.foto8.DoubleClick += new EventHandler(this.pictureBox8_DoubleClick);
			this.foto8.Click += new EventHandler(this.foto8_Click);
			this.foto8.Resize += new EventHandler(this.foto8_Resize);
			this.foto7.BackColor = Color.White;
			this.foto7.BorderStyle = BorderStyle.Fixed3D;
			this.foto7.Cursor = Cursors.Hand;
			this.foto7.Location = new Point(120, 96);
			this.foto7.Name = "foto7";
			this.foto7.Size = new System.Drawing.Size(80, 60);
			this.foto7.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto7.TabIndex = 9;
			this.foto7.TabStop = false;
			this.foto7.DoubleClick += new EventHandler(this.pictureBox7_DoubleClick);
			this.foto7.Click += new EventHandler(this.foto7_Click);
			this.foto7.Resize += new EventHandler(this.foto7_Resize);
			this.foto6.BackColor = Color.White;
			this.foto6.BorderStyle = BorderStyle.Fixed3D;
			this.foto6.Cursor = Cursors.Hand;
			this.foto6.Location = new Point(17, 96);
			this.foto6.Name = "foto6";
			this.foto6.Size = new System.Drawing.Size(80, 60);
			this.foto6.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto6.TabIndex = 8;
			this.foto6.TabStop = false;
			this.foto6.DoubleClick += new EventHandler(this.pictureBox6_DoubleClick);
			this.foto6.Click += new EventHandler(this.foto6_Click);
			this.foto6.Resize += new EventHandler(this.foto6_Resize);
			this.foto5.BackColor = Color.White;
			this.foto5.BorderStyle = BorderStyle.Fixed3D;
			this.foto5.Cursor = Cursors.Hand;
			this.foto5.Location = new Point(426, 26);
			this.foto5.Name = "foto5";
			this.foto5.Size = new System.Drawing.Size(80, 60);
			this.foto5.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto5.TabIndex = 7;
			this.foto5.TabStop = false;
			this.foto5.DoubleClick += new EventHandler(this.pictureBox5_DoubleClick);
			this.foto5.Click += new EventHandler(this.foto5_Click);
			this.foto5.Resize += new EventHandler(this.pictureBox5_Resize);
			this.foto4.BackColor = Color.White;
			this.foto4.BorderStyle = BorderStyle.Fixed3D;
			this.foto4.Cursor = Cursors.Hand;
			this.foto4.Location = new Point(324, 25);
			this.foto4.Name = "foto4";
			this.foto4.Size = new System.Drawing.Size(80, 60);
			this.foto4.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto4.TabIndex = 6;
			this.foto4.TabStop = false;
			this.foto4.DoubleClick += new EventHandler(this.pictureBox4_DoubleClick);
			this.foto4.Click += new EventHandler(this.foto4_Click);
			this.foto4.Resize += new EventHandler(this.foto4_Resize);
			this.foto3.BackColor = Color.White;
			this.foto3.BorderStyle = BorderStyle.Fixed3D;
			this.foto3.Cursor = Cursors.Hand;
			this.foto3.Location = new Point(222, 26);
			this.foto3.Name = "foto3";
			this.foto3.Size = new System.Drawing.Size(80, 60);
			this.foto3.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto3.TabIndex = 5;
			this.foto3.TabStop = false;
			this.foto3.DoubleClick += new EventHandler(this.pictureBox3_DoubleClick);
			this.foto3.Click += new EventHandler(this.foto3_Click);
			this.foto3.Resize += new EventHandler(this.pictureBox3_Resize);
			this.foto2.BackColor = Color.White;
			this.foto2.BorderStyle = BorderStyle.Fixed3D;
			this.foto2.Cursor = Cursors.Hand;
			this.foto2.Location = new Point(120, 26);
			this.foto2.Name = "foto2";
			this.foto2.Size = new System.Drawing.Size(80, 60);
			this.foto2.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto2.TabIndex = 4;
			this.foto2.TabStop = false;
			this.foto2.DoubleClick += new EventHandler(this.pictureBox2_DoubleClick);
			this.foto2.Click += new EventHandler(this.foto2_Click);
			this.foto2.Resize += new EventHandler(this.foto2_Resize);
			this.foto1.BackColor = Color.White;
			this.foto1.BorderStyle = BorderStyle.Fixed3D;
			this.foto1.Cursor = Cursors.Hand;
			this.foto1.Location = new Point(17, 26);
			this.foto1.Name = "foto1";
			this.foto1.Size = new System.Drawing.Size(80, 60);
			this.foto1.SizeMode = PictureBoxSizeMode.AutoSize;
			this.foto1.TabIndex = 3;
			this.foto1.TabStop = false;
			this.foto1.DoubleClick += new EventHandler(this.pictureBox1_DoubleClick);
			this.foto1.Click += new EventHandler(this.foto1_Click);
			this.foto1.Resize += new EventHandler(this.foto1_Resize);
			this.morcego_informa_l.AutoSize = true;
			this.morcego_informa_l.BackColor = Color.Transparent;
			this.morcego_informa_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
			this.morcego_informa_l.ForeColor = Color.White;
			this.morcego_informa_l.Location = new Point(14, 9);
			this.morcego_informa_l.Name = "morcego_informa_l";
			this.morcego_informa_l.Size = new System.Drawing.Size(324, 13);
			this.morcego_informa_l.TabIndex = 13;
			this.morcego_informa_l.Text = "Clique na janela selecionada para inserir ou trocar fotos";
			this.morcego_finaliza_b.BackColor = Color.Transparent;
			this.morcego_finaliza_b.BackgroundImageLayout = ImageLayout.Stretch;
			this.morcego_finaliza_b.Cursor = Cursors.Hand;
			this.morcego_finaliza_b.Image = Resources.morcego_finalizar_entrada_de_fotos_v11;
			this.morcego_finaliza_b.Location = new Point(16, 174);
			this.morcego_finaliza_b.Name = "morcego_finaliza_b";
			this.morcego_finaliza_b.Size = new System.Drawing.Size(100, 44);
			this.morcego_finaliza_b.SizeMode = PictureBoxSizeMode.AutoSize;
			this.morcego_finaliza_b.TabIndex = 47;
			this.morcego_finaliza_b.TabStop = false;
			this.morcego_finaliza_b.Click += new EventHandler(this.morcego_finaliza_Click);
			this.morcego_anterior_b.BackColor = Color.Transparent;
			this.morcego_anterior_b.BackgroundImageLayout = ImageLayout.Stretch;
			this.morcego_anterior_b.Cursor = Cursors.Hand;
			this.morcego_anterior_b.Image = Resources.morcego_anterior_largo_v11;
			this.morcego_anterior_b.Location = new Point(407, 174);
			this.morcego_anterior_b.Name = "morcego_anterior_b";
			this.morcego_anterior_b.Size = new System.Drawing.Size(100, 44);
			this.morcego_anterior_b.SizeMode = PictureBoxSizeMode.AutoSize;
			this.morcego_anterior_b.TabIndex = 48;
			this.morcego_anterior_b.TabStop = false;
			this.morcego_anterior_b.Click += new EventHandler(this.morcego_anterior_Click);
			this.h1.BackColor = Color.White;
			this.h1.BorderStyle = BorderStyle.Fixed3D;
			this.h1.Location = new Point(17, 26);
			this.h1.Name = "h1";
			this.h1.Size = new System.Drawing.Size(80, 60);
			this.h1.TabIndex = 49;
			this.h1.TabStop = false;
			this.h1.Visible = false;
			this.h2.Location = new Point(120, 26);
			this.h2.Name = "h2";
			this.h2.Size = new System.Drawing.Size(80, 60);
			this.h2.TabIndex = 50;
			this.h2.TabStop = false;
			this.h2.Visible = false;
			this.h3.Location = new Point(222, 26);
			this.h3.Name = "h3";
			this.h3.Size = new System.Drawing.Size(80, 60);
			this.h3.TabIndex = 51;
			this.h3.TabStop = false;
			this.h3.Visible = false;
			this.h4.Location = new Point(324, 26);
			this.h4.Name = "h4";
			this.h4.Size = new System.Drawing.Size(80, 60);
			this.h4.TabIndex = 52;
			this.h4.TabStop = false;
			this.h4.Visible = false;
			this.h5.Location = new Point(426, 26);
			this.h5.Name = "h5";
			this.h5.Size = new System.Drawing.Size(80, 60);
			this.h5.TabIndex = 53;
			this.h5.TabStop = false;
			this.h5.Visible = false;
			this.h6.Location = new Point(17, 96);
			this.h6.Name = "h6";
			this.h6.Size = new System.Drawing.Size(80, 60);
			this.h6.TabIndex = 54;
			this.h6.TabStop = false;
			this.h6.Visible = false;
			this.h7.Location = new Point(120, 96);
			this.h7.Name = "h7";
			this.h7.Size = new System.Drawing.Size(80, 60);
			this.h7.TabIndex = 55;
			this.h7.TabStop = false;
			this.h7.Visible = false;
			this.h8.Location = new Point(222, 96);
			this.h8.Name = "h8";
			this.h8.Size = new System.Drawing.Size(80, 60);
			this.h8.TabIndex = 56;
			this.h8.TabStop = false;
			this.h8.Visible = false;
			this.h9.Location = new Point(324, 96);
			this.h9.Name = "h9";
			this.h9.Size = new System.Drawing.Size(80, 60);
			this.h9.TabIndex = 57;
			this.h9.TabStop = false;
			this.h9.Visible = false;
			this.h10.Location = new Point(426, 96);
			this.h10.Name = "h10";
			this.h10.Size = new System.Drawing.Size(80, 60);
			this.h10.TabIndex = 58;
			this.h10.TabStop = false;
			this.h10.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Violet;
			this.BackgroundImage = Resources.nvv_0013;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new System.Drawing.Size(523, 233);
			base.Controls.Add(this.morcego_informa_l);
			base.Controls.Add(this.foto10);
			base.Controls.Add(this.foto9);
			base.Controls.Add(this.foto8);
			base.Controls.Add(this.foto7);
			base.Controls.Add(this.foto6);
			base.Controls.Add(this.foto5);
			base.Controls.Add(this.foto4);
			base.Controls.Add(this.foto3);
			base.Controls.Add(this.foto2);
			base.Controls.Add(this.morcego_anterior_b);
			base.Controls.Add(this.morcego_finaliza_b);
			base.Controls.Add(this.foto1);
			base.Controls.Add(this.h1);
			base.Controls.Add(this.h2);
			base.Controls.Add(this.h3);
			base.Controls.Add(this.h4);
			base.Controls.Add(this.h5);
			base.Controls.Add(this.h6);
			base.Controls.Add(this.h7);
			base.Controls.Add(this.h8);
			base.Controls.Add(this.h9);
			base.Controls.Add(this.h10);
			this.DoubleBuffered = true;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "fotos";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Seleção de fotos";
			base.TopMost = true;
			base.Load += new EventHandler(this.morcego_show_fotos);
			((ISupportInitialize)this.foto10).EndInit();
			((ISupportInitialize)this.foto9).EndInit();
			((ISupportInitialize)this.foto8).EndInit();
			((ISupportInitialize)this.foto7).EndInit();
			((ISupportInitialize)this.foto6).EndInit();
			((ISupportInitialize)this.foto5).EndInit();
			((ISupportInitialize)this.foto4).EndInit();
			((ISupportInitialize)this.foto3).EndInit();
			((ISupportInitialize)this.foto2).EndInit();
			((ISupportInitialize)this.foto1).EndInit();
			((ISupportInitialize)this.morcego_finaliza_b).EndInit();
			((ISupportInitialize)this.morcego_anterior_b).EndInit();
			((ISupportInitialize)this.h1).EndInit();
			((ISupportInitialize)this.h2).EndInit();
			((ISupportInitialize)this.h3).EndInit();
			((ISupportInitialize)this.h4).EndInit();
			((ISupportInitialize)this.h5).EndInit();
			((ISupportInitialize)this.h6).EndInit();
			((ISupportInitialize)this.h7).EndInit();
			((ISupportInitialize)this.h8).EndInit();
			((ISupportInitialize)this.h9).EndInit();
			((ISupportInitialize)this.h10).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.anterior_arab();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.finalizar_arab();
		}

		private void morcego_anterior_Click(object sender, EventArgs e)
		{
			this.anterior_arab();
		}

		private void morcego_finaliza_Click(object sender, EventArgs e)
		{
			this.finalizar_arab();
		}

		private void morcego_print_foto(string morcego_foto)
		{
			if ("" != morcego_foto)
			{
				base.TopMost = false;
				(new ver_fotos(morcego_foto)).ShowDialog();
			}
		}

		private void morcego_show_fotos(object sender, EventArgs e)
		{
			Screen myScreen = Screen.FromPoint(Cursor.Position);
			System.Drawing.Rectangle area = myScreen.Bounds ;
			
			util.pedro_dprintf(-1, "w h " + area.Width +
			                   " " + area.Height
			                  );
			
			width_k_p = area.Width;
			height_k_p = area.Height;
						
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				base.Size = new System.Drawing.Size(529, 205);
			}
			str = ("" != this.morcego_imovel_controle ? string.Concat("select * from ci1_imoveis WHERE controle = '", this.morcego_imovel_controle, "';") : string.Concat("select * from ci1_imoveis WHERE ok12_special = '", this.morcego_and_ok12, "';"));
			fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback3);
			if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
			{
				util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
				Environment.Exit(-1);
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto1.jpg"), string.Concat(util.pictures, "foto1b.jpg"), 80, 60, 80);
				//this.foto1.Load(string.Concat(util.pictures, "foto1b.jpg"));
				
				this.foto1.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto1b.jpg")
					);
				
				this.morcego_foto_1 = string.Concat(util.pictures, "foto1.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto2.jpg"), string.Concat(util.pictures, "foto2b.jpg"), 80, 60, 80);
				//this.foto2.Load(string.Concat(util.pictures, "foto2b.jpg"));
				
				this.foto2.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto2b.jpg")
					);
				
				this.morcego_foto_2 = string.Concat(util.pictures, "foto2.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto3.jpg"), string.Concat(util.pictures, "foto3b.jpg"), 80, 60, 80);
				//this.foto3.Load(string.Concat(util.pictures, "foto3b.jpg"));
				
				this.foto3.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto3b.jpg")
					);
				this.morcego_foto_3 = string.Concat(util.pictures, "foto3.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto4.jpg"), string.Concat(util.pictures, "foto4b.jpg"), 80, 60, 80);
				//this.foto4.Load(string.Concat(util.pictures, "foto4b.jpg"));
				
				this.foto4.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto4b.jpg")
					);
				
				this.morcego_foto_4 = string.Concat(util.pictures, "foto4.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto5.jpg"), string.Concat(util.pictures, "foto5b.jpg"), 80, 60, 80);
				//this.foto5.Load(string.Concat(util.pictures, "foto5b.jpg"));
				
				this.foto5.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto5b.jpg")
					);
				
				this.morcego_foto_5 = string.Concat(util.pictures, "foto5.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto6.jpg"), string.Concat(util.pictures, "foto6b.jpg"), 80, 60, 80);
				//this.foto6.Load(string.Concat(util.pictures, "foto6b.jpg"));
				
				this.foto6.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto6b.jpg")
					);
				this.morcego_foto_6 = string.Concat(util.pictures, "foto6.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto7.jpg"), string.Concat(util.pictures, "foto7b.jpg"), 80, 60, 80);
				//this.foto7.Load(string.Concat(util.pictures, "foto7b.jpg"));
				
				this.foto7.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto7b.jpg")
					);
				this.morcego_foto_7 = string.Concat(util.pictures, "foto7.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto8.jpg"), string.Concat(util.pictures, "foto8b.jpg"), 80, 60, 80);
				//this.foto8.Load(string.Concat(util.pictures, "foto8b.jpg"));
				
				this.foto8.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto8b.jpg")
					);
				
				this.morcego_foto_8 = string.Concat(util.pictures, "foto8.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto9.jpg"), string.Concat(util.pictures, "foto9b.jpg"), 80, 60, 80);
				//this.foto9.Load(string.Concat(util.pictures, "foto9b.jpg"));
				
				this.foto9.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto9b.jpg")
					);
				
				this.morcego_foto_9 = string.Concat(util.pictures, "foto9.jpg");
			}
			catch
			{
			}
			try
			{
				JPG_convert_002.microsoft_convert(string.Concat(util.pictures, "foto10.jpg"), string.Concat(util.pictures, "foto10b.jpg"), 80, 60, 80);
				//this.foto10.Load(string.Concat(util.pictures, "foto10b.jpg"));
				
				this.foto10.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto10b.jpg")
					);
				
				this.morcego_foto_10 = string.Concat(util.pictures, "foto10.jpg");
			}
			catch
			{
			}
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_informa_l.Text = "Clique em cada foto para visualizar";
				this.morcego_finaliza_b.Visible = false;
				this.morcego_anterior_b.Visible = false;
			}
			if (!this.samara_modo_tem_volta_ou_nao)
			{
				this.morcego_anterior_b.Visible = false;
			}
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern void OutputDebugString(string lpOutputString);

		[DllImport("rspsql.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int pass_svansa_information(string soc_data, string soc_controle, string ok12_special);

		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			string thumb_file_k_p = util.pictures  + "\\" + the_controle_k_p + "_thumb_file_k_p.jpg";
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				base.TopMost = false;
				this.morcego_print_foto(this.morcego_foto_1);
				return;
			}
			this.arab_counter++;
			string str1 = "foto1.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possível usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				try
				{										
					JPG_convert_002.microsoft_convert
						(
							fileName,
							thumb_file_k_p,
							80,
							60,
							80
						);					
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possível criar o thumbnail\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto1b.jpg"), 80, 60, 80);
					//this.foto1.Load(string.Concat(util.pictures, "foto1b.jpg"));
					
					this.foto1.Image = util.LoadBitmapUnlocked_k_p
						(
							string.Concat(util.pictures, "foto1b.jpg")
						);
					
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto1 = '", stringBuilder.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto1 = '", stringBuilder.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem("Error: " + exception2.Message);
				}
			}
		}

		private void pictureBox10_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_10);
				return;
			}
			this.arab_counter++;
			string str1 = "foto10.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto10b.jpg"), 80, 60, 80);
					//this.foto10.Load(string.Concat(util.pictures, "foto10b.jpg"));
										
				this.foto10.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto10b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto10 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto10 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox2_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_2);
				return;
			}
			this.arab_counter++;
			string str1 = "foto2.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto2b.jpg"), 80, 60, 80);
					//this.foto2.Load(string.Concat(util.pictures, "foto2b.jpg"));
					
				this.foto2.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto2b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto2 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto2 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox3_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_3);
				return;
			}
			this.arab_counter++;
			string str1 = "foto3.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto3b.jpg"), 80, 60, 80);
					//this.foto3.Load(string.Concat(util.pictures, "foto3b.jpg"));
					
				this.foto3.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto3b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto3 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto3 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox3_Resize(object sender, EventArgs e)
		{
			this.foto3.Left = this.h3.Left;
			PictureBox left = this.foto3;
			left.Left = left.Left + (80 - this.foto3.Width) / 2;
		}

		private void pictureBox4_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_4);
				return;
			}
			this.arab_counter++;
			string str1 = "foto4.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto4b.jpg"), 80, 60, 80);
					//this.foto4.Load(string.Concat(util.pictures, "foto4b.jpg"));
					
				this.foto4.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto4b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto4 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto4 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox5_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_5);
				return;
			}
			this.arab_counter++;
			string str1 = "foto5.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto5b.jpg"), 80, 60, 80);
					//this.foto5.Load(string.Concat(util.pictures, "foto5b.jpg"));
					
				this.foto5.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto5b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto5 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto5 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox5_Resize(object sender, EventArgs e)
		{
			this.foto5.Left = this.h5.Left;
			PictureBox left = this.foto5;
			left.Left = left.Left + (80 - this.foto5.Width) / 2;
		}

		private void pictureBox6_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_6);
				return;
			}
			this.arab_counter++;
			string str1 = "foto6.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto6b.jpg"), 80, 60, 80);
					//this.foto6.Load(string.Concat(util.pictures, "foto6b.jpg"));
					
				this.foto6.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto6b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto6 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto6 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox7_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_7);
				return;
			}
			this.arab_counter++;
			string str1 = "foto7.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto7b.jpg"), 80, 60, 80);
					//this.foto7.Load(string.Concat(util.pictures, "foto7b.jpg"));
					
				this.foto7.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto7b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto7 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto7 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox8_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_8);
				return;
			}
			this.arab_counter++;
			string str1 = "foto8.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto8b.jpg"), 80, 60, 80);
					//this.foto8.Load(string.Concat(util.pictures, "foto8b.jpg"));
					
				this.foto8.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto8b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto8 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto8 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		private void pictureBox9_DoubleClick(object sender, EventArgs e)
		{
			string str;
			if (morcego_ver_ou_editar_fotos.morcego_ver == this.morcego_fotos_modo)
			{
				this.morcego_print_foto(this.morcego_foto_9);
				return;
			}
			this.arab_counter++;
			string str1 = "foto9.jpg";
			this.cd.Title = "Selecione a imagem";
			System.Windows.Forms.DialogResult dialogResult = this.cd.ShowDialog();
			string fileName = this.cd.FileName;
			if (dialogResult == System.Windows.Forms.DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder(300);
				StringBuilder stringBuilder1 = new StringBuilder(300);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "_", str1), width_k_p, height_k_p, 80);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					util.morcego_mensagem(string.Concat("Não foi possivel usar este arquivo, tente outro\n\n", exception.Message));
					return;
				}
				string str2 = string.Concat(util.pictures, "_", str1);
				StringBuilder stringBuilder2 = new StringBuilder(5000000);
				fotos.arab_base_64_encode(str2, stringBuilder2);
				try
				{
					JPG_convert_002.microsoft_convert(fileName, string.Concat(util.pictures, "foto9b.jpg"), 80, 60, 80);
					//this.foto9.Load(string.Concat(util.pictures, "foto9b.jpg"));
					
				this.foto9.Image = util.LoadBitmapUnlocked_k_p
					(
						string.Concat(util.pictures, "foto9b.jpg")
					);
				
					if ("" != this.morcego_and_ok12)
					{
						string[] strArrays = new string[] { "UPDATE ci1_imoveis SET foto9 = '", stringBuilder2.ToString(), "' WHERE ok12_special = '", this.morcego_and_ok12, "' ; " };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { "UPDATE ci1_imoveis SET foto9 = '", stringBuilder2.ToString(), "' WHERE controle = '", this.controle, "' ; " };
						str = string.Concat(strArrays1);
					}
					fotos.CallBackMysql callBackMysql = new fotos.CallBackMysql(this.callback2);
					if (fotos.arab_mysql(util.ip, util.user, util.pass, util.database, 3306, str, 1, 2, callBackMysql, this.sql_message, ref this.sqlerror) != 0)
					{
						util.morcego_mensagem(string.Concat("Erro ", this.sqlerror.ToString(), ": ", this.sql_message.ToString()));
						Environment.Exit(-1);
					}
				}
				catch (Exception exception2)
				{
					util.morcego_mensagem(exception2.Message);
				}
			}
		}

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int removepath(string data, StringBuilder _out_);

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int rsp_link(string dest, string src);

		[DllImport("rspsql.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int seletordenome(string item1, string item2, int mode, StringBuilder errormessage, fotos.CallBackPtr enderecodafuncao);

		[DllImport("RSP_SOC.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int strip_filename_and_path(string path, StringBuilder onlypath, StringBuilder onlyfilename);

		public delegate int CallBackMysql(int value);

		public delegate int CallBackPtr(int val, int registro);
	}
}