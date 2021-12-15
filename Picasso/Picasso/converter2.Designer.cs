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
 
namespace Picasso
{
    partial class converter2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(converter2));
        	this.executor = new System.Windows.Forms.Button();
        	this.label3 = new System.Windows.Forms.Label();
        	this.quality = new System.Windows.Forms.TrackBar();
        	this.output = new System.Windows.Forms.TextBox();
        	this.input = new System.Windows.Forms.TextBox();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.of = new System.Windows.Forms.OpenFileDialog();
        	this.sf = new System.Windows.Forms.SaveFileDialog();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.width = new System.Windows.Forms.TextBox();
        	this.height = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.about = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.ratio = new System.Windows.Forms.CheckBox();
        	this.PNG = new System.Windows.Forms.CheckBox();
        	this.WebP = new System.Windows.Forms.CheckBox();
        	this.visit_BW = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.quality)).BeginInit();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// executor
        	// 
        	this.executor.Location = new System.Drawing.Point(1196, 196);
        	this.executor.Name = "executor";
        	this.executor.Size = new System.Drawing.Size(125, 34);
        	this.executor.TabIndex = 19;
        	this.executor.Text = "Convert";
        	this.executor.UseVisualStyleBackColor = true;
        	this.executor.Click += new System.EventHandler(this.executor_Click);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(1138, 129);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(116, 13);
        	this.label3.TabIndex = 18;
        	this.label3.Text = "Conversion quality 80%";
        	// 
        	// quality
        	// 
        	this.quality.Location = new System.Drawing.Point(1131, 145);
        	this.quality.Maximum = 100;
        	this.quality.Name = "quality";
        	this.quality.Size = new System.Drawing.Size(190, 45);
        	this.quality.TabIndex = 17;
        	this.quality.Value = 80;
        	this.quality.Scroll += new System.EventHandler(this.quality_Scroll);
        	// 
        	// output
        	// 
        	this.output.Location = new System.Drawing.Point(125, 73);
        	this.output.Name = "output";
        	this.output.Size = new System.Drawing.Size(1196, 20);
        	this.output.TabIndex = 16;
        	// 
        	// input
        	// 
        	this.input.Location = new System.Drawing.Point(125, 41);
        	this.input.Name = "input";
        	this.input.Size = new System.Drawing.Size(1196, 20);
        	this.input.TabIndex = 15;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(12, 69);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(107, 26);
        	this.button2.TabIndex = 14;
        	this.button2.Text = "Output";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(12, 38);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(107, 25);
        	this.button1.TabIndex = 13;
        	this.button1.Text = "Input";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// of
        	// 
        	this.of.Filter = "Todos os arquivos |*.*";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(34, 144);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(35, 13);
        	this.label1.TabIndex = 20;
        	this.label1.Text = "Width";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(142, 144);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(38, 13);
        	this.label2.TabIndex = 21;
        	this.label2.Text = "Height";
        	// 
        	// width
        	// 
        	this.width.Location = new System.Drawing.Point(37, 160);
        	this.width.Name = "width";
        	this.width.Size = new System.Drawing.Size(67, 20);
        	this.width.TabIndex = 23;
        	this.width.TextChanged += new System.EventHandler(this.width_TextChanged);
        	// 
        	// height
        	// 
        	this.height.Location = new System.Drawing.Point(145, 160);
        	this.height.Name = "height";
        	this.height.Size = new System.Drawing.Size(67, 20);
        	this.height.TabIndex = 24;
        	this.height.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(34, 196);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(65, 13);
        	this.label5.TabIndex = 25;
        	this.label5.Text = "Adjust value";
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(1333, 24);
        	this.menuStrip1.TabIndex = 26;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
        	this.aboutToolStripMenuItem.Text = "About";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
        	// 
        	// about
        	// 
        	this.about.AutoSize = true;
        	this.about.ForeColor = System.Drawing.Color.Coral;
        	this.about.Location = new System.Drawing.Point(1130, 255);
        	this.about.Name = "about";
        	this.about.Size = new System.Drawing.Size(191, 13);
        	this.about.TabIndex = 27;
        	this.about.Text = "Enhanced by BinaryWork Corp in 2021";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(34, 233);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(219, 13);
        	this.label6.TabIndex = 28;
        	this.label6.Text = "The webp support was provided by Google...";
        	// 
        	// ratio
        	// 
        	this.ratio.AutoSize = true;
        	this.ratio.Checked = true;
        	this.ratio.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.ratio.Location = new System.Drawing.Point(36, 116);
        	this.ratio.Name = "ratio";
        	this.ratio.Size = new System.Drawing.Size(109, 17);
        	this.ratio.TabIndex = 29;
        	this.ratio.Text = "Keep aspect ratio";
        	this.ratio.UseVisualStyleBackColor = true;
        	// 
        	// PNG
        	// 
        	this.PNG.AutoSize = true;
        	this.PNG.Location = new System.Drawing.Point(269, 106);
        	this.PNG.Name = "PNG";
        	this.PNG.Size = new System.Drawing.Size(49, 17);
        	this.PNG.TabIndex = 30;
        	this.PNG.Text = "PNG";
        	this.PNG.UseVisualStyleBackColor = true;
        	this.PNG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PNGMouseUp);
        	// 
        	// WebP
        	// 
        	this.WebP.AutoSize = true;
        	this.WebP.Location = new System.Drawing.Point(340, 106);
        	this.WebP.Name = "WebP";
        	this.WebP.Size = new System.Drawing.Size(56, 17);
        	this.WebP.TabIndex = 31;
        	this.WebP.Text = "WebP";
        	this.WebP.UseVisualStyleBackColor = true;
        	this.WebP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WebPMouseUp);
        	// 
        	// visit_BW
        	// 
        	this.visit_BW.AutoSize = true;
        	this.visit_BW.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.visit_BW.ForeColor = System.Drawing.Color.Navy;
        	this.visit_BW.Location = new System.Drawing.Point(941, 255);
        	this.visit_BW.Name = "visit_BW";
        	this.visit_BW.Size = new System.Drawing.Size(178, 13);
        	this.visit_BW.TabIndex = 32;
        	this.visit_BW.Text = "https://arsoftware.net.br/binarywork";
        	this.visit_BW.Click += new System.EventHandler(this.Visit_BWClick);
        	// 
        	// converter2
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1333, 277);
        	this.Controls.Add(this.visit_BW);
        	this.Controls.Add(this.WebP);
        	this.Controls.Add(this.PNG);
        	this.Controls.Add(this.ratio);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.about);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.height);
        	this.Controls.Add(this.width);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.executor);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.quality);
        	this.Controls.Add(this.output);
        	this.Controls.Add(this.input);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.menuStrip1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "converter2";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Picasso converter";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Converter2FormClosing);
        	this.Load += new System.EventHandler(this.converter2_Load);
        	((System.ComponentModel.ISupportInitialize)(this.quality)).EndInit();
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar quality;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog of;
        private System.Windows.Forms.SaveFileDialog sf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ratio;
        private System.Windows.Forms.CheckBox PNG;
        private System.Windows.Forms.CheckBox WebP;
        private System.Windows.Forms.Label visit_BW;
    }
}