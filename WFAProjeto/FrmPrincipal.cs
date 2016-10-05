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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmCliente>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE DADOS CLIENTE JÁ ESTÁ ABERTO");
                return;

            }
            else
            {
                frmCliente cliente = new frmCliente();
                cliente.MdiParent = this;
                cliente.Show();
            }         
                  
            
            
            
            
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dadosVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVeiculo>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE DADOS DE VEÍCULO JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmVeiculo Veiculo = new frmVeiculo();
                Veiculo.MdiParent = this;
                Veiculo.Show();
            }
            
           
        }

        private void solicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmReserva>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE DADOS DE RESERVA JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmReserva res = new frmReserva();
                res.MdiParent = this;
                res.Show();
            }
                     
                        
            
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Slbl.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString();
            label1.Top = (this.ClientSize.Height - 22 )- label1.Height ;
           
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmCategoria>().Count() > 0)
            {
                MessageBox.Show("FORMULÁRIO DE DADOS DE CATEGORIA JÁ ESTÁ ABERTO");
                return;

            }
            else
            {

                frmCategoria categoria = new frmCategoria();
                categoria.MdiParent = this;
                categoria.Show();
            }
                     
            
            
            
           
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "S I S T E M A", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 5;
            if(label1.Left >= this.Width){

                label1.Left = label1.Width * -1;
            
            }
            toolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }      


     }
    
}
