using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFAProjeto
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agileLocadoraDataSet);

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agileLocadoraDataSet.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.agileLocadoraDataSet.Categoria);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

            if (cat_CodigoToolStripTextBox.Text.Trim() == "")

                MessageBox.Show("Campo de pesquisa em branco");
            else
            {


                try
                {
                    this.categoriaTableAdapter.FillBy(this.agileLocadoraDataSet.Categoria, cat_CodigoToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
        }
        private void cat_CodigoToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
