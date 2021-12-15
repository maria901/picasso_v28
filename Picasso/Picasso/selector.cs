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

namespace Picasso
{
	
    public partial class selector : Form
    {
    	protected string input_file_k;
        public selector(string input_file_k_)
        {
        	input_file_k = input_file_k_;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alladin eu = new alladin();
            eu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            converter2 eu = new converter2(input_file_k);
            eu.Show();
        }

        private void selector_Load(object sender, EventArgs e)
        {
        	
        	if(0 != input_file_k.Length)
        	{
        		
        	}

        }
    }
}
