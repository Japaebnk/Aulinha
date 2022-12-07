using System.Windows.Forms;
using System;
using System.Net.NetworkInformation;
using System.IO;
using System.Resources;

ing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            primeiraMensagem.Visible = false;
        }

        private void botao_Click(object sender, EventArgs e)
        {
            primeiraMensagem.Visible = true;
            primeiraMensagem.Text = "nova mensagem";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void primeiraMensagem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            primeiraMensagem.Visible = true;
            labell.Text = "visto antigo";
        }

        private void botao2_Click(object sender, EventArgs e)
        {

        }
        private void Chega_Click(object sender, EventArgs e)
        {
            primeiraMensagem.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}