namespace Point_Of_Sale
{
    partial class POS
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
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Close_Bill = new System.Windows.Forms.Button();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.Orders_vis = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.point_Of_SaleDataSet = new Point_Of_Sale.Point_Of_SaleDataSet();
            this.ordersTableAdapter = new Point_Of_Sale.Point_Of_SaleDataSetTableAdapters.OrdersTableAdapter();
            this.point_Of_SaleDataSet1 = new Point_Of_Sale.Point_Of_SaleDataSet1();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new Point_Of_Sale.Point_Of_SaleDataSet1TableAdapters.OrdersTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_vis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(891, 55);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(115, 54);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1027, 55);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(115, 54);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1161, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Close_Bill
            // 
            this.Close_Bill.Location = new System.Drawing.Point(891, 273);
            this.Close_Bill.Name = "Close_Bill";
            this.Close_Bill.Size = new System.Drawing.Size(385, 54);
            this.Close_Bill.TabIndex = 3;
            this.Close_Bill.Text = "Close Bill";
            this.Close_Bill.UseVisualStyleBackColor = true;
            // 
            // Barcode
            // 
            this.Barcode.Location = new System.Drawing.Point(39, 55);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(205, 22);
            this.Barcode.TabIndex = 4;
            this.Barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Barcode_KeyDown);
            // 
            // Orders_vis
            // 
            this.Orders_vis.AllowUserToAddRows = false;
            this.Orders_vis.AutoGenerateColumns = false;
            this.Orders_vis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders_vis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn});
            this.Orders_vis.DataSource = this.ordersBindingSource1;
            this.Orders_vis.Location = new System.Drawing.Point(39, 92);
            this.Orders_vis.Name = "Orders_vis";
            this.Orders_vis.RowHeadersWidth = 51;
            this.Orders_vis.RowTemplate.Height = 24;
            this.Orders_vis.Size = new System.Drawing.Size(766, 230);
            this.Orders_vis.TabIndex = 5;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.point_Of_SaleDataSet;
            // 
            // point_Of_SaleDataSet
            // 
            this.point_Of_SaleDataSet.DataSetName = "Point_Of_SaleDataSet";
            this.point_Of_SaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // point_Of_SaleDataSet1
            // 
            this.point_Of_SaleDataSet1.DataSetName = "Point_Of_SaleDataSet1";
            this.point_Of_SaleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.point_Of_SaleDataSet1;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 450);
            this.Controls.Add(this.Orders_vis);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.Close_Bill);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Exit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Of Sale";
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Orders_vis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Close_Bill;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.DataGridView Orders_vis;
        private Point_Of_SaleDataSet point_Of_SaleDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Point_Of_SaleDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Point_Of_SaleDataSet1 point_Of_SaleDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private Point_Of_SaleDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
    }
}

