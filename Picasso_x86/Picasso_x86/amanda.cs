
 /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  *                                                                                *
  *      Licensa de Cópia (C) <202*>  <Corporação do Trabalho Binário>             *
  *                                                                                *
  *   Este programa é software livre: você pode redistribuir isto e/ou modificar   *
  *   isto sobre os termos do GNU Licensa Geral Pública como publicado pela        *
  *   Fundação de Software Livre, tanto a versão 3 da Licensa, ou                  *
  *   (dependendo da sua opção) qualquer versão posterior.                         *
  *                                                                                *
  *   Este programa é distribuído na esperança que isto vai ser útil,              *
  *   mas SEM QUALQUER GARANTIA; sem até mesmo a implicada garantia de             *
  *   COMERCIALIZAÇÃO ou CABIMENTO PARA UM FIM PARTICULAR.  Veja a                 *
  *   Licensa Geral Pública para mais detalhes.                                    *
  *                                                                                *
  *   Você deve ter recebido uma cópia da LICENSA GERAL PUBLICA                    *
  *       e a GNU Licensa Pública Menor junto com este programa                    *
  *       Se não, veja <http://www.gnu.org/licenses/>.                             *
  *                                                                                *
  *   Suporte: https://arsoftware.net.br/binarywork ____________________           *
  *   Mirrors: https://locacaodiaria.com.br/corporacaodotrabalhobinario/           *
  *             http://nomade.sourceforge.net/binarywork/ ______________            *
  *                                                                                *
  *       e-mails direto dos felizes programadores:                                *
  *       MathMan: arsoftware25@gmail.com  ricardo@arsoftware.net.br               *
  *        Amanda: arsoftware10@gmail.com  amanda@arsoftware.net.br                *
  *                                                                                *
  *       contato imediato(para uma resposta muita rápida) WhatsApp                *
  *       (+55)41 9627 1708 - isto está sempre ligado                              *
  *                                                                                *
  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
 
using System;
using System.Windows.Forms;

namespace Picasso
{
    public partial class alladin : Form
    {
        public alladin()
        {
            InitializeComponent();
        }

        private void executor_Click(object sender, EventArgs e)
        {
            executor.Text = "Working...";

            try
            {
                Alladin_converter.microsoft_convert(input.Text, output.Text, int.Parse(Width_.Text), int.Parse(Height_.Text), quality.Value);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

                executor.Text = "Convert";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = Alladin_converter.name;

            Width_.Items.Add("640");
            Width_.Items.Add("800");
            Width_.Items.Add("1024");

            Width_.Text = "800";

            Height_.Items.Add("480");
            Height_.Items.Add("600");
            Height_.Items.Add("768");

            Height_.Text = "600";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult eu = of.ShowDialog();

            if (eu == DialogResult.OK)
            {
                input.Text = of.FileName;
                output.Text = of.FileName + ".jpg";
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alladin_converter.About();
        }
    }
}
