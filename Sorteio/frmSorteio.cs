using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class frmSorteio : Form
    {
        public DataGridView dgvSorteio = new DataGridView();
        bool botao;

        public frmSorteio(DataGridView PASSdgv, bool PASSbotao)
        {
            InitializeComponent();
            dgvSorteio = PASSdgv;
            botao = PASSbotao;
        }

        int numSorteios = 0;

        private void sortear()
        {
            Random randNum = new Random();
            int numSorteado = randNum.Next(0, dgvSorteio.RowCount);



            if (dgvSorteio.Rows[numSorteado].Cells[2].Value.ToString() == "N")
            {
                //if (txNome.Text != "")
                //{
                //    txAnteriores.Text = numSorteios + ". " + txNome.Text + '\n' + txAnteriores.Text;
                //}

                txEvento.Text = dgvSorteio.Rows[numSorteado].Cells[1].Value.ToString();
                txNome.Text = dgvSorteio.Rows[numSorteado].Cells[0].Value.ToString();
                dgvSorteio.Rows[numSorteado].Cells[2].Value = "S";
                numSorteios++;
                lbSorteios.Text = "Sorteios Realizados: " + numSorteios;

                txAnteriores.Text = numSorteios + ". " + txNome.Text + '\n' + txAnteriores.Text;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sortear();
        }

        private void btSortear_Click(object sender, EventArgs e)
        {
            sortear();
        }

        private void frmSorteio_Load(object sender, EventArgs e)
        {
            btSortear.Visible = botao;
        }

        
    }
}
