using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class frmParametrizador : Form
    {
        public frmParametrizador()
        {
            InitializeComponent();
        }

        public class Dados
        {
            public string NOME { get; set; }
            public string EVENTO { get; set; }
            public string SORTEADO { get; set; }
        }

        private void gerarModelo()
        {
            try
            {
                //GERAR MODELO
                List<Dados> dadosModelo = new List<Dados>();
                dadosModelo.Add(new Dados { NOME = "NOME", EVENTO = "EVENTO", SORTEADO = "SORT" });
                dadosModelo.Add(new Dados { NOME = "MODELO", EVENTO = "EVENTO", SORTEADO = "N" });

                BindingSource bs = new BindingSource();
                bs.DataSource = dadosModelo;
                dgv.DataSource = dadosModelo;

                //SALVAR ARQUIVO
                SaveFileDialog salvar = new SaveFileDialog();
                Microsoft.Office.Interop.Excel.Application App; //EXCEL
                Microsoft.Office.Interop.Excel.Workbook WorkBook; //PASTA
                Microsoft.Office.Interop.Excel.Worksheet WorkSheet; //PLANILHA
                object misValue = System.Reflection.Missing.Value;

                App = new Microsoft.Office.Interop.Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                //EXPORTAR EXCEL
                for (i = 0; i <= dgv.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgv.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgv[j, i];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                salvar.Title = "Exportar para Excel";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                salvar.ShowDialog();

                string caminho = salvar.FileName;

                WorkBook.SaveAs(caminho, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit();

                MessageBox.Show(null, "O arquivo gerado foi salvo em:" + '\n' + caminho, "Arquivo Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgv.DataSource = null;

            }
            catch (Exception exception)
            {
                MessageBox.Show(null, exception.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarTabela()
        {
            try
            {
                progress.Value = progress.Minimum;
                btSorteio.Enabled = false;
                grSorteio.Visible = false;
                grProgress.Visible = true;
                grProcesso.Text = "Carregar Banco de Dados...";
                wizardPage1.Refresh();

                dgv.DataSource = null;

                if (String.IsNullOrEmpty(txFile.Text))
                {
                    //Carregar Excel
                    OpenFileDialog abreArquivo = new OpenFileDialog();
                    //abreArquivo.Filter = ".xls | Microsoft Excel";
                    abreArquivo.Title = "Selecione o Arquivo";
                    if (abreArquivo.ShowDialog() == DialogResult.OK)
                    {
                        txFile.Text = abreArquivo.FileName;
                    }
                }

                //Preencher Tabela
                DataSet ds = new DataSet();
                OleDbConnection conexao = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                "Data Source=" + txFile.Text + ";" +
                "Extended Properties=Excel 8.0;");
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Plan1$]", conexao);
                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                conexao.Close();
                grSorteio.Text = "Total de Linhas: " + dgv.RowCount.ToString();

                if (dgv.RowCount != 0)
                {
                    
                    progress.Maximum = dgv.RowCount + 1;
                    //LER TABELA
                    int cont = 0;
                    while (cont < dgv.RowCount)
                    {
                        //NOME
                        dgv.Rows[cont].Cells[0].Value = dgv.Rows[cont].Cells[0].Value.ToString().ToUpper();

                        //EVENTO
                        dgv.Rows[cont].Cells[1].Value = dgv.Rows[cont].Cells[1].Value.ToString().ToUpper();

                        //SORT
                        if (String.IsNullOrEmpty(dgv.Rows[cont].Cells[2].Value.ToString()))
                        {
                            dgv.Rows[cont].Cells[2].Value = "N";
                        }

                        cont++;
                        progress.Value = cont;
                    }

                    progress.Value = progress.Maximum;
                    grProgress.Visible = false;
                    grSorteio.Visible = true;
                    btSorteio.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(null, exception.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportarTabela()
        {
            try
            {
                progress.Value = progress.Minimum;
                btSorteio.Enabled = false;
                grSorteio.Visible = false;
                grProgress.Visible = true;
                grProcesso.Text = "Atualizar Banco de Dados...";
                wizardPage1.Refresh();

                List<Dados> dadosModelo = new List<Dados>();
                dadosModelo.Add(new Dados { NOME = "NOME", EVENTO = "EVENTO", SORTEADO = "SORT" });

                int cont = 0;
                while (cont < dgv.RowCount)
                {
                    dadosModelo.Add(new Dados { NOME = dgv.Rows[cont].Cells[0].Value.ToString(), EVENTO = dgv.Rows[cont].Cells[1].Value.ToString(), SORTEADO = dgv.Rows[cont].Cells[2].Value.ToString() });
                    cont++;
                }

                BindingSource bs = new BindingSource();
                bs.DataSource = dadosModelo;
                dgv.DataSource = dadosModelo;

                SaveFileDialog salvar = new SaveFileDialog();
                Microsoft.Office.Interop.Excel.Application App;
                Microsoft.Office.Interop.Excel.Workbook WorkBook;
                Microsoft.Office.Interop.Excel.Worksheet WorkSheet; 
                object misValue = System.Reflection.Missing.Value;

                App = new Microsoft.Office.Interop.Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                progress.Maximum = dgv.RowCount + 1;

                for (i = 0; i <= dgv.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgv.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgv[j, i];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                    progress.Value = i;
                }

                WorkBook.SaveAs(txFile.Text, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit();

                progress.Value = progress.Maximum;

                MessageBox.Show(null, "O arquivo atualizado foi salvo em:" + '\n' + txFile.Text, "Arquivo Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grProgress.Visible = false;
                grSorteio.Visible = true;
                btSorteio.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(null, exception.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btGerarArquivo_Click(object sender, EventArgs e)
        {
            gerarModelo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarTabela();

            button1.Enabled = false;
        }

        private void btSorteio_Click(object sender, EventArgs e)
        {
            frmSorteio sorteio = new frmSorteio(dgv, ckBotao.Checked);
            sorteio.ShowDialog();

            dgv = sorteio.dgvSorteio;

            exportarTabela();
            carregarTabela();           
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            grSorteio.Text = "Total de Linhas: " + dgv.RowCount.ToString();
        }


        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

       
        private void frmParametrizador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txFile.Text != "")
            {
                DialogResult resultado = MessageBox.Show(null, "Deseja salvar o Arquivo de Dados?", "Arquivo de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    exportarTabela();
                }
            }

            Application.Exit();
        }

        private void frmParametrizador_Load(object sender, EventArgs e)
        {

        }        
    }
}
