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
    partial class selector
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selector));
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(135, 64);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(165, 68);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "Convert to width and height limits, support normal image files";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(135, 160);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(165, 69);
        	this.button2.TabIndex = 1;
        	this.button2.Text = "Define width or height, support also webp";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// selector
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(436, 294);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "selector";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Select , please...";
        	this.Load += new System.EventHandler(this.selector_Load);
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}