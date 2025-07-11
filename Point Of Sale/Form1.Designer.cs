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
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.point_Of_SaleDataSet1 = new Point_Of_Sale.Point_Of_SaleDataSet1();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.point_Of_SaleDataSet = new Point_Of_Sale.Point_Of_SaleDataSet();
            this.ordersTableAdapter = new Point_Of_Sale.Point_Of_SaleDataSetTableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter1 = new Point_Of_Sale.Point_Of_SaleDataSet1TableAdapters.OrdersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_vis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet)).BeginInit();
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
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1027, 55);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(115, 54);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
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
            this.Orders_vis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders_vis.Location = new System.Drawing.Point(39, 92);
            this.Orders_vis.Name = "Orders_vis";
            this.Orders_vis.RowHeadersWidth = 51;
            this.Orders_vis.RowTemplate.Height = 24;
            this.Orders_vis.Size = new System.Drawing.Size(766, 230);
            this.Orders_vis.TabIndex = 5;
            this.Orders_vis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Orders_vis_CellContentClick);
            this.Orders_vis.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Orders_vis_UserDeletingRow);
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.point_Of_SaleDataSet1;
            // 
            // point_Of_SaleDataSet1
            // 
            this.point_Of_SaleDataSet1.DataSetName = "Point_Of_SaleDataSet1";
            this.point_Of_SaleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Total.Location = new System.Drawing.Point(748, 360);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(57, 24);
            this.Total.TabIndex = 7;
            this.Total.Text = "Total";
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(105, 362);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(157, 22);
            this.Payment.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Change";
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Change.Location = new System.Drawing.Point(424, 360);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(82, 24);
            this.Change.TabIndex = 11;
            this.Change.Text = "Change";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 450);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_Of_SaleDataSet)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox Payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Change;
    }
}

