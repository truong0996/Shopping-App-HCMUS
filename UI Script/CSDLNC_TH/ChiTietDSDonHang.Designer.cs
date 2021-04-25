namespace CSDLNC_TH
{
    partial class ChiTietDSDonHang
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
            this.dtgv_ctietDsDh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ctietDsDh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ctietDsDh
            // 
            this.dtgv_ctietDsDh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ctietDsDh.Location = new System.Drawing.Point(12, 12);
            this.dtgv_ctietDsDh.Name = "dtgv_ctietDsDh";
            this.dtgv_ctietDsDh.RowTemplate.Height = 24;
            this.dtgv_ctietDsDh.Size = new System.Drawing.Size(875, 332);
            this.dtgv_ctietDsDh.TabIndex = 2;
            // 
            // ChiTietDSDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 356);
            this.Controls.Add(this.dtgv_ctietDsDh);
            this.Name = "ChiTietDSDonHang";
            this.Text = "ChiTietDSDonHang";
            this.Load += new System.EventHandler(this.ChiTietDSDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ctietDsDh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ctietDsDh;
    }
}