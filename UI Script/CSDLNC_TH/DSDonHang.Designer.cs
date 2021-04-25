namespace CSDLNC_TH
{
    partial class DSDonHang
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
            this.dtgv_dsdonHang = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.billDetailBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsdonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_dsdonHang
            // 
            this.dtgv_dsdonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dsdonHang.Location = new System.Drawing.Point(169, 12);
            this.dtgv_dsdonHang.Name = "dtgv_dsdonHang";
            this.dtgv_dsdonHang.RowTemplate.Height = 24;
            this.dtgv_dsdonHang.Size = new System.Drawing.Size(706, 426);
            this.dtgv_dsdonHang.TabIndex = 1;
            this.dtgv_dsdonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsdonHang_CellClick);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(12, 250);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(142, 54);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // billDetailBtn
            // 
            this.billDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDetailBtn.Location = new System.Drawing.Point(12, 74);
            this.billDetailBtn.Name = "billDetailBtn";
            this.billDetailBtn.Size = new System.Drawing.Size(142, 68);
            this.billDetailBtn.TabIndex = 21;
            this.billDetailBtn.Text = "Chi tiết đơn hàng";
            this.billDetailBtn.UseVisualStyleBackColor = true;
            this.billDetailBtn.Click += new System.EventHandler(this.billDetailBtn_Click);
            // 
            // DSDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.billDetailBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dtgv_dsdonHang);
            this.Name = "DSDonHang";
            this.Text = "DSDonHangcs";
            this.Load += new System.EventHandler(this.DSDonHangcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsdonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_dsdonHang;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button billDetailBtn;
    }
}