namespace MilkProductsManagement
{
    partial class ManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkDataSet10 = new MilkProductsManagement.MilkDataSet10();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new MilkProductsManagement.MilkDataSet10TableAdapters.CategoryTableAdapter();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.gridViewManageCategory = new System.Windows.Forms.DataGridView();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManageCategory)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(532, 71);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(88, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Category";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.milkDataSet10;
            // 
            // milkDataSet10
            // 
            this.milkDataSet10.DataSetName = "MilkDataSet10";
            this.milkDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter New Category :-";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCategory.Location = new System.Drawing.Point(274, 88);
            this.txtNewCategory.MaxLength = 50;
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(195, 21);
            this.txtNewCategory.TabIndex = 21;
            this.txtNewCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewCategory_KeyPress);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(116, 131);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(82, 28);
            this.btnAddCategory.TabIndex = 22;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // gridViewManageCategory
            // 
            this.gridViewManageCategory.AllowUserToAddRows = false;
            this.gridViewManageCategory.AllowUserToDeleteRows = false;
            this.gridViewManageCategory.AllowUserToOrderColumns = true;
            this.gridViewManageCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewManageCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewManageCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridViewManageCategory.Location = new System.Drawing.Point(0, 175);
            this.gridViewManageCategory.Name = "gridViewManageCategory";
            this.gridViewManageCategory.ReadOnly = true;
            this.gridViewManageCategory.Size = new System.Drawing.Size(532, 301);
            this.gridViewManageCategory.TabIndex = 23;
            this.gridViewManageCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewManageCategory_CellClick);
            this.gridViewManageCategory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridViewManageCategory_CellFormatting);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.AutoSize = true;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.Location = new System.Drawing.Point(213, 131);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(82, 28);
            this.btnUpdateCategory.TabIndex = 24;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(310, 131);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 28);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(27, 140);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryID.TabIndex = 36;
            this.lblCategoryID.Visible = false;
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 476);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.gridViewManageCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtNewCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategory";
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewManageCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MilkDataSet10 milkDataSet10;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private MilkDataSet10TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView gridViewManageCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCategoryID;
    }
}