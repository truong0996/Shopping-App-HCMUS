﻿namespace CSDLNC_TH
{
    partial class GioHang
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
            this.dtgv_gh = new System.Windows.Forms.DataGridView();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.backBtn_gh = new System.Windows.Forms.Button();
            this.fixQuantityBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalMoneyLabel = new System.Windows.Forms.Label();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.updateCartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_gh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_gh
            // 
            this.dtgv_gh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_gh.Location = new System.Drawing.Point(106, 12);
            this.dtgv_gh.Name = "dtgv_gh";
            this.dtgv_gh.RowTemplate.Height = 24;
            this.dtgv_gh.Size = new System.Drawing.Size(682, 333);
            this.dtgv_gh.TabIndex = 0;
            this.dtgv_gh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_gh_CellClick);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(622, 390);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(90, 35);
            this.purchaseBtn.TabIndex = 1;
            this.purchaseBtn.Text = "Mua";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // backBtn_gh
            // 
            this.backBtn_gh.Location = new System.Drawing.Point(10, 12);
            this.backBtn_gh.Name = "backBtn_gh";
            this.backBtn_gh.Size = new System.Drawing.Size(90, 55);
            this.backBtn_gh.TabIndex = 2;
            this.backBtn_gh.Text = "Quay lại";
            this.backBtn_gh.UseVisualStyleBackColor = true;
            // 
            // fixQuantityBtn
            // 
            this.fixQuantityBtn.Location = new System.Drawing.Point(431, 351);
            this.fixQuantityBtn.Name = "fixQuantityBtn";
            this.fixQuantityBtn.Size = new System.Drawing.Size(144, 35);
            this.fixQuantityBtn.TabIndex = 3;
            this.fixQuantityBtn.Text = "Chỉnh sửa số lượng";
            this.fixQuantityBtn.UseVisualStyleBackColor = true;
            this.fixQuantityBtn.Click += new System.EventHandler(this.fixQuantityBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng tiền:";
            // 
            // totalMoneyLabel
            // 
            this.totalMoneyLabel.AutoSize = true;
            this.totalMoneyLabel.Location = new System.Drawing.Point(696, 354);
            this.totalMoneyLabel.Name = "totalMoneyLabel";
            this.totalMoneyLabel.Size = new System.Drawing.Size(16, 17);
            this.totalMoneyLabel.TabIndex = 6;
            this.totalMoneyLabel.Text = "0";
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Location = new System.Drawing.Point(278, 351);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(133, 35);
            this.deleteProductBtn.TabIndex = 7;
            this.deleteProductBtn.Text = "Xóa Sản Phẩm";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // updateCartBtn
            // 
            this.updateCartBtn.Location = new System.Drawing.Point(106, 354);
            this.updateCartBtn.Name = "updateCartBtn";
            this.updateCartBtn.Size = new System.Drawing.Size(144, 32);
            this.updateCartBtn.TabIndex = 10;
            this.updateCartBtn.Text = "Cập nhật giỏ hàng";
            this.updateCartBtn.UseVisualStyleBackColor = true;
            this.updateCartBtn.Click += new System.EventHandler(this.updateCartBtn_Click);
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateCartBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.totalMoneyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fixQuantityBtn);
            this.Controls.Add(this.backBtn_gh);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.dtgv_gh);
            this.Name = "GioHang";
            this.Text = "GioHang";
            this.Load += new System.EventHandler(this.GioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_gh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_gh;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button backBtn_gh;
        private System.Windows.Forms.Button fixQuantityBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalMoneyLabel;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button updateCartBtn;
    }
}