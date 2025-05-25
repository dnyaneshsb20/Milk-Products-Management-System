namespace MilkProductsManagement
{
    partial class ManageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbItemUnit = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.milkDataSet4 = new MilkProductsManagement.MilkDataSet4();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkDataSet2 = new MilkProductsManagement.MilkDataSet2();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.milkDataSet5 = new MilkProductsManagement.MilkDataSet5();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkDataSet1 = new MilkProductsManagement.MilkDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.categoryTableAdapter = new MilkProductsManagement.MilkDataSet1TableAdapters.CategoryTableAdapter();
            this.unitsTableAdapter = new MilkProductsManagement.MilkDataSet2TableAdapters.UnitsTableAdapter();
            this.unitsTableAdapter1 = new MilkProductsManagement.MilkDataSet4TableAdapters.UnitsTableAdapter();
            this.categoryTableAdapter1 = new MilkProductsManagement.MilkDataSet5TableAdapters.CategoryTableAdapter();
            this.gridViewItemAdded = new System.Windows.Forms.DataGridView();
            this.milkDataSet3 = new MilkProductsManagement.MilkDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItemAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MilkProductsManagement.Properties.Resources.Milk_Drip_HD_Desktop_Wallpaper_43863;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 71);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(199, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Product";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(360, 19);
            this.txtItemName.MaxLength = 50;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(212, 21);
            this.txtItemName.TabIndex = 23;
            this.txtItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Product Unit :-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Product Name :-";
            // 
            // cmbItemUnit
            // 
            this.cmbItemUnit.DataSource = this.unitsBindingSource1;
            this.cmbItemUnit.DisplayMember = "UnitName";
            this.cmbItemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemUnit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemUnit.FormattingEnabled = true;
            this.cmbItemUnit.Location = new System.Drawing.Point(360, 56);
            this.cmbItemUnit.Name = "cmbItemUnit";
            this.cmbItemUnit.Size = new System.Drawing.Size(212, 21);
            this.cmbItemUnit.TabIndex = 24;
            this.cmbItemUnit.ValueMember = "UnitID";
            // 
            // unitsBindingSource1
            // 
            this.unitsBindingSource1.DataMember = "Units";
            this.unitsBindingSource1.DataSource = this.milkDataSet4;
            // 
            // milkDataSet4
            // 
            this.milkDataSet4.DataSetName = "MilkDataSet4";
            this.milkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.milkDataSet2;
            // 
            // milkDataSet2
            // 
            this.milkDataSet2.DataSetName = "MilkDataSet2";
            this.milkDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.DataSource = this.categoryBindingSource1;
            this.cmbItemCategory.DisplayMember = "CategoryName";
            this.cmbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(360, 94);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(212, 21);
            this.cmbItemCategory.TabIndex = 26;
            this.cmbItemCategory.ValueMember = "CategoryID";
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.milkDataSet5;
            // 
            // milkDataSet5
            // 
            this.milkDataSet5.DataSetName = "MilkDataSet5";
            this.milkDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.milkDataSet1;
            // 
            // milkDataSet1
            // 
            this.milkDataSet1.DataSetName = "MilkDataSet1";
            this.milkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Product Category :-";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemPrice.Location = new System.Drawing.Point(360, 132);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(212, 21);
            this.txtItemPrice.TabIndex = 28;
            this.txtItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemPrice_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Product Price :-";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(135, 164);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(82, 28);
            this.btnAddItem.TabIndex = 29;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter1
            // 
            this.unitsTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // gridViewItemAdded
            // 
            this.gridViewItemAdded.AllowUserToAddRows = false;
            this.gridViewItemAdded.AllowUserToDeleteRows = false;
            this.gridViewItemAdded.AllowUserToOrderColumns = true;
            this.gridViewItemAdded.AllowUserToResizeColumns = false;
            this.gridViewItemAdded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewItemAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewItemAdded.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridViewItemAdded.Location = new System.Drawing.Point(0, 277);
            this.gridViewItemAdded.Name = "gridViewItemAdded";
            this.gridViewItemAdded.ReadOnly = true;
            this.gridViewItemAdded.Size = new System.Drawing.Size(732, 292);
            this.gridViewItemAdded.TabIndex = 30;
            this.gridViewItemAdded.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewItemAdded_CellClick);
            this.gridViewItemAdded.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridViewItemAdded_CellFormatting);
            // 
            // milkDataSet3
            // 
            this.milkDataSet3.DataSetName = "MilkDataSet";
            this.milkDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(259, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 28);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblProductID);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Controls.Add(this.cmbItemUnit);
            this.panel2.Controls.Add(this.txtItemPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbItemCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 205);
            this.panel2.TabIndex = 32;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(22, 116);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(0, 13);
            this.lblProductID.TabIndex = 37;
            this.lblProductID.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(507, 164);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 28);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(383, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 28);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridViewItemAdded);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItemAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbItemUnit;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItem;
        private MilkDataSet1 milkDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MilkDataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private MilkDataSet2 milkDataSet2;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private MilkDataSet2TableAdapters.UnitsTableAdapter unitsTableAdapter;
        private MilkDataSet4 milkDataSet4;
        private System.Windows.Forms.BindingSource unitsBindingSource1;
        private MilkDataSet4TableAdapters.UnitsTableAdapter unitsTableAdapter1;
        private MilkDataSet5 milkDataSet5;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private MilkDataSet5TableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private System.Windows.Forms.DataGridView gridViewItemAdded;
        private MilkDataSet milkDataSet3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProductID;
    }
}