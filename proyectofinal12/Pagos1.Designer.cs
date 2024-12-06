namespace proyectofinal12
{
    partial class Pagos1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btneditar = new Guna.UI2.WinForms.Guna2Button();
            this.btncomfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtnombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbpedido = new Guna.UI2.WinForms.Guna2ComboBox();
            this.opcionesparallevarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu13DataSet1 = new proyectofinal12.menu13DataSet1();
            this.cbmetodo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.metodospagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu13DataSet = new proyectofinal12.menu13DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodos_pagoTableAdapter = new proyectofinal12.menu13DataSetTableAdapters.metodos_pagoTableAdapter();
            this.opciones_para_llevarTableAdapter = new proyectofinal12.menu13DataSet1TableAdapters.opciones_para_llevarTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesparallevarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu13DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodospagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu13DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panta)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 526F));
            this.tableLayoutPanel1.Controls.Add(this.btneditar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btncomfirmar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 619);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1054, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btneditar
            // 
            this.btneditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneditar.AutoRoundedCorners = true;
            this.btneditar.BorderRadius = 21;
            this.btneditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditar.FillColor = System.Drawing.Color.DarkRed;
            this.btneditar.Font = new System.Drawing.Font("Garamond", 11F);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(174, 27);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(180, 45);
            this.btneditar.TabIndex = 0;
            this.btneditar.Text = "Atra";
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncomfirmar
            // 
            this.btncomfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncomfirmar.AutoRoundedCorners = true;
            this.btncomfirmar.BorderRadius = 21;
            this.btncomfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncomfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncomfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncomfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncomfirmar.FillColor = System.Drawing.Color.DarkRed;
            this.btncomfirmar.Font = new System.Drawing.Font("Garamond", 11F);
            this.btncomfirmar.ForeColor = System.Drawing.Color.White;
            this.btncomfirmar.Location = new System.Drawing.Point(693, 27);
            this.btncomfirmar.Name = "btncomfirmar";
            this.btncomfirmar.Size = new System.Drawing.Size(196, 45);
            this.btncomfirmar.TabIndex = 1;
            this.btncomfirmar.Text = "Confirmar pedido";
            this.btncomfirmar.Click += new System.EventHandler(this.btncomfirmar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtnombre, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 519);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1054, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Animated = true;
            this.txtnombre.BorderRadius = 5;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.DefaultText = "";
            this.txtnombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnombre.FillColor = System.Drawing.Color.Snow;
            this.txtnombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombre.Font = new System.Drawing.Font("Garamond", 11F);
            this.txtnombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnombre.Location = new System.Drawing.Point(334, 20);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.PlaceholderText = "Escriba su nombre para terminar el pedido";
            this.txtnombre.SelectedText = "";
            this.txtnombre.Size = new System.Drawing.Size(386, 60);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.37951F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.62049F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panta, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 457F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1054, 519);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.cbpedido, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbmetodo, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(534, 65);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(517, 451);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // cbpedido
            // 
            this.cbpedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbpedido.AutoRoundedCorners = true;
            this.cbpedido.BackColor = System.Drawing.Color.Transparent;
            this.cbpedido.BorderRadius = 17;
            this.cbpedido.DataSource = this.opcionesparallevarBindingSource;
            this.cbpedido.DisplayMember = "descripcion";
            this.cbpedido.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbpedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpedido.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbpedido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbpedido.Font = new System.Drawing.Font("Garamond", 11F);
            this.cbpedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbpedido.ItemHeight = 30;
            this.cbpedido.Location = new System.Drawing.Point(261, 94);
            this.cbpedido.Name = "cbpedido";
            this.cbpedido.Size = new System.Drawing.Size(247, 36);
            this.cbpedido.TabIndex = 0;
            this.cbpedido.SelectedIndexChanged += new System.EventHandler(this.bttipodepedido_SelectedIndexChanged);
            // 
            // opcionesparallevarBindingSource
            // 
            this.opcionesparallevarBindingSource.DataMember = "opciones_para_llevar";
            this.opcionesparallevarBindingSource.DataSource = this.menu13DataSet1;
            // 
            // menu13DataSet1
            // 
            this.menu13DataSet1.DataSetName = "menu13DataSet1";
            this.menu13DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbmetodo
            // 
            this.cbmetodo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbmetodo.AutoRoundedCorners = true;
            this.cbmetodo.BackColor = System.Drawing.Color.Transparent;
            this.cbmetodo.BorderRadius = 17;
            this.cbmetodo.DataSource = this.metodospagoBindingSource;
            this.cbmetodo.DisplayMember = "nombre";
            this.cbmetodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmetodo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmetodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmetodo.Font = new System.Drawing.Font("Garamond", 11F);
            this.cbmetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmetodo.ItemHeight = 30;
            this.cbmetodo.Location = new System.Drawing.Point(261, 320);
            this.cbmetodo.Name = "cbmetodo";
            this.cbmetodo.Size = new System.Drawing.Size(247, 36);
            this.cbmetodo.TabIndex = 1;
            this.cbmetodo.SelectedIndexChanged += new System.EventHandler(this.btmetododepago_SelectedIndexChanged);
            // 
            // metodospagoBindingSource
            // 
            this.metodospagoBindingSource.DataMember = "metodos_pago";
            this.metodospagoBindingSource.DataSource = this.menu13DataSet;
            // 
            // menu13DataSet
            // 
            this.menu13DataSet.DataSetName = "menu13DataSet";
            this.menu13DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de pedido";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Metodo de pago";
            // 
            // panta
            // 
            this.panta.AllowUserToAddRows = false;
            this.panta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.panta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.panta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.panta.ColumnHeadersHeight = 22;
            this.panta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.panta.DefaultCellStyle = dataGridViewCellStyle9;
            this.panta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.panta.Location = new System.Drawing.Point(3, 65);
            this.panta.Name = "panta";
            this.panta.ReadOnly = true;
            this.panta.RowHeadersVisible = false;
            this.panta.RowHeadersWidth = 62;
            this.panta.RowTemplate.Height = 28;
            this.panta.Size = new System.Drawing.Size(525, 451);
            this.panta.TabIndex = 2;
            this.panta.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.panta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.panta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.panta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.panta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.panta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.panta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.panta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.panta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkRed;
            this.panta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.panta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.panta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.panta.ThemeStyle.HeaderStyle.Height = 22;
            this.panta.ThemeStyle.ReadOnly = true;
            this.panta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.panta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.panta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.panta.ThemeStyle.RowsStyle.Height = 28;
            this.panta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.panta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // metodos_pagoTableAdapter
            // 
            this.metodos_pagoTableAdapter.ClearBeforeFill = true;
            // 
            // opciones_para_llevarTableAdapter
            // 
            this.opciones_para_llevarTableAdapter.ClearBeforeFill = true;
            // 
            // Pagos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 719);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos1";
            this.Text = "Pagos1";
            this.Load += new System.EventHandler(this.Pagos1_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesparallevarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu13DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodospagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu13DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Guna.UI2.WinForms.Guna2TextBox txtnombre;
        private Guna.UI2.WinForms.Guna2ComboBox cbpedido;
        private Guna.UI2.WinForms.Guna2ComboBox cbmetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btneditar;
        private Guna.UI2.WinForms.Guna2Button btncomfirmar;
        private Guna.UI2.WinForms.Guna2DataGridView panta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private menu13DataSet menu13DataSet;
        private System.Windows.Forms.BindingSource metodospagoBindingSource;
        private menu13DataSetTableAdapters.metodos_pagoTableAdapter metodos_pagoTableAdapter;
        private menu13DataSet1 menu13DataSet1;
        private System.Windows.Forms.BindingSource opcionesparallevarBindingSource;
        private menu13DataSet1TableAdapters.opciones_para_llevarTableAdapter opciones_para_llevarTableAdapter;
    }
}