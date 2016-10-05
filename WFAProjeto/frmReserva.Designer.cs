namespace WFAProjeto
{
    partial class frmReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label res_CodLabel;
            System.Windows.Forms.Label res_Clicod;
            System.Windows.Forms.Label res_CatcodLabel;
            System.Windows.Forms.Label res_DtaLabel;
            System.Windows.Forms.Label res_Dta_IniLabel;
            System.Windows.Forms.Label res_Dta_TerLabel;
            System.Windows.Forms.Label res_Resp_AprLabel;
            System.Windows.Forms.Label res_StaLabel;
            System.Windows.Forms.Label res_Dta_AprLabel;
            System.Windows.Forms.Label res_Dta_CncLabel;
            System.Windows.Forms.Label res_Dta_BxaLabel;
            System.Windows.Forms.Label res_Resp_CncLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.reservaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileLocadoraDataSet = new WFAProjeto.AgileLocadoraDataSet();
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
            this.reservaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reservaDataGridView = new System.Windows.Forms.DataGridView();
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
            this.res_CodTextBox = new System.Windows.Forms.TextBox();
            this.txtClicod = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.res_DtaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.DTPTermino = new System.Windows.Forms.DateTimePicker();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.res_Dta_AprDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.res_Dta_CncDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.res_Dta_BxaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtRespCNC = new System.Windows.Forms.TextBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new WFAProjeto.AgileLocadoraDataSetTableAdapters.ReservaTableAdapter();
            this.tableAdapterManager = new WFAProjeto.AgileLocadoraDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new WFAProjeto.AgileLocadoraDataSetTableAdapters.ClienteTableAdapter();
            this.EPReserva = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            res_CodLabel = new System.Windows.Forms.Label();
            res_Clicod = new System.Windows.Forms.Label();
            res_CatcodLabel = new System.Windows.Forms.Label();
            res_DtaLabel = new System.Windows.Forms.Label();
            res_Dta_IniLabel = new System.Windows.Forms.Label();
            res_Dta_TerLabel = new System.Windows.Forms.Label();
            res_Resp_AprLabel = new System.Windows.Forms.Label();
            res_StaLabel = new System.Windows.Forms.Label();
            res_Dta_AprLabel = new System.Windows.Forms.Label();
            res_Dta_CncLabel = new System.Windows.Forms.Label();
            res_Dta_BxaLabel = new System.Windows.Forms.Label();
            res_Resp_CncLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingNavigator)).BeginInit();
            this.reservaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileLocadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // res_CodLabel
            // 
            res_CodLabel.AutoSize = true;
            res_CodLabel.Location = new System.Drawing.Point(24, 56);
            res_CodLabel.Name = "res_CodLabel";
            res_CodLabel.Size = new System.Drawing.Size(43, 13);
            res_CodLabel.TabIndex = 2;
            res_CodLabel.Text = "Código:";
            // 
            // res_Clicod
            // 
            res_Clicod.AutoSize = true;
            res_Clicod.Location = new System.Drawing.Point(23, 82);
            res_Clicod.Name = "res_Clicod";
            res_Clicod.Size = new System.Drawing.Size(93, 13);
            res_Clicod.TabIndex = 4;
            res_Clicod.Text = "Código do Cliente:";
            res_Clicod.Click += new System.EventHandler(this.res_Clicod_Click);
            // 
            // res_CatcodLabel
            // 
            res_CatcodLabel.AutoSize = true;
            res_CatcodLabel.Location = new System.Drawing.Point(22, 109);
            res_CatcodLabel.Name = "res_CatcodLabel";
            res_CatcodLabel.Size = new System.Drawing.Size(109, 13);
            res_CatcodLabel.TabIndex = 6;
            res_CatcodLabel.Text = "Código da Categoria: ";
            // 
            // res_DtaLabel
            // 
            res_DtaLabel.AutoSize = true;
            res_DtaLabel.Location = new System.Drawing.Point(24, 136);
            res_DtaLabel.Name = "res_DtaLabel";
            res_DtaLabel.Size = new System.Drawing.Size(33, 13);
            res_DtaLabel.TabIndex = 8;
            res_DtaLabel.Text = "Data:";
            // 
            // res_Dta_IniLabel
            // 
            res_Dta_IniLabel.AutoSize = true;
            res_Dta_IniLabel.Location = new System.Drawing.Point(24, 162);
            res_Dta_IniLabel.Name = "res_Dta_IniLabel";
            res_Dta_IniLabel.Size = new System.Drawing.Size(63, 13);
            res_Dta_IniLabel.TabIndex = 10;
            res_Dta_IniLabel.Text = "Data Inicial:";
            // 
            // res_Dta_TerLabel
            // 
            res_Dta_TerLabel.AutoSize = true;
            res_Dta_TerLabel.Location = new System.Drawing.Point(24, 188);
            res_Dta_TerLabel.Name = "res_Dta_TerLabel";
            res_Dta_TerLabel.Size = new System.Drawing.Size(74, 13);
            res_Dta_TerLabel.TabIndex = 12;
            res_Dta_TerLabel.Text = "Data Término:";
            // 
            // res_Resp_AprLabel
            // 
            res_Resp_AprLabel.AutoSize = true;
            res_Resp_AprLabel.Location = new System.Drawing.Point(479, 60);
            res_Resp_AprLabel.Name = "res_Resp_AprLabel";
            res_Resp_AprLabel.Size = new System.Drawing.Size(150, 13);
            res_Resp_AprLabel.TabIndex = 14;
            res_Resp_AprLabel.Text = "Responsável pela Aprovação:";
            // 
            // res_StaLabel
            // 
            res_StaLabel.AutoSize = true;
            res_StaLabel.Location = new System.Drawing.Point(479, 86);
            res_StaLabel.Name = "res_StaLabel";
            res_StaLabel.Size = new System.Drawing.Size(40, 13);
            res_StaLabel.TabIndex = 16;
            res_StaLabel.Text = "Status:";
            // 
            // res_Dta_AprLabel
            // 
            res_Dta_AprLabel.AutoSize = true;
            res_Dta_AprLabel.Location = new System.Drawing.Point(479, 113);
            res_Dta_AprLabel.Name = "res_Dta_AprLabel";
            res_Dta_AprLabel.Size = new System.Drawing.Size(88, 13);
            res_Dta_AprLabel.TabIndex = 18;
            res_Dta_AprLabel.Text = "Data Aprovação:";
            // 
            // res_Dta_CncLabel
            // 
            res_Dta_CncLabel.AutoSize = true;
            res_Dta_CncLabel.Location = new System.Drawing.Point(479, 139);
            res_Dta_CncLabel.Name = "res_Dta_CncLabel";
            res_Dta_CncLabel.Size = new System.Drawing.Size(55, 13);
            res_Dta_CncLabel.TabIndex = 20;
            res_Dta_CncLabel.Text = "Data Cnc:";
            // 
            // res_Dta_BxaLabel
            // 
            res_Dta_BxaLabel.AutoSize = true;
            res_Dta_BxaLabel.Location = new System.Drawing.Point(479, 165);
            res_Dta_BxaLabel.Name = "res_Dta_BxaLabel";
            res_Dta_BxaLabel.Size = new System.Drawing.Size(54, 13);
            res_Dta_BxaLabel.TabIndex = 22;
            res_Dta_BxaLabel.Text = "Data Bxa:";
            // 
            // res_Resp_CncLabel
            // 
            res_Resp_CncLabel.AutoSize = true;
            res_Resp_CncLabel.Location = new System.Drawing.Point(479, 190);
            res_Resp_CncLabel.Name = "res_Resp_CncLabel";
            res_Resp_CncLabel.Size = new System.Drawing.Size(94, 13);
            res_Resp_CncLabel.TabIndex = 24;
            res_Resp_CncLabel.Text = "Responsável Cnc:";
            // 
            // reservaBindingNavigator
            // 
            this.reservaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reservaBindingNavigator.BindingSource = this.reservaBindingSource;
            this.reservaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reservaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reservaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.reservaBindingNavigatorSaveItem});
            this.reservaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reservaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reservaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reservaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reservaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reservaBindingNavigator.Name = "reservaBindingNavigator";
            this.reservaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reservaBindingNavigator.Size = new System.Drawing.Size(1225, 25);
            this.reservaBindingNavigator.TabIndex = 0;
            this.reservaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.agileLocadoraDataSet;
            // 
            // agileLocadoraDataSet
            // 
            this.agileLocadoraDataSet.DataSetName = "AgileLocadoraDataSet";
            this.agileLocadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reservaBindingNavigatorSaveItem
            // 
            this.reservaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reservaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reservaBindingNavigatorSaveItem.Image")));
            this.reservaBindingNavigatorSaveItem.Name = "reservaBindingNavigatorSaveItem";
            this.reservaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reservaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.reservaBindingNavigatorSaveItem.Click += new System.EventHandler(this.reservaBindingNavigatorSaveItem_Click);
            // 
            // reservaDataGridView
            // 
            this.reservaDataGridView.AutoGenerateColumns = false;
            this.reservaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.reservaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.reservaDataGridView.DataSource = this.reservaBindingSource;
            this.reservaDataGridView.Location = new System.Drawing.Point(12, 228);
            this.reservaDataGridView.Name = "reservaDataGridView";
            this.reservaDataGridView.RowHeadersWidth = 4;
            this.reservaDataGridView.Size = new System.Drawing.Size(1208, 238);
            this.reservaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Res_Cod";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Da Reserva";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Res_Clicod";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código Do Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Res_Catcod";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código Da Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Res_Dta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Da Reserva";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Res_Dta_Ini";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Inicial";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Res_Dta_Ter";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data Final";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Res_Resp_Apr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Responsável Pela Aprovação";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Res_Sta";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Res_Dta_Apr";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data Aprovação";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Res_Dta_Cnc";
            this.dataGridViewTextBoxColumn10.HeaderText = "Data Cnc";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Res_Dta_Bxa";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data Bxa";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Res_Resp_Cnc";
            this.dataGridViewTextBoxColumn12.HeaderText = "Responsável Cnc";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // res_CodTextBox
            // 
            this.res_CodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Res_Cod", true));
            this.res_CodTextBox.Location = new System.Drawing.Point(180, 53);
            this.res_CodTextBox.Name = "res_CodTextBox";
            this.res_CodTextBox.ReadOnly = true;
            this.res_CodTextBox.Size = new System.Drawing.Size(230, 20);
            this.res_CodTextBox.TabIndex = 3;
            // 
            // txtClicod
            // 
            this.txtClicod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Res_Clicod", true));
            this.txtClicod.Location = new System.Drawing.Point(180, 79);
            this.txtClicod.Name = "txtClicod";
            this.txtClicod.Size = new System.Drawing.Size(230, 20);
            this.txtClicod.TabIndex = 5;
            this.txtClicod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClicod_KeyPress);
            // 
            // txtCat
            // 
            this.txtCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Res_Catcod", true));
            this.txtCat.Location = new System.Drawing.Point(180, 106);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(230, 20);
            this.txtCat.TabIndex = 7;
            this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCat_KeyPress);
            // 
            // res_DtaDateTimePicker
            // 
            this.res_DtaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Res_Dta", true));
            this.res_DtaDateTimePicker.Location = new System.Drawing.Point(180, 132);
            this.res_DtaDateTimePicker.Name = "res_DtaDateTimePicker";
            this.res_DtaDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.res_DtaDateTimePicker.TabIndex = 9;
            // 
            // DTPInicio
            // 
            this.DTPInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Res_Dta_Ini", true));
            this.DTPInicio.Location = new System.Drawing.Point(180, 158);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(230, 20);
            this.DTPInicio.TabIndex = 11;
            // 
            // DTPTermino
            // 
            this.DTPTermino.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Res_Dta_Ter", true));
            this.DTPTermino.Location = new System.Drawing.Point(180, 184);
            this.DTPTermino.Name = "DTPTermino";
            this.DTPTermino.Size = new System.Drawing.Size(230, 20);
            this.DTPTermino.TabIndex = 13;
            // 
            // txtResp
            // 
            this.txtResp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Res_Resp_Apr", true));
            this.txtResp.Location = new System.Drawing.Point(635, 57);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(230, 20);
            this.txtResp.TabIndex = 15;
            this.txtResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResp_KeyPress);
            // 
            // txtStatus
            // 
            this.txtStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Res_Sta", true));
            this.txtStatus.Location = new System.Drawing.Point(635, 83);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(230, 20);
            this.txtStatus.TabIndex = 17;
            this.txtStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStatus_KeyPress);
            // 
            // res_Dta_AprDateTimePicker
            // 
            this.res_Dta_AprDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Res_Dta_Apr", true));
            this.res_Dta_AprDateTimePicker.Location = new System.Drawing.Point(635, 109);
            this.res_Dta_AprDateTimePicker.Name = "res_Dta_AprDateTimePicker";
            this.res_Dta_AprDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.res_Dta_AprDateTimePicker.TabIndex = 19;
            // 
            // res_Dta_CncDateTimePicker
            // 
            this.res_Dta_CncDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Res_Dta_Cnc", true));
            this.res_Dta_CncDateTimePicker.Location = new System.Drawing.Point(635, 135);
            this.res_Dta_CncDateTimePicker.Name = "res_Dta_CncDateTimePicker";
            this.res_Dta_CncDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.res_Dta_CncDateTimePicker.TabIndex = 21;
            // 
            // res_Dta_BxaDateTimePicker
            // 
            this.res_Dta_BxaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservaBindingSource, "Res_Dta_Bxa", true));
            this.res_Dta_BxaDateTimePicker.Location = new System.Drawing.Point(635, 161);
            this.res_Dta_BxaDateTimePicker.Name = "res_Dta_BxaDateTimePicker";
            this.res_Dta_BxaDateTimePicker.Size = new System.Drawing.Size(230, 20);
            this.res_Dta_BxaDateTimePicker.TabIndex = 23;
            // 
            // txtRespCNC
            // 
            this.txtRespCNC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Res_Resp_Cnc", true));
            this.txtRespCNC.Location = new System.Drawing.Point(635, 187);
            this.txtRespCNC.Name = "txtRespCNC";
            this.txtRespCNC.Size = new System.Drawing.Size(230, 20);
            this.txtRespCNC.TabIndex = 25;
            this.txtRespCNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRespCNC_KeyPress);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\Semestre IV\\C#\\WFAProjeto\\WFAPr" +
    "ojeto\\AgileLocadora.accdb\"";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.agileLocadoraDataSet;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.ReservaTableAdapter = this.reservaTableAdapter;
            this.tableAdapterManager.UpdateOrder = WFAProjeto.AgileLocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeiAcessorioTableAdapter = null;
            this.tableAdapterManager.VeiculoTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // EPReserva
            // 
            this.EPReserva.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(908, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(res_CodLabel);
            this.Controls.Add(this.res_CodTextBox);
            this.Controls.Add(res_Clicod);
            this.Controls.Add(this.txtClicod);
            this.Controls.Add(res_CatcodLabel);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(res_DtaLabel);
            this.Controls.Add(this.res_DtaDateTimePicker);
            this.Controls.Add(res_Dta_IniLabel);
            this.Controls.Add(this.DTPInicio);
            this.Controls.Add(res_Dta_TerLabel);
            this.Controls.Add(this.DTPTermino);
            this.Controls.Add(res_Resp_AprLabel);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(res_StaLabel);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(res_Dta_AprLabel);
            this.Controls.Add(this.res_Dta_AprDateTimePicker);
            this.Controls.Add(res_Dta_CncLabel);
            this.Controls.Add(this.res_Dta_CncDateTimePicker);
            this.Controls.Add(res_Dta_BxaLabel);
            this.Controls.Add(this.res_Dta_BxaDateTimePicker);
            this.Controls.Add(res_Resp_CncLabel);
            this.Controls.Add(this.txtRespCNC);
            this.Controls.Add(this.reservaDataGridView);
            this.Controls.Add(this.reservaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingNavigator)).EndInit();
            this.reservaBindingNavigator.ResumeLayout(false);
            this.reservaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileLocadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgileLocadoraDataSet agileLocadoraDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private AgileLocadoraDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private AgileLocadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reservaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton reservaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView reservaDataGridView;
        private System.Windows.Forms.TextBox res_CodTextBox;
        private System.Windows.Forms.TextBox txtClicod;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.DateTimePicker res_DtaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.DateTimePicker DTPTermino;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DateTimePicker res_Dta_AprDateTimePicker;
        private System.Windows.Forms.DateTimePicker res_Dta_CncDateTimePicker;
        private System.Windows.Forms.DateTimePicker res_Dta_BxaDateTimePicker;
        private System.Windows.Forms.TextBox txtRespCNC;
        private AgileLocadoraDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Windows.Forms.ErrorProvider EPReserva;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}