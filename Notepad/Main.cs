using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Main : Form
    {
        public TextBox campoTexto;

        public Main()
        {
            InitializeComponent();
        }

        #region Novo notepad
        private void mnsNew_Click(object sender, EventArgs e)
        {
            Form newNoteMax = new Main(); 
            newNoteMax.Show(); // Exibe o novo bloco de notas.
        }
        #endregion

        #region Abrir Arquivos
        private void mnsOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openNewFile = new OpenFileDialog();
            openNewFile.Filter = "Arquivos de texto|*.txt";
            openNewFile.Title = "Abrir arquivo de texto";

            if (openNewFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(openNewFile.FileName))
                {
                    txtMain.Text = sr.ReadToEnd();
                }
            }
        }
        #endregion

        #region Salvar Arquivos
        private void mnsSave_Click(object sender, EventArgs e)
        {
            // Configurações básicas
            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Filter = "Arquivos de Texto (*.txt)|*.txt",
                Title = "Salvar Arquivo",
                DefaultExt = "txt"
            };

            // Abrir o saveFile
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Salvar o arquivo do TextBox
                    System.IO.File.WriteAllText(
                        saveFile.FileName, campoTexto.Text);
                    MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar o arqvuio: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
