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
    public partial class frmCliente : Form
    {


        private bool valida()
        {
            bool bStatus = false; // Se retornar true, há campos em branco
            if (cli_NomeTextBox.Text == "")
            {
                EPRcliente.SetError(cli_NomeTextBox, "Entre com o código do curso");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_NomeTextBox, "");
            
            
            if (cli_End_CEPTextBox.Text.Length < 10)
            {
                EPRcliente.SetError(cli_End_CEPTextBox, "Complete o CEP");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_End_CEPTextBox, "");

            
            if (cli_End_RuaTextBox.Text == "")
            {
                EPRcliente.SetError(cli_End_RuaTextBox, "Complete a RUA");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_End_RuaTextBox, "");
            
            if (cli_End_BaiTextBox.Text == "")
            {
                EPRcliente.SetError(cli_End_BaiTextBox, "Complete o Bairro");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_End_BaiTextBox, "");
            if (cli_End_CidTextBox.Text == "")
            {
                EPRcliente.SetError(cli_End_CidTextBox, "Complete a Cidade");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_End_CidTextBox, "");
            if (cli_End_UFeTextBox.Text == "" || cli_End_UFeTextBox.Text.Length < 2)
            {
                EPRcliente.SetError(cli_End_UFeTextBox, "Complete o UF");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_End_UFeTextBox, "");
            if (cli_FoneTextBox.Text == "" || cli_FoneTextBox.Text.Length < 10)
            {
                EPRcliente.SetError(cli_FoneTextBox, "Complete o telefone");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_FoneTextBox, "");
            if (cli_CPFTextBox.Text == "" || cli_CPFTextBox.Text.Length < 11)
            {
                EPRcliente.SetError(cli_CPFTextBox, "Complete o CPF");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_CPFTextBox, "");

            if (cli_CNHTextBox.Text == "" || cli_CNHTextBox.Text.Length < 20)
            {
                EPRcliente.SetError(cli_CNHTextBox, "Complete a CNH");
                bStatus = true;
            }
            else
                EPRcliente.SetError(cli_CNHTextBox, "");


            return bStatus;
        }






        public frmCliente()
        {
            InitializeComponent();
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agileLocadoraDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.agileLocadoraDataSet.Cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (valida())
            {
                MessageBox.Show("Campos em branco/Incompletos");
                return;
            }
            
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agileLocadoraDataSet);
            MessageBox.Show("Cliente Salvo Com Sucesso", "CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

        }

        private void cli_NomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
                    e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
                    e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar !=
                    (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_End_CEPTextBox.Focus();// tecla "Enter" pressionada;
            }

        }

        private void cli_End_CEPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar !=
            (char)8 && e.KeyChar != (char)13)
            {

                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_End_RuaTextBox.Focus();// tecla "Enter" pressionada: os cálculos são executados;
            }

        }

        private void cli_FoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar !=
           (char)8 && e.KeyChar != (char)13)
            {

                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_Dta_NasDateTimePicker.Focus();// tecla "Enter" pressionada: os cálculos são executados;
            }
        }

        private void cli_CPFTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar !=
           (char)8 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_CNHTextBox.Focus();// tecla "Enter" pressionada: os cálculos são executados;
            }
        }

        private void cli_End_RuaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
                e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
                e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar !=
                (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_End_BaiTextBox.Focus();// tecla "Enter" pressionada;
            }

        }

        private void cli_End_CidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar !=
              (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_End_UFeTextBox.Focus();// tecla "Enter" pressionada;

            }
        }

        private void cli_End_BaiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar !=
              (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_End_CidTextBox.Focus();// tecla "Enter" pressionada;

            }
        }

        private void cli_End_UFeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
              e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar !=
              (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_FoneTextBox.Focus();// tecla "Enter" pressionada;

            }
        }

        private void cli_Dta_NasDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cli_CPFTextBox.Focus();// tecla "Enter" pressionada;

            }
        }

        private void cli_Val_CNHDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cli_NomeTextBox.Focus();// tecla "Enter" pressionada;

            }
        }

        private void cli_CNHTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar !=
          (char)8 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                cli_Val_CNHDateTimePicker.Focus();// tecla "Enter" pressionada: os cálculos são executados;
            }
        }
                     
    }
}
