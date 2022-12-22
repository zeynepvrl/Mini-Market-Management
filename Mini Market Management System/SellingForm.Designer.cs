﻿namespace Mini_Market_Management_System
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_order = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.TextBox_qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridView_sellList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_seller = new System.Windows.Forms.Label();
            this.DataGridView_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBox_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_sellList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_order
            // 
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle55;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridView_order.ColumnHeadersHeight = 29;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_order.DefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridView_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_order.Location = new System.Drawing.Point(391, 81);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.RowHeadersVisible = false;
            this.dataGridView_order.RowHeadersWidth = 51;
            this.dataGridView_order.RowTemplate.Height = 24;
            this.dataGridView_order.Size = new System.Drawing.Size(513, 168);
            this.dataGridView_order.TabIndex = 16;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_order.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_order.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_order.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_order.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView_order.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_order.ThemeStyle.HeaderStyle.Height = 29;
            this.dataGridView_order.ThemeStyle.ReadOnly = false;
            this.dataGridView_order.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_order.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_order.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView_order.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_order.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_order.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_order.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 6;
            this.ProdPrice.Name = "ProdPrice";
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 6;
            this.ProdQty.Name = "ProdQty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(385, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 48);
            this.label6.TabIndex = 15;
            this.label6.Text = "Selling";
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(810, 315);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(108, 43);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_print
            // 
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(818, 529);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(108, 43);
            this.button_print.TabIndex = 11;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // TextBox_qty
            // 
            this.TextBox_qty.BorderRadius = 18;
            this.TextBox_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_qty.DefaultText = "";
            this.TextBox_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_qty.Location = new System.Drawing.Point(137, 196);
            this.TextBox_qty.Name = "TextBox_qty";
            this.TextBox_qty.PasswordChar = '\0';
            this.TextBox_qty.PlaceholderText = "";
            this.TextBox_qty.SelectedText = "";
            this.TextBox_qty.Size = new System.Drawing.Size(219, 36);
            this.TextBox_qty.TabIndex = 5;
            // 
            // button_addOrder
            // 
            this.button_addOrder.FlatAppearance.BorderSize = 0;
            this.button_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addOrder.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_addOrder.ForeColor = System.Drawing.Color.White;
            this.button_addOrder.Location = new System.Drawing.Point(165, 238);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(168, 43);
            this.button_addOrder.TabIndex = 10;
            this.button_addOrder.Text = "Add Order";
            this.button_addOrder.UseVisualStyleBackColor = true;
            this.button_addOrder.Click += new System.EventHandler(this.button_addOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_amount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DataGridView_sellList);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_seller);
            this.panel1.Controls.Add(this.DataGridView_product);
            this.panel1.Controls.Add(this.dataGridView_order);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_print);
            this.panel1.Controls.Add(this.TextBox_qty);
            this.panel1.Controls.Add(this.button_addOrder);
            this.panel1.Controls.Add(this.TextBox_price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(170, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 583);
            this.panel1.TabIndex = 28;
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 18;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(648, 322);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(142, 36);
            this.TextBox_id.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(566, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 33);
            this.label8.TabIndex = 26;
            this.label8.Text = "BillID";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.BackColor = System.Drawing.Color.Transparent;
            this.label_amount.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_amount.ForeColor = System.Drawing.Color.White;
            this.label_amount.Location = new System.Drawing.Point(703, 258);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(40, 33);
            this.label_amount.TabIndex = 25;
            this.label_amount.Text = "Ks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(489, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 33);
            this.label7.TabIndex = 24;
            this.label7.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(385, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 33);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sells List";
            // 
            // DataGridView_sellList
            // 
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle58;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_sellList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.DataGridView_sellList.ColumnHeadersHeight = 29;
            this.DataGridView_sellList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_sellList.DefaultCellStyle = dataGridViewCellStyle60;
            this.DataGridView_sellList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.Location = new System.Drawing.Point(391, 361);
            this.DataGridView_sellList.Name = "DataGridView_sellList";
            this.DataGridView_sellList.RowHeadersVisible = false;
            this.DataGridView_sellList.RowHeadersWidth = 51;
            this.DataGridView_sellList.RowTemplate.Height = 24;
            this.DataGridView_sellList.Size = new System.Drawing.Size(513, 167);
            this.DataGridView_sellList.TabIndex = 22;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_sellList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_sellList.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView_sellList.ThemeStyle.ReadOnly = false;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView_sellList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_sellList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_sellList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(266, 312);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(99, 43);
            this.button_refresh.TabIndex = 21;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // comboBox_category
            // 
            this.comboBox_category.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_category.Font = new System.Drawing.Font("Sitka Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_category.ItemHeight = 30;
            this.comboBox_category.Location = new System.Drawing.Point(10, 319);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(250, 36);
            this.comboBox_category.TabIndex = 20;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(770, 45);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(72, 33);
            this.label_date.TabIndex = 19;
            this.label_date.Text = "Date: ";
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.BackColor = System.Drawing.Color.Transparent;
            this.label_seller.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_seller.ForeColor = System.Drawing.Color.White;
            this.label_seller.Location = new System.Drawing.Point(15, 16);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(127, 33);
            this.label_seller.TabIndex = 18;
            this.label_seller.Text = "SellerName";
            // 
            // DataGridView_product
            // 
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.DataGridView_product.ColumnHeadersHeight = 29;
            this.DataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_product.DefaultCellStyle = dataGridViewCellStyle63;
            this.DataGridView_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_product.Location = new System.Drawing.Point(10, 361);
            this.DataGridView_product.Name = "DataGridView_product";
            this.DataGridView_product.RowHeadersVisible = false;
            this.DataGridView_product.RowHeadersWidth = 51;
            this.DataGridView_product.RowTemplate.Height = 24;
            this.DataGridView_product.Size = new System.Drawing.Size(355, 213);
            this.DataGridView_product.TabIndex = 17;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_product.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView_product.ThemeStyle.ReadOnly = false;
            this.DataGridView_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_product.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_product.Click += new System.EventHandler(this.DataGridView_product_Click);
            // 
            // TextBox_price
            // 
            this.TextBox_price.BorderRadius = 18;
            this.TextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_price.DefaultText = "";
            this.TextBox_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_price.Location = new System.Drawing.Point(137, 139);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.PasswordChar = '\0';
            this.TextBox_price.PlaceholderText = "";
            this.TextBox_price.ReadOnly = true;
            this.TextBox_price.SelectedText = "";
            this.TextBox_price.Size = new System.Drawing.Size(219, 36);
            this.TextBox_price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 18;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(137, 82);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.ReadOnly = true;
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(219, 36);
            this.TextBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_logout.ForeColor = System.Drawing.Color.Maroon;
            this.label_logout.Location = new System.Drawing.Point(17, 591);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(118, 41);
            this.label_logout.TabIndex = 33;
            this.label_logout.Text = "Logout";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_exit.ForeColor = System.Drawing.Color.Maroon;
            this.label_exit.Location = new System.Drawing.Point(1061, 7);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(35, 41);
            this.label_exit.TabIndex = 29;
            this.label_exit.Text = "x";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.label_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_sellList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_print;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_qty;
        private System.Windows.Forms.Button button_addOrder;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_product;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_sellList;
        private System.Windows.Forms.Button button_refresh;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_category;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label8;
    }
}