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
    public partial class frmVeiculo : Form
    {
        public frmVeiculo()
        {
            InitializeComponent();
        }

        private void veiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.veiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agileLocadoraDataSet);

        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agileLocadoraDataSet.Veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.agileLocadoraDataSet.Veiculo);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

            if (vei_CodToolStripTextBox.Text.Trim() == "") MessageBox.Show("Campo de pesquisa em branco");
            else
            {
                try
                {
                    this.veiculoTableAdapter.FillBy(this.agileLocadoraDataSet.Veiculo, ((int)(System.Convert.ChangeType(vei_CodToolStripTextBox.Text, typeof(int)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
