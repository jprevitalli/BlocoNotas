using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocoNotas
{
    public partial class TelaBloco : Form
    {
        public TelaBloco()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxCentral.Rtf = string.Empty;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBoxCentral.Rtf = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Arquivos RTF|*.rtf";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                richTextBoxCentral.Rtf = leitor.ReadToEnd();
                leitor.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar arquivo";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "Arquivos RTF|*.rtf";
            
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(richTextBoxCentral.Rtf);
                gravar.Close();  
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar arquivo";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "Arquivos RTF|*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(richTextBoxCentral.Rtf);
                gravar.Close();
            }

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (richTextBoxCentral.SelectedText == "")
            {
                MessageBox.Show("Selecione um texto!");
            }
            else
            {
                Clipboard.SetText(richTextBoxCentral.SelectedText);
                richTextBoxCentral.SelectedText = "";
            }

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBoxCentral.SelectedText == "")
            {
                MessageBox.Show("Selecione um texto!");
            }
            else
            {
                Clipboard.SetText(richTextBoxCentral.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxCentral.SelectedText == "")
            {
                MessageBox.Show("Copie um texto!");
            }
            else
            {
                richTextBoxCentral.SelectedText = Clipboard.GetText();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxCentral.SelectAll();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == (DialogResult.OK))
            {
                richTextBoxCentral.SelectionFont = fontDialog1.Font;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == (DialogResult.OK))
            {
                richTextBoxCentral.SelectionColor = colorDialog1.Color;
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.PerformClick();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.PerformClick();
        }
    }
}
