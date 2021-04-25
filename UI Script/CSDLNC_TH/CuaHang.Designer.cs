namespace CSDLNC_TH
{
    partial class CuaHang
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
            this.dtgv_ch = new System.Windows.Forms.DataGridView();
            this.billBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shopNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ch)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ch
            // 
            this.dtgv_ch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ch.Location = new System.Drawing.Point(151, 12);
            this.dtgv_ch.Name = "dtgv_ch";
            this.dtgv_ch.RowTemplate.Height = 24;
            this.dtgv_ch.Size = new System.Drawing.Size(743, 356);
            this.dtgv_ch.TabIndex = 0;
            this.dtgv_ch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ch_CellClick);
            // 
            // billBtn
            // 
            this.billBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBtn.Location = new System.Drawing.Point(23, 122);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(100, 54);
            this.billBtn.TabIndex = 6;
            this.billBtn.Text = "Danh sách đơn hàng";
            this.billBtn.UseVisualStyleBackColor = true;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(23, 223);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 54);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.Location = new System.Drawing.Point(567, 374);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(161, 43);
            this.addProductBtn.TabIndex = 16;
            this.addProductBtn.Text = "Thêm sản phẩm";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductBtn.Location = new System.Drawing.Point(733, 374);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(161, 43);
            this.deleteProductBtn.TabIndex = 17;
            this.deleteProductBtn.Text = "Xóa sản phẩm";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(151, 374);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(127, 43);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Cập nhật";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Shop Name:";
            // 
            // shopNameLabel
            // 
            this.shopNameLabel.AutoSize = true;
            this.shopNameLabel.Location = new System.Drawing.Point(2, 38);
            this.shopNameLabel.Name = "shopNameLabel";
            this.shopNameLabel.Size = new System.Drawing.Size(16, 17);
            this.shopNameLabel.TabIndex = 20;
            this.shopNameLabel.Text = "0";
            // 
            // CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.shopNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.billBtn);
            this.Controls.Add(this.dtgv_ch);
            this.Name = "CuaHang";
            this.Text = "CuaHang";
            this.Load += new System.EventHandler(this.CuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ch;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shopNameLabel;
    }
}