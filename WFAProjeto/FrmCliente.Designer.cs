namespace WFAProjeto
{
    partial class frmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cli_CodLabel;
            System.Windows.Forms.Label cli_NomeLabel;
            System.Windows.Forms.Label cli_End_CEPLabel;
            System.Windows.Forms.Label cli_End_RuaLabel;
            System.Windows.Forms.Label cli_End_BaiLabel;
            System.Windows.Forms.Label cli_End_CidLabel;
            System.Windows.Forms.Label cli_End_UFeLabel;
            System.Windows.Forms.Label cli_FoneLabel;
            System.Windows.Forms.Label cli_Dta_NasLabel;
            System.Windows.Forms.Label cli_CPFLabel;
            System.Windows.Forms.Label cli_CNHLabel;
            System.Windows.Forms.Label cli_Val_CNHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.agileLocadoraDataSet = new WFAProjeto.AgileLocadoraDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new WFAProjeto.AgileLocadoraDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new WFAProjeto.AgileLocadoraDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cli_CodTextBox = new System.Windows.Forms.TextBox();
            this.cli_NomeTextBox = new System.Windows.Forms.TextBox();
            this.cli_End_CEPTextBox = new System.Windows.Forms.TextBox();
            this.cli_End_RuaTextBox = new System.Windows.Forms.TextBox();
            this.cli_End_BaiTextBox = new System.Windows.Forms.TextBox();
            this.cli_End_CidTextBox = new System.Windows.Forms.TextBox();
            this.cli_End_UFeTextBox = new System.Windows.Forms.TextBox();
            this.cli_Dta_NasDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cli_CPFTextBox = new System.Windows.Forms.TextBox();
            this.cli_CNHTextBox = new System.Windows.Forms.TextBox();
            this.cli_Val_CNHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_FoneTextBox = new System.Windows.Forms.TextBox();
            this.EPRcliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            cli_CodLabel = new System.Windows.Forms.Label();
            cli_NomeLabel = new System.Windows.Forms.Label();
            cli_End_CEPLabel = new System.Windows.Forms.Label();
            cli_End_RuaLabel = new System.Windows.Forms.Label();
            cli_End_BaiLabel = new System.Windows.Forms.Label();
            cli_End_CidLabel = new System.Windows.Forms.Label();
            cli_End_UFeLabel = new System.Windows.Forms.Label();
            cli_FoneLabel = new System.Windows.Forms.Label();
            cli_Dta_NasLabel = new System.Windows.Forms.Label();
            cli_CPFLabel = new System.Windows.Forms.Label();
            cli_CNHLabel = new System.Windows.Forms.Label();
            cli_Val_CNHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agileLocadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cli_CodLabel
            // 
            cli_CodLabel.AutoSize = true;
            cli_CodLabel.Location = new System.Drawing.Point(109, 60);
            cli_CodLabel.Name = "cli_CodLabel";
            cli_CodLabel.Size = new System.Drawing.Size(43, 13);
            cli_CodLabel.TabIndex = 2;
            cli_CodLabel.Text = "Código:";
            // 
            // cli_NomeLabel
            // 
            cli_NomeLabel.AutoSize = true;
            cli_NomeLabel.Location = new System.Drawing.Point(109, 86);
            cli_NomeLabel.Name = "cli_NomeLabel";
            cli_NomeLabel.Size = new System.Drawing.Size(38, 13);
            cli_NomeLabel.TabIndex = 4;
            cli_NomeLabel.Text = "Nome:";
            // 
            // cli_End_CEPLabel
            // 
            cli_End_CEPLabel.AutoSize = true;
            cli_End_CEPLabel.Location = new System.Drawing.Point(109, 112);
            cli_End_CEPLabel.Name = "cli_End_CEPLabel";
            cli_End_CEPLabel.Size = new System.Drawing.Size(31, 13);
            cli_End_CEPLabel.TabIndex = 6;
            cli_End_CEPLabel.Text = "CEP:";
            // 
            // cli_End_RuaLabel
            // 
            cli_End_RuaLabel.AutoSize = true;
            cli_End_RuaLabel.Location = new System.Drawing.Point(109, 138);
            cli_End_RuaLabel.Name = "cli_End_RuaLabel";
            cli_End_RuaLabel.Size = new System.Drawing.Size(30, 13);
            cli_End_RuaLabel.TabIndex = 8;
            cli_End_RuaLabel.Text = "Rua:";
            // 
            // cli_End_BaiLabel
            // 
            cli_End_BaiLabel.AutoSize = true;
            cli_End_BaiLabel.Location = new System.Drawing.Point(109, 164);
            cli_End_BaiLabel.Name = "cli_End_BaiLabel";
            cli_End_BaiLabel.Size = new System.Drawing.Size(37, 13);
            cli_End_BaiLabel.TabIndex = 10;
            cli_End_BaiLabel.Text = "Bairro:";
            // 
            // cli_End_CidLabel
            // 
            cli_End_CidLabel.AutoSize = true;
            cli_End_CidLabel.Location = new System.Drawing.Point(109, 190);
            cli_End_CidLabel.Name = "cli_End_CidLabel";
            cli_End_CidLabel.Size = new System.Drawing.Size(43, 13);
            cli_End_CidLabel.TabIndex = 12;
            cli_End_CidLabel.Text = "Cidade:";
            // 
            // cli_End_UFeLabel
            // 
            cli_End_UFeLabel.AutoSize = true;
            cli_End_UFeLabel.Location = new System.Drawing.Point(484, 57);
            cli_End_UFeLabel.Name = "cli_End_UFeLabel";
            cli_End_UFeLabel.Size = new System.Drawing.Size(31, 13);
            cli_End_UFeLabel.TabIndex = 14;
            cli_End_UFeLabel.Text = "UFE:";
            // 
            // cli_FoneLabel
            // 
            cli_FoneLabel.AutoSize = true;
            cli_FoneLabel.Location = new System.Drawing.Point(484, 83);
            cli_FoneLabel.Name = "cli_FoneLabel";
            cli_FoneLabel.Size = new System.Drawing.Size(34, 13);
            cli_FoneLabel.TabIndex = 16;
            cli_FoneLabel.Text = "Fone:";
            // 
            // cli_Dta_NasLabel
            // 
            cli_Dta_NasLabel.AutoSize = true;
            cli_Dta_NasLabel.Location = new System.Drawing.Point(484, 110);
            cli_Dta_NasLabel.Name = "cli_Dta_NasLabel";
            cli_Dta_NasLabel.Size = new System.Drawing.Size(92, 13);
            cli_Dta_NasLabel.TabIndex = 18;
            cli_Dta_NasLabel.Text = "Data Nascimento:";
            // 
            // cli_CPFLabel
            // 
            cli_CPFLabel.AutoSize = true;
            cli_CPFLabel.Location = new System.Drawing.Point(484, 135);
            cli_CPFLabel.Name = "cli_CPFLabel";
            cli_CPFLabel.Size = new System.Drawing.Size(30, 13);
            cli_CPFLabel.TabIndex = 20;
            cli_CPFLabel.Text = "CPF:";
            // 
            // cli_CNHLabel
            // 
            cli_CNHLabel.AutoSize = true;
            cli_CNHLabel.Location = new System.Drawing.Point(484, 161);
            cli_CNHLabel.Name = "cli_CNHLabel";
            cli_CNHLabel.Size = new System.Drawing.Size(33, 13);
            cli_CNHLabel.TabIndex = 22;
            cli_CNHLabel.Text = "CNH:";
            // 
            // cli_Val_CNHLabel
            // 
            cli_Val_CNHLabel.AutoSize = true;
            cli_Val_CNHLabel.Location = new System.Drawing.Point(484, 188);
            cli_Val_CNHLabel.Name = "cli_Val_CNHLabel";
            cli_Val_CNHLabel.Size = new System.Drawing.Size(77, 13);
            cli_Val_CNHLabel.TabIndex = 24;
            cli_Val_CNHLabel.Text = "Validade CNH:";
            // 
            // agileLocadoraDataSet
            // 
            this.agileLocadoraDataSet.DataSetName = "AgileLocadoraDataSet";
            this.agileLocadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.agileLocadoraDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFAProjeto.AgileLocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeiAcessorioTableAdapter = null;
            this.tableAdapterManager.VeiculoTableAdapter = null;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(1233, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // cli_CodTextBox
            // 
            this.cli_CodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_Cod", true));
            this.cli_CodTextBox.Location = new System.Drawing.Point(202, 57);
            this.cli_CodTextBox.MaxLength = 50;
            this.cli_CodTextBox.Name = "cli_CodTextBox";
            this.cli_CodTextBox.ReadOnly = true;
            this.cli_CodTextBox.Size = new System.Drawing.Size(200, 20);
            this.cli_CodTextBox.TabIndex = 13;
            // 
            // cli_NomeTextBox
            // 
            this.cli_NomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_Nome", true));
            this.cli_NomeTextBox.Location = new System.Drawing.Point(202, 83);
            this.cli_NomeTextBox.MaxLength = 50;
            this.cli_NomeTextBox.Name = "cli_NomeTextBox";
            this.cli_NomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cli_NomeTextBox.TabIndex = 1;
            this.cli_NomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_NomeTextBox_KeyPress);
            // 
            // cli_End_CEPTextBox
            // 
            this.cli_End_CEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_End_CEP", true));
            this.cli_End_CEPTextBox.Location = new System.Drawing.Point(202, 109);
            this.cli_End_CEPTextBox.MaxLength = 10;
            this.cli_End_CEPTextBox.Name = "cli_End_CEPTextBox";
            this.cli_End_CEPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cli_End_CEPTextBox.TabIndex = 2;
            this.cli_End_CEPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_End_CEPTextBox_KeyPress);
            // 
            // cli_End_RuaTextBox
            // 
            this.cli_End_RuaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_End_Rua", true));
            this.cli_End_RuaTextBox.Location = new System.Drawing.Point(202, 135);
            this.cli_End_RuaTextBox.MaxLength = 50;
            this.cli_End_RuaTextBox.Name = "cli_End_RuaTextBox";
            this.cli_End_RuaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cli_End_RuaTextBox.TabIndex = 3;
            this.cli_End_RuaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_End_RuaTextBox_KeyPress);
            // 
            // cli_End_BaiTextBox
            // 
            this.cli_End_BaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_End_Bai", true));
            this.cli_End_BaiTextBox.Location = new System.Drawing.Point(202, 161);
            this.cli_End_BaiTextBox.MaxLength = 50;
            this.cli_End_BaiTextBox.Name = "cli_End_BaiTextBox";
            this.cli_End_BaiTextBox.Size = new System.Drawing.Size(200, 20);
            this.cli_End_BaiTextBox.TabIndex = 4;
            this.cli_End_BaiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_End_BaiTextBox_KeyPress);
            // 
            // cli_End_CidTextBox
            // 
            this.cli_End_CidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_End_Cid", true));
            this.cli_End_CidTextBox.Location = new System.Drawing.Point(202, 187);
            this.cli_End_CidTextBox.MaxLength = 50;
            this.cli_End_CidTextBox.Name = "cli_End_CidTextBox";
            this.cli_End_CidTextBox.Size = new System.Drawing.Size(200, 20);
            this.cli_End_CidTextBox.TabIndex = 5;
            this.cli_End_CidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_End_CidTextBox_KeyPress);
            // 
            // cli_End_UFeTextBox
            // 
            this.cli_End_UFeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_End_UFe", true));
            this.cli_End_UFeTextBox.Location = new System.Drawing.Point(577, 54);
            this.cli_End_UFeTextBox.MaxLength = 2;
            this.cli_End_UFeTextBox.Name = "cli_End_UFeTextBox";
            this.cli_End_UFeTextBox.Size = new System.Drawing.Size(209, 20);
            this.cli_End_UFeTextBox.TabIndex = 6;
            this.cli_End_UFeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_End_UFeTextBox_KeyPress);
            // 
            // cli_Dta_NasDateTimePicker
            // 
            this.cli_Dta_NasDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "Cli_Dta_Nas", true));
            this.cli_Dta_NasDateTimePicker.Location = new System.Drawing.Point(577, 106);
            this.cli_Dta_NasDateTimePicker.Name = "cli_Dta_NasDateTimePicker";
            this.cli_Dta_NasDateTimePicker.Size = new System.Drawing.Size(209, 20);
            this.cli_Dta_NasDateTimePicker.TabIndex = 8;
            this.cli_Dta_NasDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_Dta_NasDateTimePicker_KeyPress);
            // 
            // cli_CPFTextBox
            // 
            this.cli_CPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_CPF", true));
            this.cli_CPFTextBox.Location = new System.Drawing.Point(577, 132);
            this.cli_CPFTextBox.MaxLength = 11;
            this.cli_CPFTextBox.Name = "cli_CPFTextBox";
            this.cli_CPFTextBox.Size = new System.Drawing.Size(209, 20);
            this.cli_CPFTextBox.TabIndex = 10;
            this.cli_CPFTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_CPFTextBox_KeyPress);
            // 
            // cli_CNHTextBox
            // 
            this.cli_CNHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_CNH", true));
            this.cli_CNHTextBox.Location = new System.Drawing.Point(577, 158);
            this.cli_CNHTextBox.MaxLength = 20;
            this.cli_CNHTextBox.Name = "cli_CNHTextBox";
            this.cli_CNHTextBox.Size = new System.Drawing.Size(209, 20);
            this.cli_CNHTextBox.TabIndex = 11;
            this.cli_CNHTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_CNHTextBox_KeyPress);
            // 
            // cli_Val_CNHDateTimePicker
            // 
            this.cli_Val_CNHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "Cli_Val_CNH", true));
            this.cli_Val_CNHDateTimePicker.Location = new System.Drawing.Point(577, 184);
            this.cli_Val_CNHDateTimePicker.Name = "cli_Val_CNHDateTimePicker";
            this.cli_Val_CNHDateTimePicker.Size = new System.Drawing.Size(209, 20);
            this.cli_Val_CNHDateTimePicker.TabIndex = 12;
            this.cli_Val_CNHDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_Val_CNHDateTimePicker_KeyPress);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(8, 243);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersWidth = 10;
            this.clienteDataGridView.Size = new System.Drawing.Size(1213, 176);
            this.clienteDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cli_Cod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cli_Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cli_End_CEP";
            this.dataGridViewTextBoxColumn3.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cli_End_Rua";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rua";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cli_End_Bai";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cli_End_Cid";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cli_End_UFe";
            this.dataGridViewTextBoxColumn7.HeaderText = "UF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cli_Fone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cli_Dta_Nas";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data Nascimento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cli_CPF";
            this.dataGridViewTextBoxColumn10.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cli_CNH";
            this.dataGridViewTextBoxColumn11.HeaderText = "CNH";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Cli_Val_CNH";
            this.dataGridViewTextBoxColumn12.HeaderText = "Válidade CNH";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // cli_FoneTextBox
            // 
            this.cli_FoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cli_Fone", true));
            this.cli_FoneTextBox.Location = new System.Drawing.Point(577, 83);
            this.cli_FoneTextBox.MaxLength = 10;
            this.cli_FoneTextBox.Name = "cli_FoneTextBox";
            this.cli_FoneTextBox.Size = new System.Drawing.Size(209, 20);
            this.cli_FoneTextBox.TabIndex = 26;
            this.cli_FoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_FoneTextBox_KeyPress);
            // 
            // EPRcliente
            // 
            this.EPRcliente.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(873, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cli_FoneTextBox);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(cli_CodLabel);
            this.Controls.Add(this.cli_CodTextBox);
            this.Controls.Add(cli_NomeLabel);
            this.Controls.Add(this.cli_NomeTextBox);
            this.Controls.Add(cli_End_CEPLabel);
            this.Controls.Add(this.cli_End_CEPTextBox);
            this.Controls.Add(cli_End_RuaLabel);
            this.Controls.Add(this.cli_End_RuaTextBox);
            this.Controls.Add(cli_End_BaiLabel);
            this.Controls.Add(this.cli_End_BaiTextBox);
            this.Controls.Add(cli_End_CidLabel);
            this.Controls.Add(this.cli_End_CidTextBox);
            this.Controls.Add(cli_End_UFeLabel);
            this.Controls.Add(this.cli_End_UFeTextBox);
            this.Controls.Add(cli_FoneLabel);
            this.Controls.Add(cli_Dta_NasLabel);
            this.Controls.Add(this.cli_Dta_NasDateTimePicker);
            this.Controls.Add(cli_CPFLabel);
            this.Controls.Add(this.cli_CPFTextBox);
            this.Controls.Add(cli_CNHLabel);
            this.Controls.Add(this.cli_CNHTextBox);
            this.Controls.Add(cli_Val_CNHLabel);
            this.Controls.Add(this.cli_Val_CNHDateTimePicker);
            this.Controls.Add(this.clienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agileLocadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPRcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgileLocadoraDataSet agileLocadoraDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private AgileLocadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private AgileLocadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cli_CodTextBox;
        private System.Windows.Forms.TextBox cli_NomeTextBox;
        private System.Windows.Forms.TextBox cli_End_CEPTextBox;
        private System.Windows.Forms.TextBox cli_End_RuaTextBox;
        private System.Windows.Forms.TextBox cli_End_BaiTextBox;
        private System.Windows.Forms.TextBox cli_End_CidTextBox;
        private System.Windows.Forms.TextBox cli_End_UFeTextBox;
        private System.Windows.Forms.DateTimePicker cli_Dta_NasDateTimePicker;
        private System.Windows.Forms.TextBox cli_CPFTextBox;
        private System.Windows.Forms.TextBox cli_CNHTextBox;
        private System.Windows.Forms.DateTimePicker cli_Val_CNHDateTimePicker;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox cli_FoneTextBox;
        private System.Windows.Forms.ErrorProvider EPRcliente;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}

