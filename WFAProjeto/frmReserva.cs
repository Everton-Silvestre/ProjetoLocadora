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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


            if (valida())
            {
                MessageBox.Show("Campos em branco");
                return;
            }

            if (DTPInicio.Value > DTPTermino.Value)
            {
                MessageBox.Show("Data inicial maior que data final");

            }
            else
            {

                int resp = clienteTableAdapter.FillBy(agileLocadoraDataSet.Cliente, int.Parse(txtClicod.Text), DTPTermino.Value);


                if (resp == 1)
                {
                
                    this.Validate();
                    this.reservaBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.agileLocadoraDataSet);
                    MessageBox.Show("Reserva Salva Com Sucesso", "RESERVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
                else
                {

                    MessageBox.Show("Habilitação inválida, não será possível cadastrar a reserva");
                }



            }


        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
           
            // TODO: esta linha de código carrega dados na tabela 'agileLocadoraDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.agileLocadoraDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'agileLocadoraDataSet.Reserva'. Você pode movê-la ou removê-la conforme necessário.
            this.reservaTableAdapter.Fill(this.agileLocadoraDataSet.Reserva);

        }

        private void res_Clicod_Click(object sender, EventArgs e)
        {

        }

        private bool valida()
        {
            bool bStatus = false; // Se retornar true, há campos em branco
            if (txtClicod.Text == "")
            {
                EPReserva.SetError(txtClicod, "Entre com o código do curso");
                bStatus = true;
            }
            else
                EPReserva.SetError(txtClicod, "");
            if (txtCat.Text == "")
            {
                EPReserva.SetError(txtCat, "Entre com o nome do curso");
                bStatus = true;
            }
            else
                EPReserva.SetError(txtCat, "");


            if (txtCat.Text == "")
            {
                EPReserva.SetError(txtCat, "Entre com o código da Categoria");
                bStatus = true;
            }
            else
                EPReserva.SetError(txtCat, "");


            if (txtResp.Text == "")
            {
                EPReserva.SetError(txtResp, "Entre com o Responsável");
                bStatus = true;
            }
            else
                EPReserva.SetError(txtResp, "");


            if (txtStatus.Text == "")
            {
                EPReserva.SetError(txtStatus, "Entre com o Status");
                bStatus = true;
            }
            else
                EPReserva.SetError(txtStatus, "");

            if (txtRespCNC.Text == "")
            {
                EPReserva.SetError(txtRespCNC, "Complete o Bairro");
                bStatus = true;
            }
            else
                EPReserva.SetError(txtRespCNC, "");

            return bStatus;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            res_DtaDateTimePicker.Value = DateTime.Now;
            DTPInicio.Value = DateTime.Now;
            DTPTermino.Value = DateTime.Now;
            res_Dta_AprDateTimePicker.Value = DateTime.Now;
            res_Dta_CncDateTimePicker.Value = DateTime.Now;
            res_Dta_BxaDateTimePicker.Value = DateTime.Now;
           
            

        }

        private void txtResp_KeyPress(object sender, KeyPressEventArgs e)
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
                txtStatus.Focus();// tecla "Enter" pressionada;
            }
        }

        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
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
                res_Dta_AprDateTimePicker.Focus();// tecla "Enter" pressionada;
            }
        }

        private void txtRespCNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
                 e.KeyChar != 'ã' && e.KeyChar != 'Ã' && e.KeyChar != 'õ' && e.KeyChar != 'Õ' &&
                 e.KeyChar != 'ç' && e.KeyChar != 'Ç' && e.KeyChar != (char)8 && e.KeyChar !=
                 (char)32 && e.KeyChar != (char)13)
            {
                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
      
        }

        private void txtClicod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar !=
          (char)8 && e.KeyChar != (char)13)
            {

                e.KeyChar = (Char)0; // transforma a tecla digitada no carácter nulo
            }
            if (e.KeyChar == (char)13)
            {
                txtCat.Focus();// tecla "Enter" pressionada: os cálculos são executados;
            }
        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
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
                res_DtaDateTimePicker.Focus();// tecla "Enter" pressionada: os cálculos são executados;
            }
        }
                
    }
}
