using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuebrarArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSelecionaArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = @"S:\cobnetarquivos\Private Label\";
            fileDialog.Multiselect = false;
            fileDialog.Title = "Quebra de arquivos REES";
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = fileDialog.FileName;
            }

        }

        private void btnSelecionaDiretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Selecionar o diretório dos arquivos";
            folder.SelectedPath = @"S:\obnetarquivos\Private Label\";
            folder.ShowNewFolderButton = true;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtArquivosQuebrados.Text = folder.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtArquivo.Text) && !string.IsNullOrEmpty(txtArquivosQuebrados.Text) && !string.IsNullOrEmpty(txtQtdLinhas.Text))
            {
                lstProgresso.Items.Clear();

                string file = Path.GetFullPath(txtArquivo.Text);
                
                try
                {
                    string primeira = File.ReadLines(file).First();
                    EscreveProgresso(string.Format("Lendo arquivo: {0}", file));
                    string[] linhas = File.ReadAllLines(file).Skip(1).ToArray();

                    if(linhas.Count() < int.Parse(txtQtdLinhas.Text))
                    {
                        MessageBox.Show("Numero de linhas do arquivo inferior ao numero de linhas/arquivo pretendido");
                        lstProgresso.Items.Clear();
                        txtQtdLinhas.Focus();
                        return;
                    }

                    DivideArquivo(file, primeira, linhas);
                    EscreveProgresso("Fim do processo!");
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }
            else
            {
                MessageBox.Show("Selecionar o arquivo e o local para divisão");
                return;
            }

        }

        private void DivideArquivo(string path, string primeira, string[] linhas)
        {
            
            string file = Path.GetFileNameWithoutExtension(path);
            string caminho = txtArquivosQuebrados.Text;
            int sequencia = 1;
            List<string> novoarquivo = new List<string>();
            int contador = 0;
            EscreveProgresso(string.Format("Quantidade de linhas: {0}", linhas.Count()));
            int resta = linhas.Count();
            foreach (var item in linhas)
            {
                novoarquivo.Add(item);
                contador++;
                resta--;


                if(contador == int.Parse(txtQtdLinhas.Text) - 1)
                {
                    novoarquivo.Insert(0, primeira);
                    EscreveProgresso(string.Format("Gravando arquivo: {0}", file+"_0"+sequencia+".txt"));
                    File.WriteAllLines(string.Format(@"{0}\{1}_0{2}.txt", caminho, file, sequencia), novoarquivo);
                    contador = 0;
                    sequencia++;
                    novoarquivo = new List<string>();
                }
                else if (resta == 0 && contador < int.Parse(txtQtdLinhas.Text) - 1)
                {
                    novoarquivo.Insert(0, primeira);
                    File.WriteAllLines(string.Format(@"{0}\{1}_0{2}.txt", caminho, file, sequencia), novoarquivo);
                    EscreveProgresso(string.Format("Gravando arquivo: {0}", file + "_0" + sequencia + ".txt"));
                }
            }
        }

        private void EscreveProgresso(string texto)
        {
            lstProgresso.Items.Add(string.Format("{0} - {1}", DateTime.Now, texto));
        }

        private void txtArquivo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivosQuebrados.Text) && !string.IsNullOrEmpty(txtArquivo.Text) && !string.IsNullOrEmpty(txtQtdLinhas.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void txtArquivosQuebrados_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivo.Text) && !string.IsNullOrEmpty(txtArquivosQuebrados.Text) && !string.IsNullOrEmpty(txtQtdLinhas.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void txtQtdLinhas_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivo.Text) && !string.IsNullOrEmpty(txtArquivosQuebrados.Text) && !string.IsNullOrEmpty(txtQtdLinhas.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
