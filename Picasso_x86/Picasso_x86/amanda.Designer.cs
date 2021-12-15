namespace Picasso
{
    partial class alladin
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alladin));
        	this.label1 = new System.Windows.Forms.Label();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.input = new System.Windows.Forms.TextBox();
        	this.output = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.Width_ = new System.Windows.Forms.ComboBox();
        	this.Height_ = new System.Windows.Forms.ComboBox();
        	this.quality = new System.Windows.Forms.TrackBar();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.executor = new System.Windows.Forms.Button();
        	this.of = new System.Windows.Forms.OpenFileDialog();
        	this.sf = new System.Windows.Forms.SaveFileDialog();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.about = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.quality)).BeginInit();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 41);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(298, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "This is an advanced JPG converter technology from Microsoft";
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(11, 78);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(107, 25);
        	this.button1.TabIndex = 1;
        	this.button1.Text = "Input";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(11, 109);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(107, 26);
        	this.button2.TabIndex = 2;
        	this.button2.Text = "Output";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// input
        	// 
        	this.input.Location = new System.Drawing.Point(124, 81);
        	this.input.Name = "input";
        	this.input.Size = new System.Drawing.Size(1196, 20);
        	this.input.TabIndex = 3;
        	// 
        	// output
        	// 
        	this.output.Location = new System.Drawing.Point(124, 113);
        	this.output.Name = "output";
        	this.output.Size = new System.Drawing.Size(1196, 20);
        	this.output.TabIndex = 4;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(22, 150);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(33, 13);
        	this.label2.TabIndex = 5;
        	this.label2.Text = "Limits";
        	// 
        	// Width_
        	// 
        	this.Width_.FormattingEnabled = true;
        	this.Width_.Location = new System.Drawing.Point(18, 190);
        	this.Width_.Name = "Width_";
        	this.Width_.Size = new System.Drawing.Size(89, 21);
        	this.Width_.TabIndex = 6;
        	// 
        	// Height_
        	// 
        	this.Height_.FormattingEnabled = true;
        	this.Height_.Location = new System.Drawing.Point(113, 190);
        	this.Height_.Name = "Height_";
        	this.Height_.Size = new System.Drawing.Size(89, 21);
        	this.Height_.TabIndex = 7;
        	// 
        	// quality
        	// 
        	this.quality.Location = new System.Drawing.Point(1130, 174);
        	this.quality.Maximum = 100;
        	this.quality.Name = "quality";
        	this.quality.Size = new System.Drawing.Size(190, 45);
        	this.quality.TabIndex = 8;
        	this.quality.Value = 80;
        	this.quality.Scroll += new System.EventHandler(this.quality_Scroll);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(1160, 150);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(116, 13);
        	this.label3.TabIndex = 9;
        	this.label3.Text = "Conversion quality 80%";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(22, 174);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(35, 13);
        	this.label4.TabIndex = 10;
        	this.label4.Text = "Width";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(111, 174);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(38, 13);
        	this.label5.TabIndex = 11;
        	this.label5.Text = "Height";
        	// 
        	// executor
        	// 
        	this.executor.Location = new System.Drawing.Point(1195, 236);
        	this.executor.Name = "executor";
        	this.executor.Size = new System.Drawing.Size(125, 34);
        	this.executor.TabIndex = 12;
        	this.executor.Text = "Convert";
        	this.executor.UseVisualStyleBackColor = true;
        	this.executor.Click += new System.EventHandler(this.executor_Click);
        	// 
        	// of
        	// 
        	this.of.Filter = "Arquivos de imagem|*.jpg; *.png; *.gif; *.bmp; *.jpeg|Todos os arquivos |*.*";
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(1333, 24);
        	this.menuStrip1.TabIndex = 13;
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
        	this.about.Location = new System.Drawing.Point(1146, 284);
        	this.about.Name = "about";
        	this.about.Size = new System.Drawing.Size(178, 13);
        	this.about.TabIndex = 28;
        	this.about.Text = "Enhanced by RSP Software in 2021";
        	// 
        	// alladin
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1333, 306);
        	this.Controls.Add(this.about);
        	this.Controls.Add(this.executor);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.quality);
        	this.Controls.Add(this.Height_);
        	this.Controls.Add(this.Width_);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.output);
        	this.Controls.Add(this.input);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.menuStrip1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "alladin";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Load += new System.EventHandler(this.Form1_Load);
        	((System.ComponentModel.ISupportInitialize)(this.quality)).EndInit();
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Width_;
        private System.Windows.Forms.ComboBox Height_;
        private System.Windows.Forms.TrackBar quality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.Button executor;
        private System.Windows.Forms.OpenFileDialog of;
        private System.Windows.Forms.SaveFileDialog sf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label about;
    }
}

